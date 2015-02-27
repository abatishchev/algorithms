namespace Algorithms
{
	public interface IQueue<T>
	{
		bool Enqueue(T item);

		T Dequeue();
	}
}