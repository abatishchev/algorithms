using System.Runtime.Hosting;

namespace Algorithms
{
	public enum TriangleType : byte
	{
		Scalene = 1, // неравносторонний
		Isosceles = 2, // равнобедренный
		Equilateral = 3, // равносторонний
		Error = 4
	}

	public class Triangle
	{
		public TriangleType Do(int a, int b, int c)
		{
			// error case
			if (a <= 0 || b <= 0 || c <= 0)
			{
				return TriangleType.Error;
			}

			// triangle inequality theorem
			if (a + b < c || b + c < a || a + c < b)
			{
				return TriangleType.Error;
			}

			// all sides are equal
			if (a == b && b == c)
			{
				return TriangleType.Equilateral;
			}

			// two sides are equal
			if (a == b || a == c || b == c)
			{
				return TriangleType.Isosceles;
			}

			return TriangleType.Scalene;
		}
	}
}