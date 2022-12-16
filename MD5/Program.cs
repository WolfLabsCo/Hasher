using Crypto;
using System;
using System.Collections.Generic;
using System.IO;

namespace MD5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool verbose = false;
			List<string> argList = new List<string>();
			for (int index = 0; index < args.Length; index++)
			{
				string arg = args[index];
				if (arg == "-v" || arg == "--verbose") { verbose = true; }
				else { argList.Add(arg); }
			}

			foreach (string arg in argList)
			{
				string checksum;
				if (File.Exists(arg)) {
					checksum = Hash.ComputeMD5(File.OpenRead(arg));
					if (verbose) { Console.Write("File: "); }
				}
				else
				{
					checksum = Hash.ComputeMD5(arg);
					if (verbose) { Console.Write("Text: "); }
				}
				Console.WriteLine(checksum);
			}
		}
	}
}
