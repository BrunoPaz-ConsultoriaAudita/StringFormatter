using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text;

			do
			{
				Console.WriteLine("Quantidade");
				int n = int.Parse(Console.ReadLine());
				string[] elem = new string[n];
				for (int c = 0; c < n; c++)
				{
					text = Console.ReadLine().Replace(",", "");
					text = text.Replace("[", "");
					text = text.Replace("]", "");
					text = text.Replace("      ", "");
					elem[c] = text;
				}

				for (int c = 0; c < elem.Length; c++)
				{
					Console.WriteLine("\npublic string " + elem[c] + "{ get; set; }");
				}

				Console.WriteLine("senha parar");
			} while (!"1222".Equals(Console.ReadLine()));
			
		}
	}
}
