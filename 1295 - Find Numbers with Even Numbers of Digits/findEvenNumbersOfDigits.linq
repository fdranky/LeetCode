<Query Kind="Program" />

void Main()
{
	
}

public int FindNumbers(int[] nums) 
{
    int even = 0;
    for(int i = 0; i < nums.Length; i++) 
    {
        int num = nums[i];
        int loop = 0;
        while (num > 0)
        {
            num /= 10;
            loop++;
        }
        even += (loop & 1) == 0 ? 1 : 0;
    }
    return even;
}
// Define other methods and classes here
