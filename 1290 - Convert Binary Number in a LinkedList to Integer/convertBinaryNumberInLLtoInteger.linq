<Query Kind="Program" />

void Main()
{
	
}

public int GetDecimalValue(ListNode head) {
    Stack<int> stack = new Stack<int>();
    while (head != null) 
    {
        stack.Push(head.val);
        head = head.next;
    }
    
    int count = 0;
    int val = 0;
    while (stack.Count > 0) 
    {
        val += stack.Pop() * (int)Math.Pow(2, count);
        count++;
    }
    
    return val;
}
// Define other methods and classes here
