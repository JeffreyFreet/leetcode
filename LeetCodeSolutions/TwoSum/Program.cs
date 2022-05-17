using System;
using System.Collections.Generic;

namespace TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Solution(new int[] { 2, 7, 11, 15 }, 9);
			Solution(new int[] { 3, 2, 4 }, 6);
			Solution(new int[] { 3, 3 }, 6);
		}

		static void Solution(int[] nums, int target)
		{
			Dictionary<int, int> values = new Dictionary<int, int>();
			int[] arr = new int[2];

			for (int i = 0; i < nums.Length; i++)
			{
				int pair = target - nums[i];

				if (values.ContainsKey(pair))
				{
					WriteAnswer(new int[] { values[pair], i });
					return;
				}
				else
				{
					values.TryAdd(nums[i], i);
				}
			}

			WriteAnswer(new int[] { -1, -1 });
		}

		static void WriteAnswer(int[] answer)
		{
			Console.WriteLine("{ " + answer[0] + "," + answer[1] + " }");

		}
	}
}