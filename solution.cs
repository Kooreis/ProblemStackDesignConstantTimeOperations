Here is a C# console application that implements a stack with getMin, getMax, push, and pop operations in constant time.

```C#
using System;
using System.Collections.Generic;

public class StackWithMinMax
{
    private Stack<int> mainStack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();
    private Stack<int> maxStack = new Stack<int>();

    public void Push(int value)
    {
        mainStack.Push(value);

        if (minStack.Count == 0 || value <= minStack.Peek())
        {
            minStack.Push(value);
        }

        if (maxStack.Count == 0 || value >= maxStack.Peek())
        {
            maxStack.Push(value);
        }
    }

    public int Pop()
    {
        if (mainStack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int value = mainStack.Pop();

        if (minStack.Peek() == value)
        {
            minStack.Pop();
        }

        if (maxStack.Peek() == value)
        {
            maxStack.Pop();
        }

        return value;
    }

    public int GetMin()
    {
        if (minStack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return minStack.Peek();
    }

    public int GetMax()
    {
        if (maxStack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return maxStack.Peek();
    }
}

class Program
{
    static void Main(string[] args)
    {
        StackWithMinMax stack = new StackWithMinMax();
        stack.Push(5);
        stack.Push(1);
        stack.Push(10);
        Console.WriteLine(stack.GetMin()); // Outputs: 1
        Console.WriteLine(stack.GetMax()); // Outputs: 10
        stack.Pop();
        Console.WriteLine(stack.GetMax()); // Outputs: 5
    }
}
```
This program creates a stack that supports push, pop, getMin, and getMax operations in constant time. It uses three stacks: the main stack for storing the elements, and two auxiliary stacks for keeping track of the minimum and maximum elements. The minimum and maximum elements are updated in constant time whenever an element is pushed or popped from the stack.