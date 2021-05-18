// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Config
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Colorful;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Threading;

namespace EvolutionAIO
{
  internal class Config
  {
    public static Config.configObject config = new Config.configObject();

    public static Config.configObject renewconfig(bool AskToSave)
    {
      Logo.PrintLogo();
      Console.Write(" [", Color.GhostWhite);
      Console.Write("?", Color.Orange);
      Console.WriteLine("] UI Type?", Color.GhostWhite);
      Console.Write(" [", Color.GhostWhite);
      Console.Write("1", Color.Orange);
      Console.WriteLine("] CUI", Color.GhostWhite);
      Console.Write(" [", Color.GhostWhite);
      Console.Write("2", Color.Orange);
      Console.WriteLine("] Log", Color.GhostWhite);
      Console.Write(" » ", Color.Orange);
      Config.config.uitype = Console.ReadLine();
      Console.WriteLine();
      Console.Write(" [", Color.GhostWhite);
      Console.Write("?", Color.Orange);
      Console.WriteLine("] Refresh Rate? *In ms* (Recommended  1000)", Color.GhostWhite);
      Console.Write(" » ", Color.Orange);
      Config.config.refreshrate = int.Parse(Console.ReadLine());
      Console.WriteLine();
      Console.Write(" [", Color.GhostWhite);
      Console.Write("?", Color.Orange);
      Console.WriteLine("] How Many Retries? (Recommended  3)", Color.GhostWhite);
      Console.Write(" » ", Color.Orange);
      Config.config.retries = int.Parse(Console.ReadLine());
      File.WriteAllText("config.json", JsonConvert.SerializeObject((object) Config.config));
      Console.WriteLine();
      Console.Write(" [", Color.GhostWhite);
      Console.Write("+", Color.Orange);
      Console.WriteLine("] Config Saved!", Color.GhostWhite);
      Thread.Sleep(300);
      Menu.ChooseUI();
      return Config.config;
    }

    public class configObject
    {
      public string uitype { get; set; }

      public int refreshrate { get; set; }

      public int retries { get; set; }
    }
  }
}
