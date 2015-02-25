using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class StackTest
	{
		[Theory]
		[InlineData(typeof(LinkedListStack<int>))]
		[InlineData(typeof(QueueStack<int>))]
		public void CustomQueue(Type t)
		{
			IStack<int> stack = (IStack<int>)Activator.CreateInstance(t);
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			foreach (var i in new[] { 3, 2, 1 })
			{
				stack.Pop().Should().Be(i);
			}
		}
	}
}