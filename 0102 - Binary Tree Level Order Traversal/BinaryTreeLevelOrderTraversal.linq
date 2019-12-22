<Query Kind="Program" />

void Main()
{
	
}

public IList<IList<int>> LevelOrder(TreeNode root) {
    var result = new List<IList<int>>();
    if (root == null) return result;
    
    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    
    while(queue.Count > 0)
    {
        var count = queue.Count;
        var list = new List<int>();
        for (int i = 0; i < count; i++) 
        {
            var node = queue.Dequeue();
            list.Add(node.val);
            
            if (node.left != null) 
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }
        
        result.Add(list);
    }
    
    return result;
}
// Define other methods and classes here
