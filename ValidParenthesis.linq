<Query Kind="Program" />

void Main()
{
	
}

public bool BalancedBrackets(string s) {
    if (s.Length == 0) return true;
    
    Stack<char> stack = new Stack<char>();
    for (int i = 0; i < s.Length; i++) 
    {       
        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        {
            stack.Push(s[i]);
        }
        else if(stack.Count == 0)
        {
            return false;
        }
        else if(stack.Count > 0)
        {
            switch(s[i])
            {
                case ')': 
                    if (stack.Pop() != '(') return false;
                    break;
                case '}': 
                    if (stack.Pop() != '{') return false;
                    break;
                case ']': 
                    if (stack.Pop() != '[') return false;
                    break;
            }    
        }
    }
    
    return stack.Count == 0;
}
// Define other methods and classes here
