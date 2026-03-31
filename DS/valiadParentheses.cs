

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class Solution15
{
    private Dictionary<char,char> dict;
    public bool IsValid(string s)
    {
        dict = new Dictionary<char, char>();
        dict.Add('(',')');
        dict.Add('[',']');
        dict.Add('{','}');

        Stack<char> stack = new Stack<char>();
        var response = Helper(0, s, stack);
        return response && stack.Count == 0;
    }

    private bool Helper(int i, string s, Stack<char> stack)
    {
        if (i < s.Length)
        {
            if (stack.Count == 0 || dict[stack.Peek()] != s[i])
            {
                if (dict.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                    return Helper(i + 1, s, stack);

                }

            return false;

            }

            else
            {
                stack.Pop();
                return Helper(i + 1, s, stack);
            }

        }

        return true;

    }

}