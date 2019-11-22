<Query Kind="Program" />

void Main()
{
	string moves = "RRRRLLLLDDDUUU";
	Console.WriteLine(moves.Count(x => x == 'R') == moves.Count(x => x == 'L') && moves.Count(x => x == 'U') == moves.Count(x => x == 'D'));
}

// Define other methods and classes here
