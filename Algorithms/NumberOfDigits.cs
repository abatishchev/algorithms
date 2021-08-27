namespace Algorithms
{
	public class NumberOfDigits
	{
		public int GetNumberOfDigits(int num)
		{
			int i = 0;
			do
			{
				i++;
			} while ((num /= 10) > 0);
			return i;
		}
	}
}