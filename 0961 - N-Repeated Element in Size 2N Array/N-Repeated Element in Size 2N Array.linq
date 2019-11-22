<Query Kind="Program" />

void Main()
{
	int[] arr = {1, 1, 1, 2, 3, 4};
	Dictionary<int, int> dicc = new Dictionary<int, int>();
	for (int i = 0; i < arr.Length; i++)
	{
		if (dicc.ContainsKey(arr[i])) 
		{
			Console.WriteLine(arr[i]);
			break;
		} 
		else
		{
			dicc.Add(arr[i], 0);
		}
	}
}

// Define other methods and classes here
