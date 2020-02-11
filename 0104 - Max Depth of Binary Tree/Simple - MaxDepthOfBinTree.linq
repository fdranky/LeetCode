<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int MaxDepthSimple(TreeNode root)
{
	return (root == null) ? 0 : 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
}