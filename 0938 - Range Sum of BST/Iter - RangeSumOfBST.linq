<Query Kind="Program" />

void Main()
{
	
}

public int RangeSumBST(TreeNode root, int L, int R) 
{
    int sum = 0;
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(root);
    
    while (stack.Count() != 0) 
    {
        var node = stack.Pop();
        if (L <= node.val && node.val <= R) 
        {
            sum += node.val;
        }
        
        if (node.left != null)
        {
            stack.Push(node.left);
        }
        
        if (node.right != null)
        {
            stack.Push(node.right);
        }
    }
    
    return sum;
}
// Define other methods and classes here
