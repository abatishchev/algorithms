namespace Algorithms
{
	public class TrieBuilder
	{
		public GraphNode<char> Build(string[] words)
		{
			var root = new GraphNode<char>('\0');
			foreach (var word in words)
			{
				root.Add(word.ToCharArray());
			}
			return root;
		}
	}
}