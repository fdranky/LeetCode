<Query Kind="Program" />

void Main()
{
	
}

public int SubtractProductAndSum(int n) 
{
    int sum = 0;
    int mult = 1;
    
    while (n > 0)
    {
        int val = n % 10;
        n /= 10;
        
        mult *= val;
        sum += val;
    }
    
    return mult - sum;
}
// Define other methods and classes here
