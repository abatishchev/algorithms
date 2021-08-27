using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
	public class StackTest
	{
		[Theory]
		[InlineData(typeof(QueueStack<int>))]
		[InlineData(typeof(LinkedListStack<int>))]
		public void Stack(Type t)
		{
			IStack<int> stack = (IStack<int>)Activator.CreateInstance(t);
			stack.Push(1);

			stack.Pop().Should().Be(1);

			stack.Push(2);
			stack.Push(3);

			foreach (var i in new[] { 3, 2 })
			{
				stack.Pop().Should().Be(i);
			}
		}
	}
}