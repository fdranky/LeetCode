<Query Kind="Program" />

void Main()
{
	int result = 0;
	string input = "(()())";
	char s = input[0];
	int acc = 1;
	
	for (int i = 1; i < input.Length; i++) 
	{
		if (input[i] == s)
		{
			acc++;
		}
		else
		{
			acc--;
		}
		
		if (acc == 0) result++;
	}
	
	Console.WriteLine(result);
}

// Define other methods and classes here
