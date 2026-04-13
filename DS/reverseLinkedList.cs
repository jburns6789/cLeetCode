// print the vale of each node in reverse
// time o(n) based on input and o(1)

// class Node
// {
//     public int Data {get; set;}
//     public Node Next {get; set;}

//     public Node(int new_data)
//     {
//         Data = new_data
//         Next = null;
//     }

// }

public class LinkedListExercise
{
    public static void TraverseList(Node head)
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

    public static void PrintReverse(Node head)
    {
        

        
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