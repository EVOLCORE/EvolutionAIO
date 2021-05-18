// Decompiled with JetBrains decompiler
// Type: AuthGG.InfoManager
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;

namespace AuthGG
{
  internal class InfoManager
  {
    private System.Threading.Timer timer;
    private string lastGateway;

    public InfoManager() => this.lastGateway = this.GetGatewayMAC();

    public void StartListener() => this.timer = new System.Threading.Timer((TimerCallback) (_ => this.OnCallBack()), (object) null, 5000, -1);

    private void OnCallBack()
    {
      this.timer.Dispose();
      if (!(this.GetGatewayMAC() == this.lastGateway))
      {
        Constants.Breached = true;
        Colorful.Console.WriteLine("ARP Cache poisoning has been detected!");
        Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else
        this.lastGateway = this.GetGatewayMAC();
      this.timer = new System.Threading.Timer((TimerCallback) (_ => this.OnCallBack()), (object) null, 5000, -1);
    }

    public static IPAddress GetDefaultGateway() => ((IEnumerable<NetworkInterface>) NetworkInterface.GetAllNetworkInterfaces()).Where<NetworkInterface>((Func<NetworkInterface, bool>) (n => n.OperationalStatus == OperationalStatus.Up)).Where<NetworkInterface>((Func<NetworkInterface, bool>) (n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)).SelectMany<NetworkInterface, GatewayIPAddressInformation>((Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>>) (n =>
    {
      IPInterfaceProperties ipProperties = n.GetIPProperties();
      return ipProperties == null ? (IEnumerable<GatewayIPAddressInformation>) null : (IEnumerable<GatewayIPAddressInformation>) ipProperties.GatewayAddresses;
    })).Select<GatewayIPAddressInformation, IPAddress>((Func<GatewayIPAddressInformation, IPAddress>) (g => g?.Address)).Where<IPAddress>((Func<IPAddress, bool>) (a => a != null)).FirstOrDefault<IPAddress>();

    private string GetArpTable()
    {
      string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
      using (Process process = Process.Start(new ProcessStartInfo()
      {
        FileName = pathRoot + "Windows\\System32\\arp.exe",
        Arguments = "-a",
        UseShellExecute = false,
        RedirectStandardOutput = true
      }))
      {
        using (StreamReader standardOutput = process.StandardOutput)
          return standardOutput.ReadToEnd();
      }
    }

    private string GetGatewayMAC() => new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", (object) InfoManager.GetDefaultGateway().ToString())).Match(this.GetArpTable()).Groups[2].ToString();
  }
}
