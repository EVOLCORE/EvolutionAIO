// Decompiled with JetBrains decompiler
// Type: EvolutionAIO.Logo
// Assembly: EvolutionAIO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFBD76CC-A7A1-4682-B132-DAECA7C9FD32
// Assembly location: C:\Users\Pc\Downloads\Evolutionv2\EvolutionAIO.exe

using System;
using System.Drawing;

namespace EvolutionAIO
{
  internal class Logo
  {
    public static void PrintLogo()
    {
      DateTime now = DateTime.Now;
      if (now.Hour == 1)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 2)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 3)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                          ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 4)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 5)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 6)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 7)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 8)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                          ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 9)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 10)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                         ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 11)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                          ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 12)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 13)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 14)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 15)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 16)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 17)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 18)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 19)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 20)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 21)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 22)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else if (now.Hour == 23)
      {
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.FromArgb((int) byte.MaxValue, 60, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.FromArgb((int) byte.MaxValue, 90, 0), Color.GhostWhite, (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.FromArgb((int) byte.MaxValue, 120, 0), Color.GhostWhite, (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.FromArgb((int) byte.MaxValue, 150, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.FromArgb((int) byte.MaxValue, 180, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.FromArgb((int) byte.MaxValue, 210, 0), Color.GhostWhite, (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.FromArgb((int) byte.MaxValue, 240, 0), Color.GhostWhite, (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
      else
      {
        if (now.Hour != 0)
          return;
        Colorful.Console.Clear();
        Colorful.Console.WriteLineFormatted("                                                                                                                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 60, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0}██{0}   ██{0} ██████{0} ██{0}     ██{0}   ██{0}████████{0}██{0} ██████{0} ███{0}   ██{0}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 90, 0), (object) "╗", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{1}{2}{2}{2}{2}{3}██{5}   ██{5}██{1}{2}{2}{2}██{0}██{5}     ██{5}   ██{5}{4}{2}{2}██{1}{2}{2}{3}██{5}██{1}{2}{2}{2}██{0}████{0}  ██{5}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 120, 0), (object) "╗", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║", (object) "║");
        Colorful.Console.WriteLineFormatted("                     █████{0}  ██{1}   ██{1}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{2}██{0} ██{1}                       ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 150, 0), (object) "╗", (object) "║", (object) "╔", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ██{2}{3}{3}{4}  {5}██{0} ██{2}{4}██{1}   ██{1}██{1}     ██{1}   ██{1}   ██{1}   ██{1}██{1}   ██{1}██{1}{5}██{0}██{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 180, 0), (object) "╗", (object) "║", (object) "╔", (object) "═", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     ███████{0} {4}████{2}{3} {4}██████{2}{3}███████{0}{4}██████{2}{3}   ██{1}   ██{1}{4}██████{2}{3}██{1} {4}████{1}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 210, 0), (object) "╗", (object) "║", (object) "╔", (object) "╝", (object) "╚", (object) "║");
        Colorful.Console.WriteLineFormatted("                     {0}{1}{1}{1}{1}{1}{1}{2}  {0}{1}{1}{1}{2}   {0}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{1}{2} {0}{1}{1}{1}{1}{1}{2}    {0}{1}{2}   {0}{1}{2} {0}{1}{1}{1}{1}{1}{2} {0}{1}{2}  {0}{1}{1}{1}{2}                        ", Color.GhostWhite, Color.FromArgb((int) byte.MaxValue, 240, 0), (object) "╚", (object) "═", (object) "╝", (object) "║");
        Colorful.Console.Write("                                             Made With ", Color.GhostWhite);
        Colorful.Console.Write("<3 ", Color.Orange);
        Colorful.Console.WriteLine("By mIDnight                                           ", Color.GhostWhite);
        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("                              Messages - \"" + Write.string_0[new Random().Next(Write.string_0.Length)] + "\"", Color.White);
        Colorful.Console.WriteLine();
      }
    }
  }
}
