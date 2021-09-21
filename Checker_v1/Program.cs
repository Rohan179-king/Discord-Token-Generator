using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Checker_v1
{
	internal static class Program
	{
		public static Random Random;

		private static Random random;

		private static Random clr;

		private static string selection;

		private static readonly Random r2;

		private static int gened;

		public static void Main()
		{

			string value = "";
			string value2 = "		 ██████╗  █████╗ ██╗███╗   ██╗   ████████╗ ██████╗  ██████╗ ██╗     ███████╗";
			string value3 = "		██╔════╝ ██╔══██╗██║████╗  ██║   ╚══██╔══╝██╔═══██╗██╔═══██╗██║     ██╔════╝";
			string value4 = "		██║  ███╗███████║██║██╔██╗ ██║█████╗██║   ██║   ██║██║   ██║██║     ███████╗";
			string value5 = "		██║   ██║██╔══██║██║██║╚██╗██║╚════╝██║   ██║   ██║██║   ██║██║     ╚════██║";
			string value6 = "		╚██████╔╝██║  ██║██║██║ ╚████║      ██║   ╚██████╔╝╚██████╔╝███████╗███████║";
			string value7 = "		 ╚═════╝ ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝      ╚═╝    ╚═════╝  ╚═════╝ ╚══════╝╚══════╝";

			Console.Title = "Discord Tokens Generator | by GainTools | Version: v0.2 | Build: 20/09/2021 ";
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("");
			Console.WriteLine(value);
			Console.WriteLine(value2);
			Console.WriteLine(value3);
			Console.WriteLine(value4);
			Console.WriteLine(value5);
			Console.WriteLine(value6);
			Console.WriteLine(value7);
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("			 This Tool has been developed by GainTools x UNDETECTED");
			Console.WriteLine("			This is a free porgram if you bought this you got scammed...");
			Console.WriteLine("					News V0.2: Added [8], Program loading removed");
			Console.WriteLine("					   Discord: https://discord.gg/5XZRQFE9qm");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Choose the format of the tokens:");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("[1] Format -> NjAzMjg1N ->.XTdL");
			Console.WriteLine("[2] Format -> NjAzNjg1M ->.XTdL");
			Console.WriteLine("[3] Format -> NTE3N ->.DPN");
			Console.WriteLine("[4] Format -> NTUyOTA ->.D2GQ");
			Console.WriteLine("[5] Format -> NTUyODk ->.D2GO");
			Console.WriteLine("[6] Format -> NjM4ODI");
			Console.WriteLine("[7] Format -> NjM4NDE");
			Console.WriteLine("[8] Format -> MjY1Mj");
			Console.WriteLine("");
			selection = Console.ReadLine();
			if (selection == "1")
			{
				Console.Clear();
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter = new StreamWriter("x" + text + "-Random-Tokens.txt"))
				{
					for (int i = 0; i < Convert.ToInt32(text); i++)
					{
						char[] array = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array2 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num = r2.Next(array.Length);
						int num2 = r2.Next(array.Length);
						int num3 = r2.Next(array.Length);
						int num4 = r2.Next(array.Length);
						int num5 = r2.Next(array.Length);
						int num6 = r2.Next(array.Length);
						int num7 = r2.Next(array.Length);
						int num8 = r2.Next(array.Length);
						int num9 = r2.Next(array.Length);
						int num10 = r2.Next(array.Length);
						int num11 = r2.Next(array.Length);
						int num12 = r2.Next(array.Length);
						int num13 = r2.Next(array.Length);
						int num14 = r2.Next(array.Length);
						int num15 = r2.Next(array.Length);
						int num16 = r2.Next(array.Length);
						int num17 = r2.Next(array.Length);
						int num18 = r2.Next(array2.Length);
						int num19 = r2.Next(array2.Length);
						int num20 = r2.Next(array2.Length);
						int num21 = r2.Next(array2.Length);
						int num22 = r2.Next(array2.Length);
						int num23 = r2.Next(array2.Length);
						int num24 = r2.Next(array2.Length);
						int num25 = r2.Next(array2.Length);
						int num26 = r2.Next(array2.Length);
						int num27 = r2.Next(array2.Length);
						int num28 = r2.Next(array2.Length);
						int num29 = r2.Next(array2.Length);
						int num30 = r2.Next(array2.Length);
						int num31 = r2.Next(array2.Length);
						int num32 = r2.Next(array2.Length);
						int num33 = r2.Next(array2.Length);
						int num34 = r2.Next(array2.Length);
						int num35 = r2.Next(array2.Length);
						int num36 = r2.Next(array2.Length);
						int num37 = r2.Next(array2.Length);
						int num38 = r2.Next(array2.Length);
						int num39 = r2.Next(array2.Length);
						int num40 = r2.Next(array2.Length);
						int num41 = r2.Next(array2.Length);
						int num42 = r2.Next(array2.Length);
						int num43 = r2.Next(array2.Length);
						int num44 = r2.Next(array2.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter.WriteLine("NjAzMjg1N" + array[num] + array[num2] + array[num3] + array[num4] + array[num5] + array[num6] + array[num7] + array[num8] + array[num9] + array[num10] + array[num11] + array[num12] + array[num13] + array[num14] + array[num15] + ".XTdL" + array[num16] + array[num17] + "." + array2[num18] + array2[num19] + array2[num20] + array2[num21] + array2[num22] + array2[num23] + array2[num24] + array2[num25] + array2[num26] + array2[num27] + array2[num28] + array2[num29] + array2[num30] + array2[num31] + array2[num32] + array2[num33] + array2[num34] + array2[num35] + array2[num36] + array2[num37] + array2[num38] + array2[num39] + array2[num40] + array2[num41] + array2[num42] + array2[num43] + array2[num44]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NjAzMjg1N" + array[num] + array[num2] + array[num3] + array[num4] + array[num5] + array[num6] + array[num7] + array[num8] + array[num9] + array[num10] + array[num11] + array[num12] + array[num13] + array[num14] + array[num15] + ".XTdL" + array[num16] + array[num17] + "." + array2[num18] + array2[num19] + array2[num20] + array2[num21] + array2[num22] + array2[num23] + array2[num24] + array2[num25] + array2[num26] + array2[num27] + array2[num28] + array2[num29] + array2[num30] + array2[num31] + array2[num32] + array2[num33] + array2[num34] + array2[num35] + array2[num36] + array2[num37] + array2[num38] + array2[num39] + array2[num40] + array2[num41] + array2[num42] + array2[num43] + array2[num44]);
					}
				}
				Console.WriteLine("Generating Success!!");
				Console.WriteLine("Saved " + gened + " Tokens to: " + "Random-Tokens" + ".txt");
			}
			else if (selection == "2")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many TimoKlop do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text2 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter2 = new StreamWriter("x" + text2 + "-Random-Tokens.txt"))
				{
					for (int j = 0; j < Convert.ToInt32(text2); j++)
					{
						char[] array3 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array4 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num45 = r2.Next(array3.Length);
						int num46 = r2.Next(array3.Length);
						int num47 = r2.Next(array3.Length);
						int num48 = r2.Next(array3.Length);
						int num49 = r2.Next(array3.Length);
						int num50 = r2.Next(array3.Length);
						int num51 = r2.Next(array3.Length);
						int num52 = r2.Next(array3.Length);
						int num53 = r2.Next(array3.Length);
						int num54 = r2.Next(array3.Length);
						int num55 = r2.Next(array3.Length);
						int num56 = r2.Next(array3.Length);
						int num57 = r2.Next(array3.Length);
						int num58 = r2.Next(array3.Length);
						int num59 = r2.Next(array3.Length);
						int num60 = r2.Next(array3.Length);
						int num61 = r2.Next(array3.Length);
						int num62 = r2.Next(array4.Length);
						int num63 = r2.Next(array4.Length);
						int num64 = r2.Next(array4.Length);
						int num65 = r2.Next(array4.Length);
						int num66 = r2.Next(array4.Length);
						int num67 = r2.Next(array4.Length);
						int num68 = r2.Next(array4.Length);
						int num69 = r2.Next(array4.Length);
						int num70 = r2.Next(array4.Length);
						int num71 = r2.Next(array4.Length);
						int num72 = r2.Next(array4.Length);
						int num73 = r2.Next(array4.Length);
						int num74 = r2.Next(array4.Length);
						int num75 = r2.Next(array4.Length);
						int num76 = r2.Next(array4.Length);
						int num77 = r2.Next(array4.Length);
						int num78 = r2.Next(array4.Length);
						int num79 = r2.Next(array4.Length);
						int num80 = r2.Next(array4.Length);
						int num81 = r2.Next(array4.Length);
						int num82 = r2.Next(array4.Length);
						int num83 = r2.Next(array4.Length);
						int num84 = r2.Next(array4.Length);
						int num85 = r2.Next(array4.Length);
						int num86 = r2.Next(array4.Length);
						int num87 = r2.Next(array4.Length);
						int num88 = r2.Next(array4.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter2.WriteLine("NjAzMjg1M" + array3[num45] + array3[num46] + array3[num47] + array3[num48] + array3[num49] + array3[num50] + array3[num51] + array3[num52] + array3[num53] + array3[num54] + array3[num55] + array3[num56] + array3[num57] + array3[num58] + array3[num59] + ".XTdL" + array3[num60] + array3[num61] + "." + array4[num62] + array4[num63] + array4[num64] + array4[num65] + array4[num66] + array4[num67] + array4[num68] + array4[num69] + array4[num70] + array4[num71] + array4[num72] + array4[num73] + array4[num74] + array4[num75] + array4[num76] + array4[num77] + array4[num78] + array4[num79] + array4[num80] + array4[num81] + array4[num82] + array4[num83] + array4[num84] + array4[num85] + array4[num86] + array4[num87] + array4[num88]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NjAzMjg1M" + array3[num45] + array3[num46] + array3[num47] + array3[num48] + array3[num49] + array3[num50] + array3[num51] + array3[num52] + array3[num53] + array3[num54] + array3[num55] + array3[num56] + array3[num57] + array3[num58] + array3[num59] + ".XTdL" + array3[num60] + array3[num61] + "." + array4[num62] + array4[num63] + array4[num64] + array4[num65] + array4[num66] + array4[num67] + array4[num68] + array4[num69] + array4[num70] + array4[num71] + array4[num72] + array4[num73] + array4[num74] + array4[num75] + array4[num76] + array4[num77] + array4[num78] + array4[num79] + array4[num80] + array4[num81] + array4[num82] + array4[num83] + array4[num84] + array4[num85] + array4[num86] + array4[num87] + array4[num88]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine("Saved " + gened + " Tokens to: " + "Random-Tokens" + ".txt");
			}
			else if (selection == "3")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text3 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter3 = new StreamWriter("x" + text3 + "-Random-Tokens.txt"))
				{
					for (int k = 0; k < Convert.ToInt32(text3); k++)
					{
						char[] array5 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array6 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num89 = r2.Next(array5.Length);
						int num90 = r2.Next(array5.Length);
						int num91 = r2.Next(array5.Length);
						int num92 = r2.Next(array5.Length);
						int num93 = r2.Next(array5.Length);
						int num94 = r2.Next(array5.Length);
						int num95 = r2.Next(array5.Length);
						int num96 = r2.Next(array5.Length);
						int num97 = r2.Next(array5.Length);
						int num98 = r2.Next(array5.Length);
						int num99 = r2.Next(array5.Length);
						int num100 = r2.Next(array5.Length);
						int num101 = r2.Next(array5.Length);
						int num102 = r2.Next(array5.Length);
						int num103 = r2.Next(array5.Length);
						int num104 = r2.Next(array5.Length);
						int num105 = r2.Next(array5.Length);
						int num106 = r2.Next(array5.Length);
						int num107 = r2.Next(array5.Length);
						int num108 = r2.Next(array5.Length);
						int num109 = r2.Next(array5.Length);
						int num110 = r2.Next(array5.Length);
						int num111 = r2.Next(array6.Length);
						int num112 = r2.Next(array6.Length);
						int num113 = r2.Next(array6.Length);
						int num114 = r2.Next(array6.Length);
						int num115 = r2.Next(array6.Length);
						int num116 = r2.Next(array6.Length);
						int num117 = r2.Next(array6.Length);
						int num118 = r2.Next(array6.Length);
						int num119 = r2.Next(array6.Length);
						int num120 = r2.Next(array6.Length);
						int num121 = r2.Next(array6.Length);
						int num122 = r2.Next(array6.Length);
						int num123 = r2.Next(array6.Length);
						int num124 = r2.Next(array6.Length);
						int num125 = r2.Next(array6.Length);
						int num126 = r2.Next(array6.Length);
						int num127 = r2.Next(array6.Length);
						int num128 = r2.Next(array6.Length);
						int num129 = r2.Next(array6.Length);
						int num130 = r2.Next(array6.Length);
						int num131 = r2.Next(array6.Length);
						int num132 = r2.Next(array6.Length);
						int num133 = r2.Next(array6.Length);
						int num134 = r2.Next(array6.Length);
						int num135 = r2.Next(array6.Length);
						int num136 = r2.Next(array6.Length);
						int num137 = r2.Next(array6.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter3.WriteLine("NTE3N" + array5[num89] + array5[num90] + array5[num91] + array5[num92] + array5[num93] + array5[num94] + array5[num95] + array5[num96] + array5[num97] + array5[num98] + array5[num99] + array5[num100] + array5[num101] + array5[num102] + array5[num103] + array5[num104] + array5[num105] + array5[num106] + array5[num107] + ".DPN" + array5[num108] + array5[num109] + array5[num110] + "." + array6[num111] + array6[num112] + array6[num113] + array6[num114] + array6[num115] + array6[num116] + array6[num117] + array6[num118] + array6[num119] + array6[num120] + array6[num121] + array6[num122] + array6[num123] + array6[num124] + array6[num125] + array6[num126] + array6[num127] + array6[num128] + array6[num129] + array6[num130] + array6[num131] + array6[num132] + array6[num133] + array6[num134] + array6[num135] + array6[num136] + array6[num137]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NTE3N" + array5[num89] + array5[num90] + array5[num91] + array5[num92] + array5[num93] + array5[num94] + array5[num95] + array5[num96] + array5[num97] + array5[num98] + array5[num99] + array5[num100] + array5[num101] + array5[num102] + array5[num103] + array5[num104] + array5[num105] + array5[num106] + array5[num107] + ".DPN" + array5[num108] + array5[num109] + array5[num110] + "." + array6[num111] + array6[num112] + array6[num113] + array6[num114] + array6[num115] + array6[num116] + array6[num117] + array6[num118] + array6[num119] + array6[num120] + array6[num121] + array6[num122] + array6[num123] + array6[num124] + array6[num125] + array6[num126] + array6[num127] + array6[num128] + array6[num129] + array6[num130] + array6[num131] + array6[num132] + array6[num133] + array6[num134] + array6[num135] + array6[num136] + array6[num137]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine("Saved " + gened + " Tokens to: " + "Random-Tokens" + ".txt");
			}
			else if (selection == "4")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text4 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter4 = new StreamWriter("x" + text4 + "-Random-Tokens.txt"))
				{
					for (int l = 0; l < Convert.ToInt32(text4); l++)
					{
						char[] array7 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array8 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num138 = r2.Next(array7.Length);
						int num139 = r2.Next(array7.Length);
						int num140 = r2.Next(array7.Length);
						int num141 = r2.Next(array7.Length);
						int num142 = r2.Next(array7.Length);
						int num143 = r2.Next(array7.Length);
						int num144 = r2.Next(array7.Length);
						int num145 = r2.Next(array7.Length);
						int num146 = r2.Next(array7.Length);
						int num147 = r2.Next(array7.Length);
						int num148 = r2.Next(array7.Length);
						int num149 = r2.Next(array7.Length);
						int num150 = r2.Next(array7.Length);
						int num151 = r2.Next(array7.Length);
						int num152 = r2.Next(array7.Length);
						int num153 = r2.Next(array7.Length);
						int num154 = r2.Next(array7.Length);
						int num155 = r2.Next(array7.Length);
						int num156 = r2.Next(array7.Length);
						int num157 = r2.Next(array8.Length);
						int num158 = r2.Next(array8.Length);
						int num159 = r2.Next(array8.Length);
						int num160 = r2.Next(array8.Length);
						int num161 = r2.Next(array8.Length);
						int num162 = r2.Next(array8.Length);
						int num163 = r2.Next(array8.Length);
						int num164 = r2.Next(array8.Length);
						int num165 = r2.Next(array8.Length);
						int num166 = r2.Next(array8.Length);
						int num167 = r2.Next(array8.Length);
						int num168 = r2.Next(array8.Length);
						int num169 = r2.Next(array8.Length);
						int num170 = r2.Next(array8.Length);
						int num171 = r2.Next(array8.Length);
						int num172 = r2.Next(array8.Length);
						int num173 = r2.Next(array8.Length);
						int num174 = r2.Next(array8.Length);
						int num175 = r2.Next(array8.Length);
						int num176 = r2.Next(array8.Length);
						int num177 = r2.Next(array8.Length);
						int num178 = r2.Next(array8.Length);
						int num179 = r2.Next(array8.Length);
						int num180 = r2.Next(array8.Length);
						int num181 = r2.Next(array8.Length);
						int num182 = r2.Next(array8.Length);
						int num183 = r2.Next(array8.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter4.WriteLine("NTUyOTA" + array7[num138] + array7[num139] + array7[num140] + array7[num141] + array7[num142] + array7[num143] + array7[num144] + array7[num145] + array7[num146] + array7[num147] + array7[num148] + array7[num149] + array7[num150] + array7[num151] + array7[num152] + array7[num153] + array7[num154] + ".D2GQ" + array7[num155] + array7[num156] + "." + array8[num157] + array8[num158] + array8[num159] + array8[num160] + array8[num161] + array8[num162] + array8[num163] + array8[num164] + array8[num165] + array8[num166] + array8[num167] + array8[num168] + array8[num169] + array8[num170] + array8[num171] + array8[num172] + array8[num173] + array8[num174] + array8[num175] + array8[num176] + array8[num177] + array8[num178] + array8[num179] + array8[num180] + array8[num181] + array8[num182] + array8[num183]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NTUyOTA" + array7[num138] + array7[num139] + array7[num140] + array7[num141] + array7[num142] + array7[num143] + array7[num144] + array7[num145] + array7[num146] + array7[num147] + array7[num148] + array7[num149] + array7[num150] + array7[num151] + array7[num152] + array7[num153] + array7[num154] + ".D2GQ" + array7[num155] + array7[num156] + "." + array8[num157] + array8[num158] + array8[num159] + array8[num160] + array8[num161] + array8[num162] + array8[num163] + array8[num164] + array8[num165] + array8[num166] + array8[num167] + array8[num168] + array8[num169] + array8[num170] + array8[num171] + array8[num172] + array8[num173] + array8[num174] + array8[num175] + array8[num176] + array8[num177] + array8[num178] + array8[num179] + array8[num180] + array8[num181] + array8[num182] + array8[num183]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine("Saved " + gened + " Tokens to: " + "Random-Tokens" + ".txt");
			}
			else if (selection == "5")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text5 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter5 = new StreamWriter("x" + text5 + "-Random-Tokens.txt"))
				{
					for (int m = 0; m < Convert.ToInt32(text5); m++)
					{
						char[] array9 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array10 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num184 = r2.Next(array9.Length);
						int num185 = r2.Next(array9.Length);
						int num186 = r2.Next(array9.Length);
						int num187 = r2.Next(array9.Length);
						int num188 = r2.Next(array9.Length);
						int num189 = r2.Next(array9.Length);
						int num190 = r2.Next(array9.Length);
						int num191 = r2.Next(array9.Length);
						int num192 = r2.Next(array9.Length);
						int num193 = r2.Next(array9.Length);
						int num194 = r2.Next(array9.Length);
						int num195 = r2.Next(array9.Length);
						int num196 = r2.Next(array9.Length);
						int num197 = r2.Next(array9.Length);
						int num198 = r2.Next(array9.Length);
						int num199 = r2.Next(array9.Length);
						int num200 = r2.Next(array9.Length);
						int num201 = r2.Next(array9.Length);
						int num202 = r2.Next(array9.Length);
						int num203 = r2.Next(array10.Length);
						int num204 = r2.Next(array10.Length);
						int num205 = r2.Next(array10.Length);
						int num206 = r2.Next(array10.Length);
						int num207 = r2.Next(array10.Length);
						int num208 = r2.Next(array10.Length);
						int num209 = r2.Next(array10.Length);
						int num210 = r2.Next(array10.Length);
						int num211 = r2.Next(array10.Length);
						int num212 = r2.Next(array10.Length);
						int num213 = r2.Next(array10.Length);
						int num214 = r2.Next(array10.Length);
						int num215 = r2.Next(array10.Length);
						int num216 = r2.Next(array10.Length);
						int num217 = r2.Next(array10.Length);
						int num218 = r2.Next(array10.Length);
						int num219 = r2.Next(array10.Length);
						int num220 = r2.Next(array10.Length);
						int num221 = r2.Next(array10.Length);
						int num222 = r2.Next(array10.Length);
						int num223 = r2.Next(array10.Length);
						int num224 = r2.Next(array10.Length);
						int num225 = r2.Next(array10.Length);
						int num226 = r2.Next(array10.Length);
						int num227 = r2.Next(array10.Length);
						int num228 = r2.Next(array10.Length);
						int num229 = r2.Next(array10.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter5.WriteLine("NTUyODk" + array9[num184] + array9[num185] + array9[num186] + array9[num187] + array9[num188] + array9[num189] + array9[num190] + array9[num191] + array9[num192] + array9[num193] + array9[num194] + array9[num195] + array9[num196] + array9[num197] + array9[num198] + array9[num199] + array9[num200] + ".D2GO" + array9[num201] + array9[num202] + "." + array10[num203] + array10[num204] + array10[num205] + array10[num206] + array10[num207] + array10[num208] + array10[num209] + array10[num210] + array10[num211] + array10[num212] + array10[num213] + array10[num214] + array10[num215] + array10[num216] + array10[num217] + array10[num218] + array10[num219] + array10[num220] + array10[num221] + array10[num222] + array10[num223] + array10[num224] + array10[num225] + array10[num226] + array10[num227] + array10[num228] + array10[num229]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NTUyODk" + array9[num184] + array9[num185] + array9[num186] + array9[num187] + array9[num188] + array9[num189] + array9[num190] + array9[num191] + array9[num192] + array9[num193] + array9[num194] + array9[num195] + array9[num196] + array9[num197] + array9[num198] + array9[num199] + array9[num200] + ".D2GO" + array9[num201] + array9[num202] + "." + array10[num203] + array10[num204] + array10[num205] + array10[num206] + array10[num207] + array10[num208] + array10[num209] + array10[num210] + array10[num211] + array10[num212] + array10[num213] + array10[num214] + array10[num215] + array10[num216] + array10[num217] + array10[num218] + array10[num219] + array10[num220] + array10[num221] + array10[num222] + array10[num223] + array10[num224] + array10[num225] + array10[num226] + array10[num227] + array10[num228] + array10[num229]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine(string.Concat("Saved ", gened.ToString(), " Tokens to: ", "x" + text5 + "-Random-Tokens.txt", ".txt"));
			}
			else if (selection == "6")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text6 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter6 = new StreamWriter("x" + text6 + "-Random-Tokens.txt"))
				{
					for (int n = 0; n < Convert.ToInt32(text6); n++)
					{
						char[] array11 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array12 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num230 = r2.Next(array11.Length);
						int num231 = r2.Next(array11.Length);
						int num232 = r2.Next(array11.Length);
						int num233 = r2.Next(array11.Length);
						int num234 = r2.Next(array11.Length);
						int num235 = r2.Next(array11.Length);
						int num236 = r2.Next(array11.Length);
						int num237 = r2.Next(array11.Length);
						int num238 = r2.Next(array11.Length);
						int num239 = r2.Next(array11.Length);
						int num240 = r2.Next(array11.Length);
						int num241 = r2.Next(array11.Length);
						int num242 = r2.Next(array11.Length);
						int num243 = r2.Next(array12.Length);
						int num244 = r2.Next(array12.Length);
						int num245 = r2.Next(array12.Length);
						int num246 = r2.Next(array12.Length);
						int num247 = r2.Next(array12.Length);
						int num248 = r2.Next(array12.Length);
						int num249 = r2.Next(array12.Length);
						int num250 = r2.Next(array12.Length);
						int num251 = r2.Next(array12.Length);
						int num252 = r2.Next(array12.Length);
						int num253 = r2.Next(array12.Length);
						int num254 = r2.Next(array12.Length);
						int num255 = r2.Next(array12.Length);
						int num256 = r2.Next(array12.Length);
						int num257 = r2.Next(array12.Length);
						int num258 = r2.Next(array12.Length);
						int num259 = r2.Next(array12.Length);
						int num260 = r2.Next(array12.Length);
						int num261 = r2.Next(array12.Length);
						int num262 = r2.Next(array12.Length);
						int num263 = r2.Next(array12.Length);
						int num264 = r2.Next(array12.Length);
						int num265 = r2.Next(array12.Length);
						int num266 = r2.Next(array12.Length);
						int num267 = r2.Next(array12.Length);
						int num268 = r2.Next(array12.Length);
						int num269 = r2.Next(array12.Length);
						int num270 = r2.Next(array12.Length);
						int num271 = r2.Next(array12.Length);
						int num272 = r2.Next(array12.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter6.WriteLine("NjM4ODI" + array11[num230] + array11[num231] + array11[num232] + array11[num233] + array11[num234] + "M" + array11[num235] + array11[num236] + array11[num237] + "ND" + array11[num238] + array11[num239] + "N" + array11[num240] + array11[num241] + array11[num242] + ".Xbi" + array12[num243] + array12[num244] + array12[num245] + "." + array12[num246] + array12[num247] + array12[num248] + array12[num249] + array12[num250] + array12[num251] + array12[num252] + array12[num253] + array12[num254] + array12[num255] + array12[num256] + array12[num257] + array12[num258] + array12[num259] + array12[num260] + array12[num261] + array12[num262] + array12[num263] + array12[num264] + array12[num265] + array12[num266] + array12[num267] + array12[num268] + array12[num269] + array12[num270] + array12[num271] + array12[num272]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NjM4ODI" + array11[num230] + array11[num231] + array11[num232] + array11[num233] + array11[num234] + "M" + array11[num235] + array11[num236] + array11[num237] + "ND" + array11[num238] + array11[num239] + "N" + array11[num240] + array11[num241] + array11[num242] + ".Xbi" + array12[num243] + array12[num244] + array12[num245] + "." + array12[num246] + array12[num247] + array12[num248] + array12[num249] + array12[num250] + array12[num251] + array12[num252] + array12[num253] + array12[num254] + array12[num255] + array12[num256] + array12[num257] + array12[num258] + array12[num259] + array12[num260] + array12[num261] + array12[num262] + array12[num263] + array12[num264] + array12[num265] + array12[num266] + array12[num267] + array12[num268] + array12[num269] + array12[num270] + array12[num271] + array12[num272]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine(string.Concat("Saved ", gened.ToString(), " Tokens to: ", "x" + text6 + "-Random-Tokens.txt", ".txt"));
				{

				}

				if (!(selection == "7"))
				{
					return;
				}
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text7 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter7 = new StreamWriter("x" + text7 + "-Random-Tokens.txt"))
				{
					for (int num273 = 0; num273 < Convert.ToInt32(text7); num273++)
					{
						char[] array13 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array14 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_".ToCharArray();
						int num274 = r2.Next(array13.Length);
						int num275 = r2.Next(array13.Length);
						int num276 = r2.Next(array13.Length);
						int num277 = r2.Next(array13.Length);
						int num278 = r2.Next(array13.Length);
						int num279 = r2.Next(array13.Length);
						int num280 = r2.Next(array13.Length);
						int num281 = r2.Next(array13.Length);
						int num282 = r2.Next(array13.Length);
						int num283 = r2.Next(array13.Length);
						int num284 = r2.Next(array13.Length);
						int num285 = r2.Next(array13.Length);
						int num286 = r2.Next(array13.Length);
						int num287 = r2.Next(array14.Length);
						int num288 = r2.Next(array14.Length);
						int num289 = r2.Next(array14.Length);
						int num290 = r2.Next(array14.Length);
						int num291 = r2.Next(array14.Length);
						int num292 = r2.Next(array14.Length);
						int num293 = r2.Next(array14.Length);
						int num294 = r2.Next(array14.Length);
						int num295 = r2.Next(array14.Length);
						int num296 = r2.Next(array14.Length);
						int num297 = r2.Next(array14.Length);
						int num298 = r2.Next(array14.Length);
						int num299 = r2.Next(array14.Length);
						int num300 = r2.Next(array14.Length);
						int num301 = r2.Next(array14.Length);
						int num302 = r2.Next(array14.Length);
						int num303 = r2.Next(array14.Length);
						int num304 = r2.Next(array14.Length);
						int num305 = r2.Next(array14.Length);
						int num306 = r2.Next(array14.Length);
						int num307 = r2.Next(array14.Length);
						int num308 = r2.Next(array14.Length);
						int num309 = r2.Next(array14.Length);
						int num310 = r2.Next(array14.Length);
						int num311 = r2.Next(array14.Length);
						int num312 = r2.Next(array14.Length);
						int num313 = r2.Next(array14.Length);
						int num314 = r2.Next(array14.Length);
						int num315 = r2.Next(array14.Length);
						int num316 = r2.Next(array14.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter7.WriteLine("NjM4NDE" + array13[num274] + array13[num275] + array13[num276] + array13[num277] + array13[num278] + "N" + array13[num279] + array13[num280] + array13[num281] + "ND" + array13[num282] + array13[num283] + "N" + array13[num284] + array13[num285] + array13[num286] + ".Xbi" + array14[num287] + array14[num288] + array14[num289] + "." + array14[num290] + array14[num291] + array14[num292] + array14[num293] + array14[num294] + array14[num295] + array14[num296] + array14[num297] + array14[num298] + array14[num299] + array14[num300] + array14[num301] + array14[num302] + array14[num303] + array14[num304] + array14[num305] + array14[num306] + array14[num307] + array14[num308] + array14[num309] + array14[num310] + array14[num311] + array14[num312] + array14[num313] + array14[num314] + array14[num315] + array14[num316]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("NjM4NDE" + array13[num274] + array13[num275] + array13[num276] + array13[num277] + array13[num278] + "N" + array13[num279] + array13[num280] + array13[num281] + "ND" + array13[num282] + array13[num283] + "N" + array13[num284] + array13[num285] + array13[num286] + ".Xbi" + array14[num287] + array14[num288] + array14[num289] + "." + array14[num290] + array14[num291] + array14[num292] + array14[num293] + array14[num294] + array14[num295] + array14[num296] + array14[num297] + array14[num298] + array14[num299] + array14[num300] + array14[num301] + array14[num302] + array14[num303] + array14[num304] + array14[num305] + array14[num306] + array14[num307] + array14[num308] + array14[num309] + array14[num310] + array14[num311] + array14[num312] + array14[num313] + array14[num314] + array14[num315] + array14[num316]);
					}
				}

				Console.WriteLine("Done Generating!");
				Console.WriteLine(string.Concat("Saved ", gened.ToString(), " Tokens to: ", "x" + text7 + "-Random-Tokens.txt", ".txt"));
			}
			else
			{
				if (!(selection == "8"))
				{
					return;
				}
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("");
				Console.WriteLine(value);
				Console.WriteLine(value2);
				Console.WriteLine(value3);
				Console.WriteLine(value4);
				Console.WriteLine(value5);
				Console.WriteLine(value6);
				Console.WriteLine(value7);
				Console.WriteLine("");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("How many tokens do You want? ");
				Console.ForegroundColor = ConsoleColor.Red;
				string text2 = Console.ReadLine();
				Console.Clear();
				using (StreamWriter streamWriter2 = new StreamWriter("x" + text2 + "-Random-Tokens.txt"))
				{
					for (int j = 0; j < Convert.ToInt32(text2); j++)
					{
						char[] array3 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						char[] array4 = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
						int num43 = r2.Next(array3.Length);
						int num44 = r2.Next(array3.Length);
						int num45 = r2.Next(array3.Length);
						int num46 = r2.Next(array3.Length);
						int num47 = r2.Next(array3.Length);
						int num48 = r2.Next(array3.Length);
						int num49 = r2.Next(array3.Length);
						int num50 = r2.Next(array3.Length);
						int num51 = r2.Next(array3.Length);
						int num52 = r2.Next(array3.Length);
						int num53 = r2.Next(array3.Length);
						int num54 = r2.Next(array3.Length);
						int num55 = r2.Next(array3.Length);
						int num56 = r2.Next(array3.Length);
						int num57 = r2.Next(array3.Length);
						int num58 = r2.Next(array3.Length);
						int num59 = r2.Next(array3.Length);
						int num60 = r2.Next(array3.Length);
						int num61 = r2.Next(array3.Length);
						int num62 = r2.Next(array4.Length);
						int num63 = r2.Next(array4.Length);
						int num64 = r2.Next(array4.Length);
						int num65 = r2.Next(array4.Length);
						int num66 = r2.Next(array4.Length);
						int num67 = r2.Next(array4.Length);
						int num68 = r2.Next(array4.Length);
						int num69 = r2.Next(array4.Length);
						int num70 = r2.Next(array4.Length);
						int num71 = r2.Next(array4.Length);
						int num72 = r2.Next(array4.Length);
						int num73 = r2.Next(array4.Length);
						int num74 = r2.Next(array4.Length);
						int num75 = r2.Next(array4.Length);
						int num76 = r2.Next(array4.Length);
						int num77 = r2.Next(array4.Length);
						int num78 = r2.Next(array4.Length);
						int num79 = r2.Next(array4.Length);
						int num80 = r2.Next(array4.Length);
						int num81 = r2.Next(array4.Length);
						int num82 = r2.Next(array4.Length);
						int num83 = r2.Next(array4.Length);
						int num84 = r2.Next(array4.Length);
						int num85 = r2.Next(array4.Length);
						int num86 = r2.Next(array4.Length);
						int num87 = r2.Next(array4.Length);
						int num88 = r2	.Next(array4.Length);
						int num89 = r2.Next(array4.Length);
						int num90 = r2.Next(array4.Length);
						gened++;
						Console.Title = string.Concat(new object[2] { "GainTools - Token Generated: ", gened });
						streamWriter2.WriteLine("MjY1Mj" + array3[num45] + array3[num46] + array3[num47] + array3[num48] + array3[num49] + array3[num50] + array3[num51] + array3[num52] + array3[num53] + array3[num54] + array3[num55] + array3[num56] + array3[num57] + array3[num58] + array3[num59] + array3[num60] + array3[num61] + array3[num62] + ".YTTu" + array3[num62] + array3[num63] + "." + array4[num64] + array4[num65] + array4[num66] + array4[num67] + array4[num68] + array4[num69] + array4[num70] + array4[num71] + array4[num72] + array4[num73] + array4[num74] + array4[num75] + array4[num76] + array4[num77] + array4[num78] + array4[num79] + array4[num80] + array4[num81] + array4[num82] + array4[num83] + array4[num84] + array4[num85] + array4[num86] + array4[num87] + array4[num88] + array4[num89] + array4[num90]);
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("MjY1Mj" + array3[num45] + array3[num46] + array3[num47] + array3[num48] + array3[num49] + array3[num50] + array3[num51] + array3[num52] + array3[num53] + array3[num54] + array3[num55] + array3[num56] + array3[num57] + array3[num58] + array3[num59] + array3[num60] + array3[num61] + array3[num62] + ".YTTu" + array3[num62] + array3[num63] + "." + array4[num64] + array4[num65] + array4[num66] + array4[num67] + array4[num68] + array4[num69] + array4[num70] + array4[num71] + array4[num72] + array4[num73] + array4[num74] + array4[num75] + array4[num76] + array4[num77] + array4[num78] + array4[num79] + array4[num80] + array4[num81] + array4[num82] + array4[num83] + array4[num84] + array4[num85] + array4[num86] + array4[num87] + array4[num88] + array4[num89] + array4[num90]);
					}
				}
				Console.WriteLine("Done Generating!");
				Console.WriteLine("Saved " + gened + " Tokens to: " + "Random-Tokens" + ".txt");
			}
		}
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat("0123456789", length)
				select s[random.Next(s.Length)]).ToArray());
		}

		static Program()
		{
			clr = new Random();
			selection = "";
			r2 = new Random();
			Random = new Random(Environment.TickCount ^ DateTime.Now.Millisecond);
			random = new Random();
		}
	}
}
