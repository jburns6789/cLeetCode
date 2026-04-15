namespace System.Collections.Generic;

// print the value of each node in reverse
// time o(n) based on input and o(1)
// singly-linked list, only one way to reverse have to create a duplicate
// using a collection to reverse is the naive approach hashmap time O(n). space O(n)
// two pointer is the optimal approach time O(n) iterating through the entire list once
// space O(1) updating in place and not creating anything new


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

    public Node PrintReverse(Node head)
    {
       if (head == null || head.Next == null)
        {
            return head;
        }

        Node prev = null;
        Node cur = head;

        while (cur != null)
        {
            Node post = cur.Next;
            cur.Next = prev;
            prev = cur;
            cur = post;
        }

        return prev;

    }

    // resursive solution

    // void ReadBackward (Node n)
    // {
    //     if (n == null)
    //         return;
    //     else
    //         ReadBackward(n.Next);

    //     Console.WriteLine(n.Data);

    // }

    // public static void Main(string[] args)
    // {
    //     Node head = new Node(10);
    //     head.Next = new Node(20);
    //     head.Next.Next = new Node(30);
    //     head.Next.Next = new Node(40);

    //     TraverseList(head);
    // }


}