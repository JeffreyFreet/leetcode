using System;

namespace PalindromeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution(121);
			Solution(-121);
			Solution(10);
		}

		static void Solution(int x)
		{
			if (x < 0)
			{
				Console.WriteLine("False");
			}

			string number = x.ToString();
			string newNumber = "";

			for (int i = number.Length - 1; i >= 0; i--)
			{
				newNumber += number[i];
			}


			if (number.Equals(newNumber))
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}


}
