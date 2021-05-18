// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.TaskCheck
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EvolutionAIO
{
  internal class TaskCheck
  {
    public static int suc;

    public static void CheckTasks()
    {
      if (Process.GetProcessesByName("dotPeek").Length != 0)
      {
        int num = (int) MessageBox.Show("Close dotPeek & Restart");
        Environment.Exit(0);
      }
      else
        ++TaskCheck.suc;
      if (Process.GetProcessesByName("dnSpy").Length != 0)
      {
        int num = (int) MessageBox.Show("Close dnSpy & Restart");
        Environment.Exit(0);
      }
      else
        ++TaskCheck.suc;
      if (Process.GetProcessesByName("ILSpy").Length != 0)
      {
        int num = (int) MessageBox.Show("Close ILSpy & Restart");
        Environment.Exit(0);
      }
      else
        ++TaskCheck.suc;
      if (Process.GetProcessesByName("JustDecompile").Length != 0)
      {
        int num = (int) MessageBox.Show("Close JustDecompile & Restart");
        Environment.Exit(0);
      }
      else
        ++TaskCheck.suc;
      if (Process.GetProcessesByName("Reflector").Length != 0)
      {
        int num = (int) MessageBox.Show("Close Reflector & Restart");
        Environment.Exit(0);
      }
      else
        ++TaskCheck.suc;
      if (TaskCheck.suc != 5)
        return;
      Menu.menu();
    }
  }
}
