<Query Kind="Program" />

void Main()
{
	int[] A = {1,2,3,4};
	int[,] queries = {{1,0},{-3,1},{-4,0},{2,3}};
	int[] B = new int[queries.GetLength(0)];
	for(int i = 0; i < queries.GetLength(0); i++) 
	{
		Console.WriteLine(queries[i,0]);
		A[queries[i,1]] += queries[i,0];
		B[i] += A.ToList().Where(x => (x & 1) == 0).Sum();
	}
	
	B.Dump();
}

// Define other methods and classes here