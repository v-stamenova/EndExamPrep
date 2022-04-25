using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4_DocumentTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> zodiacs = new List<string>();
			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				zodiacs.Add(Console.ReadLine());
			}

			Console.WriteLine($"Water: {((double)GetGroupCount("Water", zodiacs) / count * 100).ToString("F2")}%");
			Console.WriteLine($"Fire: {((double)GetGroupCount("Fire", zodiacs) / count * 100).ToString("F2")}%");
			Console.WriteLine($"Earth: {((double)GetGroupCount("Earth", zodiacs) / count * 100).ToString("F2")}%");
			Console.WriteLine($"Air: {((double)GetGroupCount("Air", zodiacs) / count * 100).ToString("F2")}%");
		}

		static int GetGroupCount(string name, List<string> zodiacs)
		{
			if(name == "Water")
			{
				return zodiacs.Count(x => x == "Pisces") + zodiacs.Count(x => x == "Cancer") + zodiacs.Count(x => x == "Scorpio");
			}
			else if (name == "Fire")
			{
				return zodiacs.Count(x => x == "Leo") + zodiacs.Count(x => x == "Sagittarius") + zodiacs.Count(x => x == "Aries");
			}
			else if (name == "Air")
			{
				return zodiacs.Count(x => x == "Libra") + zodiacs.Count(x => x == "Gemini") + zodiacs.Count(x => x == "Aquarius");
			}
			else
			{
				return zodiacs.Count(x => x == "Virgo") + zodiacs.Count(x => x == "Taurus") + zodiacs.Count(x => x == "Capricorn");
			}
		}
	}
}
