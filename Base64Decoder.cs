using System;
using System.IO;
using System.IO.Compression;
using System.Text;

// Not a C# developer so this is what worked for me :)
// Decode a Base64 string
namespace ConsoleApp1
{
	class Program
	{
		public static string DecodeBase64(string decodeme)
		{
			byte[] data = Convert.FromBase64String(decodeme);
			string decodedString = Encoding.UTF8.GetString(data);
			
			return decodedString;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(DecodeBase64(args[0]));
		}
	}
}
