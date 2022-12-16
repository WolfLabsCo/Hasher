using Crypto;
using System;
using System.IO;

namespace MD5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			foreach (string arg in args)
			{
				string checksum;
				if (File.Exists(arg)) { checksum = Hash.ComputeMD5(File.OpenRead(arg)); }
				else { checksum = Hash.ComputeMD5(arg); }
				Console.WriteLine(checksum);
			}
		}
	}
}
