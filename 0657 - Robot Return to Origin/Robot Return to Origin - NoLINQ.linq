<Query Kind="Program" />

void Main()
{
	string moves = "RRRRLLLLDDDUUU";
	int x = 0;
	int y = 0;
	
	for (int i = 0; i < moves.Length; i++) 
	{
		switch (moves[i]) {
			case 'R': x++;
			break;
			case 'L': x--;
			break;
			case 'U': y++;
			break;
			case 'D': y--;
			break;
		}
	}
	
	Console.WriteLine(x == 0 && y == 0);
}

// Define other methods and classes here
