// Decompiled with JetBrains decompiler
// Type: AuthGG.Security
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace AuthGG
{
  internal class Security
  {
    private const string _key = "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";

    public static string Signature(string value)
    {
      using (MD5 md5 = MD5.Create())
      {
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        return BitConverter.ToString(md5.ComputeHash(bytes)).Replace("-", "");
      }
    }

    private static string Session(int length)
    {
      Random random = new Random();
      return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", length).Select<string, char>((Func<string, char>) (s => s[random.Next(s.Length)])).ToArray<char>());
    }

    public static string Obfuscate(int length)
    {
      Random random = new Random();
      return new string(Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", length).Select<string, char>((Func<string, char>) (s => s[random.Next(s.Length)])).ToArray<char>());
    }

    public static void Start()
    {
      string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
      if (Constants.Started)
      {
        Colorful.Console.WriteLine("A session has already been started, please end the previous one!");
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else
      {
        using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
        {
          if (streamReader.ReadToEnd().Contains("api.auth.gg"))
          {
            Constants.Breached = true;
            Colorful.Console.WriteLine("DNS redirecting has been detected!");
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
        }
        new InfoManager().StartListener();
        Constants.Token = Guid.NewGuid().ToString();
        ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(AuthGG.Security.PinPublicKey);
        Constants.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes(AuthGG.Security.Session(32)));
        Constants.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes(AuthGG.Security.Session(16)));
        Constants.IV = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(16)));
        Constants.Key = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(32)));
        Constants.Started = true;
      }
    }

    public static void End()
    {
      if (!Constants.Started)
      {
        Colorful.Console.WriteLine("No session has been started, closing for security reasons!");
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else
      {
        Constants.Token = (string) null;
        ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback) ((_param1, _param2, _param3, _param4) => true);
        Constants.APIENCRYPTKEY = (string) null;
        Constants.APIENCRYPTSALT = (string) null;
        Constants.IV = (string) null;
        Constants.Key = (string) null;
        Constants.Started = false;
      }
    }

    private static bool PinPublicKey(
      object sender,
      X509Certificate certificate,
      X509Chain chain,
      SslPolicyErrors sslPolicyErrors)
    {
      return certificate != null && certificate.GetPublicKeyString() == "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
    }

    public static string Integrity(string filename)
    {
      using (MD5 md5 = MD5.Create())
      {
        using (FileStream fileStream = System.IO.File.OpenRead(filename))
          return BitConverter.ToString(md5.ComputeHash((Stream) fileStream)).Replace("-", "").ToLowerInvariant();
      }
    }

    public static bool MaliciousCheck(string date)
    {
      TimeSpan timeSpan = DateTime.Parse(date) - DateTime.Now;
      if (Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) < 5 && Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) < 1)
        return false;
      Constants.Breached = true;
      return true;
    }
  }
}
