<Query Kind="Program" />

void Main()
{
	int[] A = {1,2,3,4};
	int[,] queries = {{1,0},{-3,1},{-4,0},{2,3}};
	int[] B = new int[A.GetLength(0)];
	int sum = A.Where(x => (x & 1) == 0).Sum();
	
	for(int i = 0; i < queries.GetLength(0); i++) 
	{
		int index = queries[i,1];
		int indexValue = A[index];
		if ((A[index] & 1) == 0)
		{
			sum -= A[index];
		} 
		A[index] += queries[i,0];
		if ((A[index] & 1) == 0)
		{
			sum += A[index];
		} 
		B[i] = sum;
	}
	
	B.Dump();
}

// Define other methods and classes here
