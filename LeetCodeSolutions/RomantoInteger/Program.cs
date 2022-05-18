using System;

namespace RomantoInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution("III");
			Solution("LVIII");
			Solution("MCMXCIV");
		}

		static void Solution(string s)
		{
			int number = 0;

			for (int i = 0; i < s.Length; i++)
			{
				switch (s[i])
				{
					case 'I':
						if (s[i + 1] == 'V)
						{
							number += 4;
							i++;
						}
						else if (s[i + 1] == 'X')
						{
							number += 9;
							i++;
						}
						else
						{
							number += 1;
						}
						break;
					case 'V':
						number += 5;
						break;
					case 'X':
						if (s[i + 1] == 'L')
						{
							number += 40;
							i++;
						}
						else if (s[i + 1] == 'C')
						{
							number += 90;
							i++;
						}
						else
						{
							number += 10;
						}
						break;
					case 'L':
						number += 50;
						break;
					case 'C':
						if (s[i + 1] == 'D')
						{
							number += 400;
							i++;
						}
						else if (s[i + 1] == 'M')
						{
							number += 900;
						}
						else
						{
							number += 100;
						}
						break;
					case 'D':
						number += 500;
						break;
					case 'M':
						number += 1000;
						break;
					default:
						break;
				}
			}

			Console.WriteLine(number);

		}
	}
}
