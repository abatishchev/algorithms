using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public class MultiByteChar
	{
		public int[][] Data { get; private set; }

		public MultiByteChar(IEnumerable<int[]> data)
		{
			Data = data.ToArray();
		}

		public override string ToString()
		{
			return String.Join("    ", Data.Select(b => String.Join(" ", b)));
		}
	}

	public class MultiByteCharString
	{
		public static MultiByteChar[] Do(string input)
		{
			int[] stream = ParseToStream(input);
			int[][] octets = SplitToOctets(stream).ToArray();
			MultiByteChar[] chars = GroupOctetByChar(octets).ToArray();
			MultiByteChar[] reversed = Reverse(chars).ToArray();
			return reversed;
		}

		private static IEnumerable<MultiByteChar> Reverse(MultiByteChar[] chars)
		{
			return chars.Reverse();
		}

		private static IEnumerable<MultiByteChar> GroupOctetByChar(int[][] octets)
		{
			var buffer = new List<int[]>();
			foreach (var octet in octets)
			{
				if (octet[0] == 1)
				{
					if (buffer.Any())
					{
						yield return CreateByte(buffer);
						buffer.Clear();
					}
				}

				buffer.Add(octet);
			}
			yield return CreateByte(buffer);
		}

		private static MultiByteChar CreateByte(List<int[]> buffer)
		{
			return new MultiByteChar(buffer);
		}

		private static IEnumerable<int[]> SplitToOctets(int[] stream)
		{
			int i = 0;
			while (true)
			{
				var octet = stream.Skip(i++ * 8).Take(8).ToArray();
				if (octet.Any())
					yield return octet;
				else
					yield break;
			}
		}

		private static int[] ParseToStream(string input)
		{
			return input.ToCharArray()
						.Where(c => c != ' ')
						.Select(c => c.ToString())
						.Select(c => Int32.Parse(c))
						.ToArray();
		}
	}
}