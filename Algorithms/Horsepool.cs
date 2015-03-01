using System.Collections.Generic;

namespace Algorithms
{
	public class Horsepool
	{
		public int IndexOf(string input, string searchTerm)
		{
			var shiftTable = CreateShiftTable(searchTerm, input);

			int i = searchTerm.Length - 1;
			while (i <= input.Length - 1)
			{
				int k = 0;
				while (k <= searchTerm.Length - 1 && searchTerm[searchTerm.Length - 1 - k] == input[i - k])
				{
					k++;
				}

				if (k == searchTerm.Length)
				{
					return i - searchTerm.Length + 1;
				}

				i = i + shiftTable[input[i]];
			}
			return -1;
		}

		private static IDictionary<char, int> CreateShiftTable(string input, string searchTerm)
		{
			var shiftTable = new Dictionary<char, int>();

			foreach (char t in searchTerm)
			{
				if (shiftTable.ContainsKey(t))
				{
					continue;
				}

				if (!input.Contains(t.ToString()))
				{
					shiftTable.Add(t, input.Length);
				}
				else
				{
					for (int j = input.Length - 1; j >= 0; j--)
					{
						if (input[j] == t)
						{
							shiftTable.Add(t, input.Length - j - 1);
							break;
						}
					}
				}
			}

			return shiftTable;
		}
	}
}