<Query Kind="Program" />

void Main()
{
	
}


public int PeakIndexInMountainArray(int[] A) {
    int index = 0;
    
    for (int i = 0; i < A.Length - 1; i++) 
    {
        if (A[i] > A[i + 1])
        {
            index = i;
            break;
        }
    }
    
    return index;
}

public int PeakIndexInMountainArrayBinSearch(int[] A) {
    int low = 0;
    int high = A.Length - 1;
    
    while (low < high) {
        int mid = low + (high - low) / 2;
        if (A[mid] < A[mid + 1])
        {
            low = mid + 1;
        } 
        else 
        {
            high = mid;    
        }
    }
    
    return low;
}
// Define other methods and classes here
