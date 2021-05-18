// Decompiled with JetBrains decompiler
// Type: AuthGG.Program
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using EvolutionAIO;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;

namespace AuthGG
{
  internal class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      string path = Environment.CurrentDirectory + "\\details.txt";
      string currentDirectory = Environment.CurrentDirectory;
      Config.config = File.Exists(currentDirectory) ? JsonConvert.DeserializeObject<Config.configObject>(File.ReadAllText(currentDirectory)) : Config.renewconfig(true);
      System.Console.Title = "Evolution | EULA Agreement | Developed by mIDnight";
      OnProgramStart.Initialize("Haha", "u", "really", "thot");
      if (ApplicationSettings.Freemode)
      {
        Colorful.Console.WriteLine("Freemode is active, bypassing login!", Color.GhostWhite);
        Thread.Sleep(3000);
      }
      if (!ApplicationSettings.Status)
      {
        Colorful.Console.WriteLine("Application is disabled!", Color.GhostWhite);
        Thread.Sleep(3000);
        Process.GetCurrentProcess().Kill();
      }
      Colorful.Console.WriteLine("Please read this, this program is purely a demonstration of the use/ flaws of login APIs", Color.GhostWhite);
      Colorful.Console.WriteLine("Use this solely for educational purposes, credential stuffing is forbidden !", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("The author of this tool can't be held responsible for any misuse of this program.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("     End - User License Agreement(EULA) of Evolution", Color.GhostWhite);
      Colorful.Console.WriteLine("             ", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("     This End - User License Agreement(\"EULA\") is a legal agreement between you and Evolution", Color.GhostWhite);
      Colorful.Console.WriteLine("             ", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("     This EULA agreement governs your acquisition and use of our Evolution software(\"Software\") directly from Evolution or indirectly through a Evolution authorized reseller or distributor(a \"Reseller\").", Color.GhostWhite);
      Colorful.Console.WriteLine("             ", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine(" Please read this EULA agreement carefully before clicking Agree.It provides a license to use the Evolution software and contains warranty information and liability disclaimers.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine(" By clicking \"Accept\" or installing and / or using the Evolution software, you are confirming your acceptance of the Software and agreeing to become bound by the terms of this EULA agreement.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("If you are entering into this EULA agreement on behalf of a company or other legal entity, you represent that you have the authority to bind such entity and its affiliates to these terms and conditions.If you do not have such authority or if you do not agree with the terms and conditions of this EULA agreement, do not install or use the Software, and you must not accept this EULA agreement.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("This EULA agreement shall apply only to the Software supplied by Evolution herewith regardless of whether other software is referred to or described herein. The terms also apply to any Evolution updates, supplements, Internet-based services, and support services for the Software, unless other terms accompany those items on delivery.If so, those terms apply.License Grant", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("Evolution hereby grants you a personal, non - transferable, non - exclusive licence to use the Evolution software on your devices in accordance with the terms of this EULA agreement.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("You are permitted to load the Evolution software(for example a PC, laptop, mobile or tablet) under your control.You are responsible for ensuring your device meets the minimum requirements of the Evolution software.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("  You are not permitted to:", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("Edit, alter, modify, adapt, translate or otherwise change the whole or any part of the Software nor permit the whole or any part of the Software to be combined with or become incorporated in any other software, nor decompile, disassemble or reverse engineer the Software or attempt to do any such things", Color.GhostWhite);
      Colorful.Console.WriteLine("Reproduce, copy, distribute, resell or otherwise use the Software for any commercial purpose", Color.GhostWhite);
      Colorful.Console.WriteLine("Allow any third party to use the Software on behalf of or for the benefit of any third party", Color.GhostWhite);
      Colorful.Console.WriteLine("Use the Software in any way which breaches any applicable local, national or international law", Color.GhostWhite);
      Colorful.Console.WriteLine("use the Software for any purpose that Evolution considers is a breach of this EULA agreement", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("This software is for educational purposes only and shall never be used for any illegal activity(such as credential stuffing.)", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("Intellectual Property and Ownership", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("Evolution shall at all times retain ownership of the Software as originally downloaded by you and all subsequent downloads of the Software by you.The Software(and the copyright, and other intellectual property rights of whatever nature in the Software, including any modifications made thereto) are and shall remain the property of Evolution.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("Evolution reserves the right to grant licences to use the Software to third parties.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("    Termination", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("This EULA agreement is effective from the date you first use the Software and shall continue until terminated. You may terminate it at any time upon written notice to Evolution.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon such termination, the licenses granted by this EULA agreement will immediately terminate and you agree to stop all access and use of the Software.The provisions that by their nature continue and survive will survive any termination of this EULA agreement.", Color.GhostWhite);
      Colorful.Console.WriteLine("Governing Law", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("This EULA agreement, and any dispute arising out of or in connection with this EULA agreement, shall be governed by and construed in accordance with the laws of france.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("    Change", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("This EULA is subject to change at any time, to continue using Evolution you will need to agree on each versions of the EULA.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("THIS SOFTWARE IS PROVIDED \"AS IS\" AND ANY EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)", Color.GhostWhite);
      Colorful.Console.WriteLine("HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("BY CLICKING OKAY YOU AGREE TO RESPECT THESE RULES.", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("EMAIL ACCESS PARSER IS RESTRICTED TO YOUR OWN ACCOUNT, SPAMMING MAIL APIs WITH CRACKED ACCOUNTS IS OBVIOUSLY FORBIDDEN", Color.GhostWhite);
      Colorful.Console.WriteLine();
      Colorful.Console.WriteLine("By pressing[Enter] you agree not to use this program for the reasons specified earlier.", Color.GhostWhite);
      Colorful.Console.ReadKey();
      System.Console.Title = "EvolutionAIO ~ By mIDnight";
      Logo.PrintLogo();
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("1", Color.Orange, 25);
      Program.Write("] Login", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("2", Color.Orange, 25);
      Program.Write("] Register", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      Colorful.Console.Write(" » ", Color.Orange);
      ConsoleKeyInfo consoleKeyInfo = Colorful.Console.ReadKey();
      if (consoleKeyInfo.KeyChar == '2')
      {
        if (!ApplicationSettings.Register)
        {
          Colorful.Console.Write(" [", Color.GhostWhite);
          Colorful.Console.Write("404", Color.Orange);
          Colorful.Console.Write("] ", Color.GhostWhite);
          Colorful.Console.WriteLine("Register is not enabled, please try again later!", Color.GhostWhite);
          Thread.Sleep(3000);
          Process.GetCurrentProcess().Kill();
        }
        else
        {
          Colorful.Console.Clear();
          Logo.PrintLogo();
          Colorful.Console.WriteLine();
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("?", Color.Orange, 25);
          Program.Write("] Username", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Colorful.Console.Write(" » ", Color.Orange);
          string username = Colorful.Console.ReadLine();
          string str1 = Program.ReadPassword();
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("?", Color.Orange, 25);
          Program.Write("] Email", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Colorful.Console.Write(" » ", Color.Orange);
          string str2 = Colorful.Console.ReadLine();
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("?", Color.Orange, 25);
          Program.Write("] License", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Colorful.Console.Write(" » ", Color.Orange);
          string str3 = Colorful.Console.ReadLine();
          string password = str1;
          string email = str2;
          string license = str3;
          if (!API.Register(username, password, email, license))
            return;
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("!", Color.Orange, 25);
          Program.Write("] You Have Successfully Registered!", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("!", Color.Orange, 25);
          Program.Write("] Redirecting To Main...", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Thread.Sleep(750);
          Program.Main(args);
        }
      }
      else if (consoleKeyInfo.KeyChar == '1')
      {
        if (!ApplicationSettings.Login)
        {
          Colorful.Console.Write(" [", Color.GhostWhite);
          Colorful.Console.Write("404", Color.Orange);
          Colorful.Console.Write("] ", Color.GhostWhite);
          Colorful.Console.WriteLine("Login is not enabled, please try again later!", Color.GhostWhite);
          Thread.Sleep(3000);
          Environment.Exit(0);
        }
        else
        {
          if (File.Exists(path))
          {
            Colorful.Console.Clear();
            Logo.PrintLogo();
            string[] strArray = File.ReadAllText(path).Split(':');
            Program.Write(" [", Color.GhostWhite, 20);
            Program.Write("!", Color.Orange, 20);
            string username = strArray[0];
            Program.Write("] Trying To Authenticate " + username + " With Our Database!", Color.GhostWhite, 20);
            Colorful.Console.WriteLine();
            string password = strArray[1].Replace("\r\n", "");
            if (API.Login(username, password))
            {
              Colorful.Console.WriteLine();
              Program.Write(" [", Color.GhostWhite, 20);
              Program.Write("!", Color.Orange, 20);
              Program.Write("] Welcome Back " + username + "!", Color.GhostWhite, 20);
              Thread.Sleep(1000);
              TaskCheck.CheckTasks();
            }
            Colorful.Console.Read();
            Environment.Exit(0);
          }
          Colorful.Console.Clear();
          Logo.PrintLogo();
          Colorful.Console.WriteLine();
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("?", Color.Orange, 25);
          Program.Write("] Username", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Colorful.Console.Write(" » ", Color.Orange);
          string username1 = Colorful.Console.ReadLine();
          string password1 = Program.ReadPassword();
          if (API.Login(username1, password1))
          {
            using (StreamWriter text = File.CreateText(path))
              text.WriteLine(username1 + ":" + password1);
            Program.Write(" [", Color.GhostWhite, 25);
            Program.Write("!", Color.Orange, 25);
            Program.Write("] You have successfully logged in!", Color.GhostWhite, 25);
            Colorful.Console.WriteLine();
            Thread.Sleep(1000);
            TaskCheck.CheckTasks();
          }
          Environment.Exit(0);
        }
      }
      else
      {
        Logo.PrintLogo();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("404", Color.Orange, 25);
        Program.Write("] Invalid Answer", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Thread.Sleep(2000);
        Program.Main(args);
      }
    }

    public static void Write(string m, Color c, int t)
    {
      foreach (char ch in m)
      {
        Colorful.Console.Write(ch, c);
        Thread.Sleep(t);
      }
    }

    public static string ReadPassword()
    {
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("?", Color.Orange, 25);
      Program.Write("] Password", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      Colorful.Console.Write(" » ", Color.Orange);
      string str = "";
      for (ConsoleKeyInfo consoleKeyInfo = Colorful.Console.ReadKey(true); consoleKeyInfo.Key != ConsoleKey.Enter; consoleKeyInfo = Colorful.Console.ReadKey(true))
      {
        if (consoleKeyInfo.Key != ConsoleKey.Backspace)
        {
          Colorful.Console.Write("*");
          str += consoleKeyInfo.KeyChar.ToString();
        }
        else if (consoleKeyInfo.Key == ConsoleKey.Backspace && !string.IsNullOrEmpty(str))
        {
          str = str.Substring(0, str.Length - 1);
          int cursorLeft = Colorful.Console.CursorLeft;
          Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
          Colorful.Console.Write(" ");
          Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
        }
      }
      Colorful.Console.WriteLine();
      return str;
    }
  }
}
