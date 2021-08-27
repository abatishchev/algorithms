using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class PrimeNumbers
	{
		public ICollection<int> GetPrimeNumbers(int max)
		{
			var primes = new List<int> { 2 };

			int i = 3;
			while (primes.Count < max)
			{
				var sqrt = (int)Math.Sqrt(i);

				bool isPrime = true;
				for (int j = 0; primes[j] <= sqrt; j++)
				{
					if (i % primes[j] == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					primes.Add(i);
				}

				i += 2;
			}

			return primes;
		}
	}
}