using Crypto;
using System;
using System.IO;

namespace SHA512
{
	internal class Program
	{
		static void Main(string[] args)
		{
			foreach (string arg in args)
			{
				string checksum;
				if (File.Exists(arg)) { checksum = Hash.ComputeSHA512(File.OpenRead(arg)); }
				else { checksum = Hash.ComputeSHA512(arg); }
				Console.WriteLine(checksum);
			}
		}
	}
}
