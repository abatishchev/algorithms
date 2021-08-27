using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Algorithms
{
	public class ContinuousSeq
	{
		public int[] GetContinuousSeq(IEnumerable<int[]> seq)
		{
			int[] output = null;
			int max = 0;

			foreach (var s in seq)
			{
				if (IsSeq(s))
				{
					int size = GetSize(s);
					if (max < size)
					{
						max = size;
						output = s;
					}
				}
			}

			return output;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSeq(int[] seq)
		{
			return seq[0] < seq[1];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int GetSize(int[] seq)
		{
			return seq[1] - seq[0];
		}
	}
}