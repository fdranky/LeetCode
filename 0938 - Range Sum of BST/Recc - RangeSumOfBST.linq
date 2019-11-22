<Query Kind="Program" />

void Main()
{
	
}

public int RangeSumBST(TreeNode root, int L, int R) 
{
    int sum = 0;
    if (root == null) return 0;
    
    if (L <= root.val && root.val <= R) 
    {
        sum += root.val;
    }
    
	if (root.left.val)
    sum += RangeSumBST(root.left, L, R);
    sum += RangeSumBST(root.right, L, R);
    
    return sum;
}
// Define other methods and classes here
