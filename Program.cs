//int[] nums = {3,4,11,15,2,7};
//int target = 9;

//var result = new Solution().TwoSum(nums, target);
//Console.WriteLine($"Indicies: [{result[0]}, {result[1]}]");

//---------------

//int[] prices = {7,1,5,3,6,4};
//var result = new Solution2().maxProfit(prices);
//Console.WriteLine($"Profit:  {result}");

//---------------

//int[] nums = [1,2,3,4];
//int[] nums2 = [1,2,3,3,4,5];
//var result = new Solution3().ContainsDuplicate(nums);
//Console.WriteLine($"{result}");

//---------------

//using System.Data;

//var s = "anagram"; 
//var t = "nagaram";
//var result = new Solution3().IsAnagram(s, t);
//Console.WriteLine($"The result is: {result}");

//---------------

//var s = [] {"h","e","l","l","o"};
//var result = new Solution4().ReverseString(char[] s); 
//Console.WriteLine($"Result: {result}"); 

//---------------

//string s = "abcabcbb";
//var result = new Solution5().LengthOfLongestSubstring(s);
//Console.WriteLine($"Length of substring no repeating characters: {result}");

//---------------

//int[]nums = [0,1,0,3,12];
//var result = new Solution6().moveZeros(nums);
//Console.WriteLine($"{result}");

//---------------

//---------------

//---------------

//---------------

//---------------

//int[]nums = [1,2,3,4];
//var result = new Solution11().productOfArraySelf(nums);
//Console.WriteLine($"{result}");

//---------------

//Solution14 Maximum Subarray
int nums = [-2,1,-3,4,-1,2,1,-5,4];
//oupt6
//largest sum is 6


   
//---------------

//Solution 18 Revese Linked List
    
// Node head = new Node(10);
// head.Next = new Node(20);
// head.Next.Next = new Node(30);
// head.Next.Next.Next = new Node(40);

// Console.Write("Forward: ");
// LinkedListExercise.TraverseList(head);

// Console.Write("Reversed: ");
// LinkedListExercise.PrintReverse(head);

//---------------
    
// Solution 20 Linked List Cycle

ListNode node1 = new ListNode(3);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(0);
ListNode node4 = new ListNode(-4);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node2;

var solution = new Solution20();
Console.WriteLine("Has cycle: " + solution.HasCycle(node1));//True

//ListNode a = new ListNode(1);
//ListNode b = new ListNode(2);
//a.next = b;
//Console.WriteLine("Has cycle: " + solution.HasCycle(a)); // False

//---------------
    
// Solution 21