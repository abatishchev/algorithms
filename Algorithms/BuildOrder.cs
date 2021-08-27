using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
	public class BuildOrder
	{
		public IEnumerable<IEnumerable<Operation>> FindBuildOrder(ICollection<Operation> ops, ICollection<OperationDependency> deps)
		{
			var roots = FindRoots(ops, deps);
			foreach (var root in roots)
			{
				var order = GetBuildOrder(root, ops.Except(roots).ToArray(), deps);
				ops = ops.Except(order).ToArray();
				yield return order;
			}
		}

		private static ICollection<Operation> FindRoots(IEnumerable<Operation> ops, IEnumerable<OperationDependency> deps)
		{
			return ops.Where(o => IsRoot(o, deps)).ToArray();
		}

		private static bool IsRoot(Operation op, IEnumerable<OperationDependency> deps)
		{
			return deps.All(d => op != d.Child);
		}

		private static ICollection<Operation> GetBuildOrder(Operation root, ICollection<Operation> ops, ICollection<OperationDependency> deps)
		{
			var order = new List<Operation> { root };

			GetBuildOrder(ops, deps, order);

			return order;
		}

		private static void GetBuildOrder(ICollection<Operation> ops, ICollection<OperationDependency> deps, List<Operation> order)
		{
			var q = from op in ops
					from dep in deps
					where dep.Child == op && order.Contains(dep.Parent)
					select op;

			var arr = q.ToArray();
			if (arr.Any())
			{
				order.AddRange(arr);

				GetBuildOrder(ops.Except(order).ToArray(), deps, order);
			}
		}
	}

	[DebuggerDisplay("{Name}")]
	public class Operation
	{
		public Operation(string name)
		{
			Name = name;
		}

		public string Name { get; private set; }

		public override bool Equals(object obj)
		{
			var op = obj as Operation;
			return !ReferenceEquals(op, null) && String.Equals(Name, op.Name);
		}

		public override int GetHashCode()
		{
			return Name != null ? Name.GetHashCode() : 0;
		}

		public static bool operator ==(Operation a, Operation b)
		{
			return !ReferenceEquals(a, null) &&
				   !ReferenceEquals(b, null) &&
				   a.Equals(b);
		}

		public static bool operator !=(Operation a, Operation b)
		{
			return !(a == b);
		}
	}

	public class OperationDependency
	{
		public OperationDependency(string child, string parent)
		{
			Parent = new Operation(parent);
			Child = new Operation(child);
		}

		public Operation Child { get; private set; }

		public Operation Parent { get; private set; }
	}
}