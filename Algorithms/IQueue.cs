namespace Algorithms
{
	public interface IQueue<T>
	{
		void Enqueue(T item);

		T Dequeue();
	}
}