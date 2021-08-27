using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
	[DebuggerDisplay("Value={Value},Nodes={Nodes.Count}")]
	public class GraphNode<T>
	{
		public GraphNode(T c)
		{
			Nodes = new List<GraphNode<T>>();

			Value = c;
		}

		public IList<GraphNode<T>> Nodes { get; set; }

		public T Value { get; set; }

		public void Add(ICollection<T> values)
		{
			if (!values.Any())
				return;

			var first = values.First();
			var node = FindNode(first) ?? Add(first);
			node.Add(values.Skip(1).ToArray());
		}

		private GraphNode<T> Add(T first)
		{
			var node = new GraphNode<T>(first);
			Nodes.Add(node);
			return node;
		}

		private GraphNode<T> FindNode(T value)
		{
			return Nodes.FirstOrDefault(n => n.Value.Equals(value));
		}
	}
}