public class Node
{
    public int Data {get; set;}
    public Node Next {get; set;}

    public Node(int new_data)
    {
        Data = new_data;
        Next = null;
    }

}