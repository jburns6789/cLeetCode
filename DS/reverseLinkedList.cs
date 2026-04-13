// print the vale of each node in reverse
//

class Node
{
    public int Data {get; set;}
    public Node Next {get; set;}

    public Node(int new_data)
    {
        Data = new_data
        Next = null;
    }

}

class GfG
{
    static void TraverseList(Node head)
    {
        while (head != null)
        {
            Console.Write(head.Data);
            if (head.Next != null)
            {
                Console.Write("->");
            }
            head = head.Next;
        }
        Console.WriteLine();

    }

    // public static void Main(string[] args)
    // {
    //     Node head = new Node(10);
    //     head.Next = new Node(20);
    //     head.Next.Next = new Node(30);
    //     head.Next.Next = new Node(40);

    //     TraverseList(head);
    // }


}