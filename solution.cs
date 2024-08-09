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