// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.DiscordRPC
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using DiscordRPC;

namespace EvolutionAIO
{
  internal class DiscordRPC
  {
    public static DiscordRpcClient client;

    public static void Initialize()
    {
      EvolutionAIO.DiscordRPC.client = new DiscordRpcClient("804626466893201438");
      EvolutionAIO.DiscordRPC.client.Initialize();
      DiscordRpcClient client = EvolutionAIO.DiscordRPC.client;
      RichPresence presence = new RichPresence();
      presence.Details = "Module: " + Menu.Module;
      presence.State = "https://discord.gg/tpsb2wrAXV";
      presence.Timestamps = Timestamps.Now;
      presence.Assets = new Assets()
      {
        LargeImageKey = "evo",
        LargeImageText = "EvolutionAIO v2.0"
      };
      client.SetPresence(presence);
    }
  }
}
