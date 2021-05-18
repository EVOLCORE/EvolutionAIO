// Decompiled with JetBrains decompiler
// Type: AuthGG.OnProgramStart
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;

namespace AuthGG
{
  internal class OnProgramStart
  {
    public static string AID;
    public static string Secret;
    public static string Version;
    public static string Name;
    public static string Salt;

    public static void Initialize(string name, string aid, string secret, string version)
    {
      if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || (string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version)))
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Invalid application information!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      OnProgramStart.AID = aid;
      OnProgramStart.Secret = secret;
      OnProgramStart.Version = version;
      OnProgramStart.Name = name;
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          webClient.Proxy = (IWebProxy) null;
          Security.Start();
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            [nameof (aid)] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["session_key"] = Constants.Key,
            [nameof (secret)] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("start")
          }))).Split("|".ToCharArray());
          if (Security.MaliciousCheck(strArray2[1]))
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          if (Constants.Breached)
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Security error has been triggered!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          string str = strArray2[2];
          if (!(str == "success"))
          {
            if (!(str == "binderror"))
            {
              if (str == "banned")
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("404", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg", Color.Red);
                Thread.Sleep(2000);
                Environment.Exit(0);
                return;
              }
            }
            else
            {
              Colorful.Console.WriteLine(Encryption.Decode("RmFpbGVkIHRvIGJpbmQgdG8gc2VydmVyLCBjaGVjayB5b3VyIEFJRCAmIFNlY3JldCBpbiB5b3VyIGNvZGUh"));
              Thread.Sleep(2000);
              Environment.Exit(0);
              return;
            }
          }
          else
          {
            Constants.Initialized = true;
            if (strArray2[3] == "Enabled")
              ApplicationSettings.Status = true;
            if (strArray2[4] == "Enabled")
              ApplicationSettings.DeveloperMode = true;
            ApplicationSettings.Hash = strArray2[5];
            ApplicationSettings.Version = strArray2[6];
            ApplicationSettings.Update_Link = strArray2[7];
            if (strArray2[8] == "Enabled")
              ApplicationSettings.Freemode = true;
            if (strArray2[9] == "Enabled")
              ApplicationSettings.Login = true;
            ApplicationSettings.Name = strArray2[10];
            if (strArray2[11] == "Enabled")
              ApplicationSettings.Register = true;
            if (ApplicationSettings.DeveloperMode)
            {
              Colorful.Console.Write(" [", Color.GhostWhite);
              Colorful.Console.Write("+", Color.Orange);
              Colorful.Console.Write("] ", Color.GhostWhite);
              Colorful.Console.WriteLine("Application is in Developer Mode, bypassing integrity and update check!", Color.GhostWhite);
              Thread.Sleep(2000);
              System.IO.File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
              System.IO.File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", Security.Integrity(Process.GetCurrentProcess().MainModule.FileName));
              Colorful.Console.Write(" [", Color.GhostWhite);
              Colorful.Console.Write("+", Color.Orange);
              Colorful.Console.Write("] ", Color.GhostWhite);
              Colorful.Console.WriteLine("Your applications hash has been saved to integrity.txt, please refer to this when your application is ready for release!", Color.GhostWhite);
              Thread.Sleep(2000);
            }
            else
            {
              if (ApplicationSettings.Version != OnProgramStart.Version)
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("!", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("Update " + ApplicationSettings.Version + " available, redirecting to update!", Color.GhostWhite);
                Thread.Sleep(2000);
                Process.Start(ApplicationSettings.Update_Link);
                Environment.Exit(0);
              }
              if (strArray2[12] == "Enabled" && ApplicationSettings.Hash != Security.Integrity(Process.GetCurrentProcess().MainModule.FileName))
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("404", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("File has been tampered with, couldn't verify integrity!", Color.GhostWhite);
                Thread.Sleep(2000);
                Environment.Exit(0);
              }
            }
            if (!ApplicationSettings.Status)
            {
              Colorful.Console.Write(" [", Color.GhostWhite);
              Colorful.Console.Write("404", Color.Orange);
              Colorful.Console.Write("] ", Color.GhostWhite);
              Colorful.Console.WriteLine("Looks like this application is disabled, please try again later!", Color.GhostWhite);
              Thread.Sleep(2000);
              Environment.Exit(0);
            }
          }
          Security.End();
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Environment.Exit(0);
        }
      }
    }
  }
}
