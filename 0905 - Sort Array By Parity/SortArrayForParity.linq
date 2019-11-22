<Query Kind="Program" />

void Main()
{
	var A = new int[]{4,2,3, 8,1};
	int i = 0;
	int j = A.Length - 1;
	while(i < j) 
	{
		if ((A[i] & 1) > (A[j] & 1)) 
		{
			var temp = A[i];
			A[i] = A[j];
			A[j] = temp;
		}
		
		if (A[i] % 2 == 0) i++;
		if (A[j] % 2 == 1) j--;
	}
	
	A.Dump();
}
// Define other methods and classes here
