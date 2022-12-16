using Crypto;
using System;
using System.IO;

namespace SHA256
{
	internal class Program
	{
		static void Main(string[] args)
		{
			foreach (string arg in args)
			{
				string checksum;
				if (File.Exists(arg)) { checksum = Hash.ComputeSHA256(File.OpenRead(arg)); }
				else { checksum = Hash.ComputeSHA256(arg); }
				Console.WriteLine(checksum);
			}
		}
	}
}
