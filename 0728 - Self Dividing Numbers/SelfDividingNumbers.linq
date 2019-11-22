<Query Kind="Program" />

void Main()
{
	int left = 1;
	int right = 11;
	
    SelfDividingNumbers(left, right).Dump();
}

public IList<int> SelfDividingNumbers(int left, int right) {
    List<int> numbers = new List<int>();
    while (left <= right)
    {
        int num = left; 
        
        if (CheckIfSelfDividing(num))
        {
            numbers.Add(num);    
        } 
        
        left++;
    }
    return numbers;
}

public bool CheckIfSelfDividing(int number)
{
	int dividend = number;
    while (dividend > 0)
    {
        if ((dividend % 10 != 0) && number % (dividend % 10) == 0)
        {
            dividend = dividend / 10;    
        } 
		else
		{
			return false;
		}
    }
    
    return true;
}
// Define other methods and classes here
