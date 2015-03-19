using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
	[DebuggerDisplay("Value={Value}")]
	public class LinkedNode<T>
	{
		public LinkedNode(T value)
		{
			Value = value;
		}

		public T Value { get; private set; }

		public LinkedNode<T> Next { get; set; }

		public override bool Equals(object obj)
		{
			return Equals(this, obj as LinkedNode<T>);
		}

		private static bool Equals(LinkedNode<T> a, LinkedNode<T> b)
		{
			return !ReferenceEquals(a, null) && !ReferenceEquals(b, null) && a.Value.Equals(b.Value);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public static bool operator ==(LinkedNode<T> a, LinkedNode<T> b)
		{
			if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
				return true;
			if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
				return false;

			return a.Value.Equals(b.Value);
		}

		public static bool operator !=(LinkedNode<T> a, LinkedNode<T> b)
		{
			if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
				return false;
			if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
				return true;

			return !a.Value.Equals(b.Value);
		}

		public override string ToString()
		{
			return ToString("->");
		}

		public string ToString(string sep)
		{
			return String.Join(sep, GetValues(this));
		}

		private static IEnumerable<object> GetValues(LinkedNode<T> node)
		{
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}

		public LinkedNode<T> Clone()
		{
			return new LinkedNode<T>(Value) { Next = Next };
		}
	}

	[DebuggerDisplay("{ToString()}")]
	public class LinkedNode
	{
		public LinkedNode(object value)
		{
			Value = value.ToString();
		}

		public object Value;

		public LinkedNode Next;

		public override string ToString()
		{
			return ToString(true, "->");
		}

		public string ToString(bool safe, string sep)
		{
			return safe ?
				(Value ?? new object()).ToString() :
				String.Join(sep, GetValues(this));
		}

		private static IEnumerable<object> GetValues(LinkedNode node)
		{
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}
	}
}