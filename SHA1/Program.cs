using Crypto;
using System;
using System.IO;

namespace SHA1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			foreach (string arg in args)
			{
				string checksum;
				if (File.Exists(arg)) { checksum = Hash.ComputeSHA1(File.OpenRead(arg)); }
				else { checksum = Hash.ComputeSHA1(arg); }
				Console.WriteLine(checksum);
			}
		}
	}
}
