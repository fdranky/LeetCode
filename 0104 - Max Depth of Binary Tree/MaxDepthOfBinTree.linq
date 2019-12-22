<Query Kind="Program" />

void Main()
{
	//MaxDepth - 1 is legth
}

public int MaxDepth(TreeNode root)
{
    if (root == null) return 0;
    
    if (root.right == null && root.left == null)
    {
        return 1;
    }
    else
    {
        int right = 1;
        int left = 1;
        
        if (root.right != null) 
        {
            right = 1 + MaxDepth(root.right);
        }
        
        if (root.left != null)
        {
            left = 1 + MaxDepth(root.left);    
        }
        
        return right > left ? right : left;
    }
}
// Define other methods and classes here

public int MaxDepthSimple(TreeNode root)
{
	return (root == null) ? 0 : 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
}