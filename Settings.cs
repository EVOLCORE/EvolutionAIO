// Decompiled with JetBrains decompiler
// Type: Auth.Settings
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Security.Principal;

namespace Auth
{
  internal class Settings
  {
    public static string AID = "752216";
    public static string Secret = "riFbpH5MTfM2ywxEzWJGWRPCgheafnOwvXP";
    public static string Version = "1.0";

    public static string HWID() => WindowsIdentity.GetCurrent().User.Value;

    public static string Time() => DateTime.Now.ToString("hh:mm tt MM:dd:yyyy");
  }
}
