<Query Kind="Program" />

void Main()
{
	DiStringMatch("DDI").Dump();
}

public int[] DiStringMatch(string S) {
    int[] arr = new int[S.Length + 1];
    int low = 0;
    int high = S.Length;
    
    for(int i = 0; i < S.Length; i++)
    {
        if (S[i] == 'D')
        {
            arr[i] = high;
			arr[i + 1] = low;
        	high--;
        } 
        else
        {
            arr[i] = low;
			arr[i + 1] = high;
        	low++;
        }
    }
    return arr;
}
// Define other methods and classes here
