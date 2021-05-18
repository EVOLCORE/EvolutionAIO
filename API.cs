// Decompiled with JetBrains decompiler
// Type: AuthGG.API
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;

namespace AuthGG
{
  internal class API
  {
    public static void Log(string username, string action)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Please initialize your application first!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(action))
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Missing log information!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            [nameof (username)] = Encryption.APIService(username),
            ["pcuser"] = Encryption.APIService(Environment.UserName),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["data"] = Encryption.APIService(action),
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("log")
          }))).Split("|".ToCharArray());
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

    public static bool AIO(string AIO) => API.AIOLogin(AIO) || API.AIORegister(AIO);

    public static bool AIOLogin(string AIO)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Please initialize your application first!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(AIO))
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Missing user login information!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["username"] = Encryption.APIService(AIO),
            ["password"] = Encryption.APIService(AIO),
            ["hwid"] = Encryption.APIService(Constants.HWID()),
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("login")
          }))).Split("|".ToCharArray());
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Security error has been triggered!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
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
          string str1 = strArray2[2];
          if (!(str1 == "success"))
          {
            if (!(str1 == "invalid_details"))
            {
              if (!(str1 == "time_expired"))
              {
                if (!(str1 == "hwid_updated"))
                {
                  if (str1 == "invalid_hwid")
                  {
                    Colorful.Console.Write(" [", Color.GhostWhite);
                    Colorful.Console.Write("404", Color.Orange);
                    Colorful.Console.Write("] ", Color.GhostWhite);
                    Colorful.Console.WriteLine("This user is binded to another computer, please contact support!", Color.GhostWhite);
                    Thread.Sleep(2000);
                    Security.End();
                    Environment.Exit(0);
                    return false;
                  }
                }
                else
                {
                  Colorful.Console.Write(" [", Color.GhostWhite);
                  Colorful.Console.Write("!", Color.Orange);
                  Colorful.Console.Write("] ", Color.GhostWhite);
                  Colorful.Console.WriteLine("New machine has been binded, re-open the application!", Color.GhostWhite);
                  Thread.Sleep(2000);
                  Security.End();
                  Environment.Exit(0);
                  return false;
                }
              }
              else
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("-", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("Your subscription has expired!", Color.GhostWhite);
                Thread.Sleep(2000);
                Security.End();
                Environment.Exit(0);
                return false;
              }
            }
            else
            {
              Security.End();
              return false;
            }
          }
          else
          {
            Security.End();
            User.ID = strArray2[3];
            User.Username = strArray2[4];
            User.Password = strArray2[5];
            User.Email = strArray2[6];
            User.HWID = strArray2[7];
            User.UserVariable = strArray2[8];
            User.Rank = strArray2[9];
            User.IP = strArray2[10];
            User.Expiry = strArray2[11];
            User.LastLogin = strArray2[12];
            User.RegisterDate = strArray2[13];
            string str2 = strArray2[14];
            char[] chArray1 = new char[1]{ '~' };
            foreach (string str3 in str2.Split(chArray1))
            {
              char[] chArray2 = new char[1]{ '^' };
              string[] strArray3 = str3.Split(chArray2);
              try
              {
                App.Variables.Add(strArray3[0], strArray3[1]);
              }
              catch
              {
              }
            }
            return true;
          }
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Security.End();
          Environment.Exit(0);
        }
        return false;
      }
    }

    public static bool AIORegister(string AIO)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Please initialize your application first!", Color.GhostWhite);
        Thread.Sleep(2000);
        Security.End();
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(AIO))
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("-", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Invalid registrar information!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("register"),
            ["username"] = Encryption.APIService(AIO),
            ["password"] = Encryption.APIService(AIO),
            ["email"] = Encryption.APIService(AIO),
            ["license"] = Encryption.APIService(AIO),
            ["hwid"] = Encryption.APIService(Constants.HWID())
          }))).Split("|".ToCharArray());
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Security error has been triggered!", Color.GhostWhite);
            Thread.Sleep(2000);
            Security.End();
            Environment.Exit(0);
          }
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
          Security.End();
          string str = strArray2[2];
          if (str == "success")
            return true;
          if (str == "error")
            return false;
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Environment.Exit(0);
        }
        return false;
      }
    }

    public static bool Login(string username, string password)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Please initialize your application first!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
      {
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("404", Color.Orange);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Missing user login information!", Color.GhostWhite);
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            [nameof (username)] = Encryption.APIService(username),
            [nameof (password)] = Encryption.APIService(password),
            ["hwid"] = Encryption.APIService(Constants.HWID()),
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("login")
          }))).Split("|".ToCharArray());
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.Write(" [", Color.GhostWhite);
            Colorful.Console.Write("404", Color.Orange);
            Colorful.Console.Write("] ", Color.GhostWhite);
            Colorful.Console.WriteLine("Security error has been triggered!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
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
          string str1 = strArray2[2];
          if (!(str1 == "success"))
          {
            if (!(str1 == "invalid_details"))
            {
              if (!(str1 == "time_expired"))
              {
                if (!(str1 == "hwid_updated"))
                {
                  if (str1 == "invalid_hwid")
                  {
                    Colorful.Console.Write(" [", Color.GhostWhite);
                    Colorful.Console.Write("404", Color.Orange);
                    Colorful.Console.Write("] ", Color.GhostWhite);
                    Colorful.Console.WriteLine("This user is binded to another computer, please contact support!", Color.GhostWhite);
                    Thread.Sleep(2000);
                    Security.End();
                    Environment.Exit(0);
                    return false;
                  }
                }
                else
                {
                  Colorful.Console.Write(" [", Color.GhostWhite);
                  Colorful.Console.Write("!", Color.Orange);
                  Colorful.Console.Write("] ", Color.GhostWhite);
                  Colorful.Console.WriteLine("New machine has been binded, re-open the application!", Color.GhostWhite);
                  Thread.Sleep(2000);
                  Security.End();
                  Environment.Exit(0);
                  return false;
                }
              }
              else
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("-", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("Your subscription has expired!", Color.GhostWhite);
                Thread.Sleep(2000);
                Security.End();
                Environment.Exit(0);
                return false;
              }
            }
            else
            {
              Colorful.Console.Write(" [", Color.GhostWhite);
              Colorful.Console.Write("-", Color.Orange);
              Colorful.Console.Write("] ", Color.GhostWhite);
              Colorful.Console.WriteLine("Sorry, your username/password does not match!", Color.GhostWhite);
              Thread.Sleep(2000);
              Security.End();
              Environment.Exit(0);
              return false;
            }
          }
          else
          {
            User.ID = strArray2[3];
            User.Username = strArray2[4];
            User.Password = strArray2[5];
            User.Email = strArray2[6];
            User.HWID = strArray2[7];
            User.UserVariable = strArray2[8];
            User.Rank = strArray2[9];
            User.IP = strArray2[10];
            User.Expiry = strArray2[11];
            User.LastLogin = strArray2[12];
            User.RegisterDate = strArray2[13];
            string str2 = strArray2[14];
            char[] chArray1 = new char[1]{ '~' };
            foreach (string str3 in str2.Split(chArray1))
            {
              char[] chArray2 = new char[1]{ '^' };
              string[] strArray3 = str3.Split(chArray2);
              try
              {
                App.Variables.Add(strArray3[0], strArray3[1]);
              }
              catch
              {
              }
            }
            Security.End();
            return true;
          }
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Security.End();
          Environment.Exit(0);
        }
        return false;
      }
    }

    public static bool Register(string username, string password, string email, string license)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.WriteLine("Please initialize your application first!");
        Thread.Sleep(2000);
        Security.End();
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(license)))
      {
        Colorful.Console.WriteLine("Invalid registrar information!");
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("register"),
            [nameof (username)] = Encryption.APIService(username),
            [nameof (password)] = Encryption.APIService(password),
            [nameof (email)] = Encryption.APIService(email),
            [nameof (license)] = Encryption.APIService(license),
            ["hwid"] = Encryption.APIService(Constants.HWID())
          }))).Split("|".ToCharArray());
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.WriteLine("Security error has been triggered!");
            Thread.Sleep(2000);
            Security.End();
            Environment.Exit(0);
          }
          if (Security.MaliciousCheck(strArray2[1]))
          {
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          if (Constants.Breached)
          {
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          string str = strArray2[2];
          if (!(str == "success"))
          {
            if (!(str == "invalid_license"))
            {
              if (!(str == "email_used"))
              {
                if (str == "invalid_username")
                {
                  Colorful.Console.Write(" [", Color.GhostWhite);
                  Colorful.Console.Write("-", Color.Orange);
                  Colorful.Console.Write("] ", Color.GhostWhite);
                  Colorful.Console.WriteLine("You entered an invalid/used username!", Color.GhostWhite);
                  Thread.Sleep(2000);
                  Security.End();
                  Environment.Exit(0);
                  return false;
                }
              }
              else
              {
                Colorful.Console.Write(" [", Color.GhostWhite);
                Colorful.Console.Write("-", Color.Orange);
                Colorful.Console.Write("] ", Color.GhostWhite);
                Colorful.Console.WriteLine("Email has already been used!", Color.GhostWhite);
                Thread.Sleep(2000);
                Security.End();
                Environment.Exit(0);
                return false;
              }
            }
            else
            {
              Colorful.Console.Write(" [", Color.GhostWhite);
              Colorful.Console.Write("-", Color.Orange);
              Colorful.Console.Write("] ", Color.GhostWhite);
              Colorful.Console.WriteLine("License does not exist!", Color.GhostWhite);
              Thread.Sleep(2000);
              Security.End();
              Environment.Exit(0);
              return false;
            }
          }
          else
          {
            Security.End();
            return true;
          }
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Environment.Exit(0);
        }
        return false;
      }
    }

    public static bool ExtendSubscription(string username, string password, string license)
    {
      if (!Constants.Initialized)
      {
        Colorful.Console.WriteLine("Please initialize your application first!");
        Thread.Sleep(2000);
        Security.End();
        Environment.Exit(0);
      }
      if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(license))
      {
        Colorful.Console.WriteLine("Invalid registrar information!");
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      string[] strArray1 = new string[0];
      using (WebClient webClient = new WebClient())
      {
        try
        {
          Security.Start();
          webClient.Proxy = (IWebProxy) null;
          string[] strArray2 = Encryption.DecryptService(Encoding.Default.GetString(webClient.UploadValues(Constants.ApiUrl, new NameValueCollection()
          {
            ["token"] = Encryption.EncryptService(Constants.Token),
            ["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString()),
            ["aid"] = Encryption.APIService(OnProgramStart.AID),
            ["session_id"] = Constants.IV,
            ["api_id"] = Constants.APIENCRYPTSALT,
            ["api_key"] = Constants.APIENCRYPTKEY,
            ["session_key"] = Constants.Key,
            ["secret"] = Encryption.APIService(OnProgramStart.Secret),
            ["type"] = Encryption.APIService("extend"),
            [nameof (username)] = Encryption.APIService(username),
            [nameof (password)] = Encryption.APIService(password),
            [nameof (license)] = Encryption.APIService(license)
          }))).Split("|".ToCharArray());
          if (strArray2[0] != Constants.Token)
          {
            Colorful.Console.WriteLine("Security error has been triggered!");
            Thread.Sleep(2000);
            Security.End();
            Environment.Exit(0);
          }
          if (Security.MaliciousCheck(strArray2[1]))
          {
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          if (Constants.Breached)
          {
            Colorful.Console.WriteLine("Possible malicous activity detected!", Color.GhostWhite);
            Thread.Sleep(2000);
            Environment.Exit(0);
          }
          string str = strArray2[2];
          if (!(str == "success"))
          {
            if (!(str == "invalid_token"))
            {
              if (str == "invalid_details")
              {
                Colorful.Console.WriteLine("Your user details are invalid!");
                Thread.Sleep(2000);
                Security.End();
                Environment.Exit(0);
                return false;
              }
            }
            else
            {
              Colorful.Console.WriteLine("Token does not exist!");
              Thread.Sleep(2000);
              Security.End();
              Environment.Exit(0);
              return false;
            }
          }
          else
          {
            Security.End();
            return true;
          }
        }
        catch (Exception ex)
        {
          Colorful.Console.WriteLine(ex.Message);
          Thread.Sleep(2000);
          Environment.Exit(0);
        }
        return false;
      }
    }
  }
}
