using System;
using System.IO;
using System.IO.Compression;
using System.Text;

// Code from Adam: https://twitter.com/Hexacorn/status/1338617628252901377
// Decode #SUNBURST #UNC2452 strings
namespace ConsoleApp1
{
    class Program
    {
		public static string Decompress(string input)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(input)))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
					{
						deflateStream.CopyTo(memoryStream2);
					}
					result = input + "\t" + Encoding.UTF8.GetString(memoryStream2.ToArray());
				}
			}
			return result;
		}


		static void Main(string[] args)
        {
			Console.WriteLine(Decompress(args[0]));
		}
	}
}
