// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Menu
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using AuthGG;
using EvolutionAIO.Checkers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EvolutionAIO
{
  internal class Menu
  {
    public static List<Func<string[], string, bool>> pickedModules = new List<Func<string[], string, bool>>();
    public static string Module = "";
    public static string options = "";
    public static int globalThreads = -1;
    public static int globalRetries = -1;
    public static string proxyProtocol = "";
    public static int hits = 0;
    public static int frees = 0;
    public static int errors = 0;
    public static int cpm = 0;
    public static int checks = 0;
    public static int twofa = 0;
    public static int retries = 0;
    public static IEnumerable<string> combos;
    public static int comboTotal = 0;
    public static IEnumerable<string> proxies;
    public static int proxiesCount = 0;
    public static int comboIndex = 0;
    public static int Modules = 0;
    public static string p1 = "";
    public static string pa = "";
    public static string datetime;
    private static Random random = new Random();

    public static void menu()
    {
      string path = "config.json";
      Config.config = File.Exists(path) ? JsonConvert.DeserializeObject<Config.configObject>(File.ReadAllText(path)) : Config.renewconfig(true);
      Logo.PrintLogo();
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("1", Color.Orange);
      Colorful.Console.WriteLine("] Modules", Color.GhostWhite);
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("2", Color.Orange);
      Colorful.Console.WriteLine("] Settings", Color.GhostWhite);
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("X", Color.Orange);
      Colorful.Console.WriteLine("] Exit", Color.GhostWhite);
      Colorful.Console.Write(" » ", Color.Orange);
      string str = Colorful.Console.ReadLine();
      if (str == "1")
      {
        Menu.p1 = Config.config.uitype;
        Menu.Checkingoptions();
      }
      else if (str == "2")
        Menu.ChooseUI();
      else if (str.ToUpper() == "X")
      {
        Colorful.Console.WriteLine("closing now (fuck u)", Color.Fuchsia);
        Thread.Sleep(1000);
        Environment.Exit(0);
      }
      else
        Menu.menu();
    }

    public static void ChooseUI()
    {
      Logo.PrintLogo();
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("1", Color.Orange);
      Colorful.Console.WriteLine("] Settings", Color.GhostWhite);
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("2", Color.Orange);
      Colorful.Console.WriteLine("] Current Settings", Color.GhostWhite);
      Colorful.Console.Write(" [", Color.GhostWhite);
      Colorful.Console.Write("X", Color.Orange);
      Colorful.Console.WriteLine("] Back", Color.GhostWhite);
      Colorful.Console.Write(" » ", Color.Orange);
      while (!Colorful.Console.KeyAvailable)
      {
        ConsoleKeyInfo consoleKeyInfo = Colorful.Console.ReadKey();
        if (consoleKeyInfo.Key == ConsoleKey.D1)
          Config.renewconfig(true);
        else if (consoleKeyInfo.Key == ConsoleKey.D2)
          Menu.currentsettings();
        else if (consoleKeyInfo.Key == ConsoleKey.X)
          Menu.menu();
        else
          Menu.ChooseUI();
      }
    }

    public static void currentsettings()
    {
      Logo.PrintLogo();
      try
      {
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("!", Color.Orange, 25);
        Program.Write("] UI Type [", Color.GhostWhite, 25);
        if (Config.config.uitype == "1")
          Menu.options = "CUI";
        else if (Config.config.uitype == "2")
          Menu.options = "LOG";
        Program.Write(Menu.options, Color.Orange, 25);
        Program.Write("]", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("!", Color.Orange, 25);
        Program.Write("] Refresh Rate [", Color.GhostWhite, 25);
        Program.Write(Config.config.refreshrate.ToString(), Color.Orange, 25);
        Program.Write("]", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("!", Color.Orange, 25);
        Program.Write("] Retries [", Color.GhostWhite, 25);
        Program.Write(Config.config.retries.ToString(), Color.Orange, 25);
        Program.Write("]", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
      }
      catch
      {
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("404", Color.Orange, 25);
        Program.Write("] Error, Press ", Color.GhostWhite, 25);
        Program.Write("[", Color.Orange, 25);
        Program.Write("ENTER", Color.GhostWhite, 25);
        Program.Write("]", Color.Orange, 25);
        Program.Write(" To Continue...", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Colorful.Console.ReadLine();
        Menu.ChooseUI();
        Environment.Exit(0);
      }
      Colorful.Console.WriteLine();
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("+", Color.Orange, 25);
      Program.Write("] Press ", Color.GhostWhite, 25);
      Program.Write("[", Color.Orange, 25);
      Program.Write("ENTER", Color.GhostWhite, 25);
      Program.Write("]", Color.Orange, 25);
      Program.Write(" To Continue...", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      Colorful.Console.ReadLine();
      Menu.ChooseUI();
    }

    public static void Checkingoptions()
    {
      Logo.PrintLogo();
      Colorful.Console.WriteLineFormatted(" EvolutionAIO {1} Checker                                                                                             ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "║", (object) "~");
      Colorful.Console.WriteLineFormatted(" {2} 1 {1} Uplay                                                                                                ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 2 {1} Crunchyroll                                                                                          ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|", (object) "├");
      Colorful.Console.WriteLineFormatted(" {2} 3 {1} Hulu                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|", (object) "└");
      Colorful.Console.WriteLineFormatted(" {2} 4 {1} Instagram                                                                                                ", Color.FromArgb((int) byte.MaxValue, 30, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 5 {1} Origin                                                                                                   ", Color.FromArgb((int) byte.MaxValue, 0, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 6 {1} NordVPN                                                                                                  ", Color.FromArgb((int) byte.MaxValue, 30, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 7 {1} Disney+                                                                                                  ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 8 {1} Spotify                                                                                                  ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 9 {1} Steam                                                                                                    ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 10 {1} Discord                                                                                                    ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 11 {1} DoorDash                                                                                                ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 12 {1} COD                                                                                                     ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 13 {1} Amazon.com                                                                                              ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 14 {1} Dominos                                                                                                 ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "║", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 15 {1} IPVanish                                                                                  [{0}] Combo Editor ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "C", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 16 {1} Frwd                                                                                          [{0}] Settings ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "S", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 17 {1} Patreon                                                                                       [{0}] Back     ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "X", (object) "~", (object) "|");
      Colorful.Console.WriteLineFormatted(" {2} 18 {1} AliExpress VM                                                                                 [{0}] Back     ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "X", (object) "~", (object) "|");
      Colorful.Console.Write(" » ", Color.Orange);
      string str = Colorful.Console.ReadLine();
      if (str == "2")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Crunchyroll.check));
        Menu.Module = "Crunchyroll";
        Menu.startChecking();
      }
      if (str == "3")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Hulu.check));
        Menu.Module = "Hulu";
        Menu.startChecking();
      }
      if (str == "4")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Instagram.check));
        Menu.Module = "Instagram";
        Menu.startChecking();
      }
      if (str == "6")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(NordVPN.check));
        Menu.Module = "NordVPN";
        Menu.startChecking();
      }
      if (str == "7")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Disney.check));
        Menu.Module = "Disney+";
        Menu.startChecking();
      }
      if (str == "10")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Discord.check));
        Menu.Module = "Discord";
        Menu.startChecking();
      }
      if (str == "11")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(DoorDash.check));
        Menu.Module = "DoorDash";
        Menu.startChecking();
      }
      if (str == "12")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(COD.check));
        Menu.Module = "COD";
        Menu.startChecking();
      }
      if (str == "13")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Amazon.check));
        Menu.Module = "Amazon";
        Menu.startChecking();
      }
      if (str == "15")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(IPVanish.check));
        Menu.Module = "IPVanish";
        Menu.startChecking();
      }
      if (str == "16")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Frwd.check));
        Menu.Module = "Frwd";
        Menu.startChecking();
      }
      if (str == "17")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(Patreon.check));
        Menu.Module = "Patreon";
        Menu.startChecking();
      }
      if (str == "18")
      {
        Menu.pickedModules.Add(new Func<string[], string, bool>(AliVM.check));
        Menu.Module = "AliExpressVM";
        Menu.startChecking();
      }
      if (str.ToUpper() == "X")
        Menu.menu();
      else
        Menu.Checkingoptions();
    }

    public static void startChecking()
    {
      while (true)
      {
        Logo.PrintLogo();
        Colorful.Console.Title = "EvolutionAIO ~ Made By mIDnight | " + Menu.Module + " ~ Setup";
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("!", Color.Orange, 25);
        Program.Write("] How Many Threads?", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Colorful.Console.Write(" » ", Color.Orange);
        try
        {
          Menu.globalThreads = int.Parse(Colorful.Console.ReadLine());
          if (0 >= Menu.globalThreads)
          {
            Program.Write(" [", Color.GhostWhite, 25);
            Program.Write("404", Color.Orange, 25);
            Program.Write("] Error, Try Again...", Color.GhostWhite, 25);
            Colorful.Console.WriteLine();
            Thread.Sleep(2500);
          }
          else if (Menu.globalThreads > 2000)
          {
            Program.Write(" [", Color.GhostWhite, 25);
            Program.Write("404", Color.Orange, 25);
            Program.Write("] Error, Try Again...", Color.GhostWhite, 25);
            Colorful.Console.WriteLine();
            Thread.Sleep(2500);
          }
          else
            break;
        }
        catch
        {
          Program.Write(" [", Color.GhostWhite, 25);
          Program.Write("404", Color.Orange, 25);
          Program.Write("] Error, Try Again...", Color.GhostWhite, 25);
          Colorful.Console.WriteLine();
          Thread.Sleep(2500);
        }
      }
      while (true)
      {
        Logo.PrintLogo();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("!", Color.Orange, 25);
        Program.Write("] Select A Proxy Type.", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("1", Color.Orange, 25);
        Program.Write("] HTTP/S", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("2", Color.Orange, 25);
        Program.Write("] SOCKS4", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        Program.Write(" [", Color.GhostWhite, 25);
        Program.Write("3", Color.Orange, 25);
        Program.Write("] SOCKS5", Color.GhostWhite, 25);
        Colorful.Console.WriteLine();
        switch (Colorful.Console.ReadKey(true).KeyChar)
        {
          case '1':
            goto label_9;
          case '2':
            goto label_10;
          case '3':
            goto label_11;
          default:
            Colorful.Console.WriteLine();
            Program.Write(" [", Color.GhostWhite, 25);
            Program.Write("404", Color.Orange, 25);
            Program.Write("] Invalid Option...", Color.GhostWhite, 25);
            Colorful.Console.WriteLine();
            Colorful.Console.WriteLine();
            Thread.Sleep(2500);
            continue;
        }
      }
label_9:
      Menu.proxyProtocol = "HTTP";
      Program.Write("\n [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] HTTP/S Selected!", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      goto label_12;
label_10:
      Menu.proxyProtocol = "SOCKS4";
      Program.Write("\n [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] SOCKS4 Selected!", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
      goto label_12;
label_11:
      Menu.proxyProtocol = "SOCKS5";
      Program.Write("\n [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] SOCKS5 Selected!", Color.GhostWhite, 25);
      Colorful.Console.WriteLine();
label_12:
      Thread.Sleep(2000);
      Logo.PrintLogo();
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] Please Load Combos...", Color.GhostWhite, 25);
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      string fileName1;
      do
      {
        openFileDialog1.Title = "Load Combos";
        openFileDialog1.DefaultExt = "txt";
        openFileDialog1.Filter = "Text Files|*.txt";
        openFileDialog1.RestoreDirectory = true;
        int num = (int) openFileDialog1.ShowDialog();
        fileName1 = openFileDialog1.FileName;
      }
      while (!File.Exists(fileName1));
      try
      {
        Menu.combos = (IEnumerable<string>) File.ReadAllLines(fileName1);
      }
      catch
      {
        Colorful.Console.Write(", Sir...");
      }
      Menu.comboTotal = Menu.combos.Count<string>();
      Program.Write("\n [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] Loaded [", Color.GhostWhite, 25);
      Program.Write(Menu.comboTotal.ToString(), Color.Orange, 25);
      Program.Write("] Lines", Color.GhostWhite, 25);
      Thread.Sleep(1500);
      Colorful.Console.WriteLine();
      Program.Write(" [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] Please Load Proxies...", Color.GhostWhite, 25);
      OpenFileDialog openFileDialog2 = new OpenFileDialog();
      string fileName2;
      do
      {
        openFileDialog2.Title = "Load Proxies";
        openFileDialog2.DefaultExt = "txt";
        openFileDialog2.Filter = "Text Files|*.txt";
        openFileDialog2.RestoreDirectory = true;
        int num = (int) openFileDialog2.ShowDialog();
        fileName2 = openFileDialog2.FileName;
      }
      while (!File.Exists(fileName2));
      try
      {
        Menu.proxies = (IEnumerable<string>) File.ReadAllLines(fileName2);
      }
      catch
      {
        Colorful.Console.Write(", Sir...");
      }
      Menu.datetime = DateTime.Now.ToString("M.d.yyyy h-m tt");
      Directory.CreateDirectory("Results/" + Menu.Module + "/" + Menu.datetime);
      Menu.proxiesCount = Menu.proxies.Count<string>();
      Program.Write("\n [", Color.GhostWhite, 25);
      Program.Write("!", Color.Orange, 25);
      Program.Write("] Loaded [", Color.GhostWhite, 25);
      Program.Write(Menu.proxiesCount.ToString(), Color.Orange, 25);
      Program.Write("] Proxies", Color.GhostWhite, 25);
      if (Menu.p1 == "2")
      {
        Logo.PrintLogo();
        Colorful.Console.WriteLine();
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("!", Color.Orange);
        Colorful.Console.WriteLine("] Configuration", Color.GhostWhite);
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write(">", Color.Orange);
        Colorful.Console.Write("] Proxies Loaded [", Color.GhostWhite);
        Colorful.Console.Write(Menu.proxiesCount.ToString(), Color.Orange);
        Colorful.Console.WriteLine("]", Color.GhostWhite);
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write(">", Color.Orange);
        Colorful.Console.Write("] Proxy Type [", Color.GhostWhite);
        Colorful.Console.Write(Menu.proxyProtocol, Color.Orange);
        Colorful.Console.WriteLine("]", Color.GhostWhite);
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write(">", Color.Orange);
        Colorful.Console.Write("] Lines Loaded [", Color.GhostWhite);
        Colorful.Console.Write(Menu.comboTotal.ToString(), Color.Orange);
        Colorful.Console.WriteLine("]", Color.GhostWhite);
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write(">", Color.Orange);
        Colorful.Console.Write("] Retries [", Color.GhostWhite);
        Colorful.Console.Write(Config.config.retries.ToString(), Color.Orange);
        Colorful.Console.WriteLine("]", Color.GhostWhite);
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write(">", Color.Orange);
        Colorful.Console.Write("] Thread Count [", Color.GhostWhite);
        Colorful.Console.Write(Menu.globalThreads.ToString(), Color.Orange);
        Colorful.Console.WriteLine("]", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Thread.Sleep(20);
      }
      Thread.Sleep(100);
      DiscordRPC.Initialize();
      for (int index = 1; index <= Menu.globalThreads; ++index)
        new Thread((ThreadStart) (() =>
        {
          Random random = new Random();
          while (Menu.comboIndex < Menu.combos.Count<string>())
          {
            int comboIndex = Menu.comboIndex;
            Interlocked.Increment(ref comboIndex);
            string[] strArray = Menu.combos.ElementAt<string>(comboIndex).Split(':');
            string str = Menu.proxies.ElementAt<string>(random.Next(Menu.proxiesCount));
            foreach (Func<string[], string, bool> func in Menu.pickedModules.Distinct<Func<string[], string, bool>>())
            {
              int num = func(strArray, str) ? 1 : 0;
            }
            ++Menu.checks;
          }
        })).Start();
      if (Menu.p1 == "1")
      {
        Menu.updateTitle();
      }
      else
      {
        if (!(Menu.p1 == "2"))
          return;
        Menu.updateTitle1();
      }
    }

    private static void updateTitle()
    {
      int checks = Menu.checks;
      while (true)
      {
        do
        {
          Menu.cpm = Menu.checks - checks;
          checks = Menu.checks;
          Colorful.Console.Clear();
          Logo.PrintLogo();
          Colorful.Console.Title = "EvolutionAIO ~ mIDnight | Module: " + Menu.Module + " | Hits - " + Menu.hits.ToString() + " | Frees - " + Menu.frees.ToString() + " | Bads - " + (Menu.checks - Menu.hits - Menu.frees).ToString() + " | Remaining - " + (Menu.comboTotal - Menu.checks).ToString() + " | Errors - " + Menu.errors.ToString() + " | Cpm - " + (Menu.cpm * 60).ToString();
          Colorful.Console.WriteLine();
          Colorful.Console.WriteLine();
          Colorful.Console.WriteLineFormatted(" [{0}] Hits ~ {1}", Color.Green, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.hits));
          Colorful.Console.WriteLineFormatted(" [{0}] 2FA ~ {1}", Color.Aquamarine, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.twofa));
          Colorful.Console.WriteLineFormatted(" [{0}] Frees ~ {1}", Color.Yellow, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.frees));
          Colorful.Console.WriteLineFormatted(" [{0}] Bad ~ {1}", Color.Red, Color.White, (object) ">", (object) string.Format("{0}", (object) (Menu.checks - Menu.hits - Menu.frees - Menu.twofa)));
          Colorful.Console.WriteLineFormatted(" [{0}] Checked ~ {1}", Color.Orange, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.checks));
          Colorful.Console.WriteLineFormatted(" [{0}] Remaining ~ {1}", Color.Orange, Color.White, (object) ">", (object) string.Format("{0}", (object) (Menu.comboTotal - Menu.checks)));
          Colorful.Console.WriteLineFormatted(" [{0}] Threads ~ {1}", Color.Goldenrod, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.globalThreads));
          Colorful.Console.WriteLineFormatted(" [{0}] Errors ~ {1}", Color.Indigo, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.errors));
          Colorful.Console.WriteLineFormatted(" [{0}] Retries ~ {1}", Color.Lime, Color.White, (object) ">", (object) string.Format("{0}", (object) Menu.retries));
          Colorful.Console.WriteLineFormatted(" [{0}] CPM ~ {1}", Color.Aquamarine, Color.White, (object) ">", (object) string.Format("{0}", (object) (Menu.cpm * 60)));
          Thread.Sleep(Config.config.refreshrate);
        }
        while (Menu.checks < Menu.comboTotal);
        Colorful.Console.Title = "EvolutionAIO ~ mIDnight | Module: " + Menu.Module + " | Hits ~ " + Menu.hits.ToString() + " | Leave A Good Review ;)";
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("!", Color.Fuchsia);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Finished Checking... Press Any Key to Exit", Color.Fuchsia);
        Colorful.Console.ReadLine();
        Environment.Exit(0);
      }
    }

    private static void updateTitle1()
    {
      int checks = Menu.checks;
      while (true)
      {
        do
        {
          Menu.cpm = checks - checks;
          checks = Menu.checks;
          Colorful.Console.Title = "EvolutionAIO ~ mIDnight | Module: " + Menu.Module + " | Hits - " + Menu.hits.ToString() + " | Frees - " + Menu.frees.ToString() + " | Bads - " + (Menu.checks - Menu.hits - Menu.frees).ToString() + " | Checked - " + Menu.checks.ToString() + "/" + Menu.comboTotal.ToString() + " | Errors - " + Menu.errors.ToString() + " | Cpm - " + (Menu.cpm * 60).ToString();
          Thread.Sleep(1000);
        }
        while (checks < Menu.comboTotal);
        Colorful.Console.Title = "EvolutionAIO ~ mIDnight | Module: " + Menu.Module + " | Hits ~ " + Menu.hits.ToString() + " | Leave A Good Review ;)";
        Colorful.Console.Write(" [", Color.GhostWhite);
        Colorful.Console.Write("!", Color.Fuchsia);
        Colorful.Console.Write("] ", Color.GhostWhite);
        Colorful.Console.WriteLine("Finished Checking... Press Any Key to Exit", Color.Fuchsia);
        Colorful.Console.ReadLine();
        Environment.Exit(0);
      }
    }

    public static string UUIDGen() => Menu.RandomString(8) + "-" + Menu.RandomString(4) + "-4" + Menu.RandomString(3) + "-" + Menu.RandomString(4) + "-" + Menu.RandomString(12);

    public static string RandomString(int length) => new string(Enumerable.Repeat<string>("abcdefhijklmnopqrstuvwxyz0123456789", length).Select<string, char>((Func<string, char>) (s => s[Menu.random.Next(s.Length)])).ToArray<char>());

    public static string RandomDigit(int length) => new string(Enumerable.Repeat<string>("0123456789", length).Select<string, char>((Func<string, char>) (s => s[Menu.random.Next(s.Length)])).ToArray<char>());

    public static string RandomChar(int length) => new string(Enumerable.Repeat<string>("abcdefhijklmnopqrstuvwxyz", length).Select<string, char>((Func<string, char>) (s => s[Menu.random.Next(s.Length)])).ToArray<char>());

    public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));

    public static string Parse(string source, string left, string right) => source.Split(new string[1]
    {
      left
    }, StringSplitOptions.None)[1].Split(new string[1]
    {
      right
    }, StringSplitOptions.None)[0];
  }
}
