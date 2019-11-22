<Query Kind="Program" />

void Main()
{
	
}

public int HammingDistance(int x, int y) {
    int sum = 0;
    int z = x ^ y;
    while (z > 0)
    {
        sum += z & 1;
        z = z >> 1;
    }
    
    return sum;
}
// Define other methods and classes here
