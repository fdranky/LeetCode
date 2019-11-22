<Query Kind="Program" />

void Main()
{
	string input = "(()())(())(()(()))";
	int acc = 1;
	string accS = "";
	
	for (int i = 1; i < input.Length; i++)
	{
		if (input[i] == '(')
		{
			acc++;
		}
		else
		{
			acc--;
		}
		
		if (acc > 0) 
		{
			accS += input[i];
		}
		else 
		{
			i++;
			acc++;
		}
	}
	
	accS.Dump();
	// Use char list for better 
	// Or string builder
}

// Define other methods and classes here
