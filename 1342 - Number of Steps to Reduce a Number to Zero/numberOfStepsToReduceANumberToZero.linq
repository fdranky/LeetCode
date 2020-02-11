<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int NumberOfSteps (int num) 
{
    int inc = 0;
    
    while (num > 0) 
    {
        if ((num & 1) == 0) 
        {
            num = num >> 1;
        } 
        else 
        {
            num--;   
        }
        
        inc++;   
    }
    
    return inc;
}