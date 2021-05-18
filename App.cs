// Decompiled with JetBrains decompiler
// Type: AuthGG.App
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using Colorful;
using System.Collections.Generic;
using System.Drawing;

namespace AuthGG
{
  internal class App
  {
    public static string Error = (string) null;
    public static Dictionary<string, string> Variables = new Dictionary<string, string>();

    public static string GrabVariable(string name)
    {
      try
      {
        if (User.ID != null || User.HWID != null || (User.IP != null || !Constants.Breached))
          return App.Variables[name];
        Constants.Breached = true;
        Console.Write(" [", Color.GhostWhite);
        Console.Write("404", Color.Orange);
        Console.Write("] ", Color.GhostWhite);
        Console.WriteLine("User is not logged in, possible breach detected!", Color.GhostWhite);
        return "";
      }
      catch
      {
        return "N/A";
      }
    }
  }
}
