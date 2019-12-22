<Query Kind="Program" />

void Main()
{
	
}

public IList<IList<int>> LevelOrder(TreeNode root) 
{
	var result = new List<IList<int>>();
	LevelHelper(result, root, 0);
	return result;
}

public void LevelHelper(List<IList<int>> result, TreeNode root, int height)
{
	if (root == null) return;
	if (height >= result.Count)
	{
		result.Add(new List<int>());
	}
	result[height].Add(root.val);
	LevelHelper(result, root.left, height + 1);
	LevelHelper(result, root.right, height + 1);
}
// Define other methods and classes here
