//stack/queue 0(1) time, fast than inserting with linked lists
//use case for items that need to be ordered, messages, undo, web navigation
//


public class MyQueue
{
    private Stack<int> inputStack;
    private Stack<int> outputStack;

    public MyQueue()
    {
        inputStack = new Stack<int>();
        outputStack = new Stack<int>();
    }

    public void Push(int x)
    {
        inputStack.Push(x);
    }

    public int Pop()
    {
        MoveIfEmpty();
        return outputStack.Pop();
    }

    public int Peek()
    {
        MoveIfEmpty();
        return outputStack.Peek();
    }

    public bool Empty()
    {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }

    private void MoveIfEmpty()
    {
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
    }

}
