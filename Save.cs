// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Save
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.IO;

namespace EvolutionAIO
{
  internal class Save
  {
    private static object resultLock = new object();

    public static void AsResult(string module, string fileName, string content)
    {
      lock (Save.resultLock)
        File.AppendAllText("Results/" + module + "/" + Menu.datetime + "/" + fileName + ".txt", content + Environment.NewLine);
    }
  }
}
