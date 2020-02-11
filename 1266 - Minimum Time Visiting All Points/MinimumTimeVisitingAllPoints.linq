<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int MinTimeToVisitAllPoints(int[][] points) 
{
   int result = 0;
   for (int i = 1; i < points.Length; i++) 
   {
       var current = points[i - 1];
       var next = points[i];
       result += Math.Max(Math.Abs(next[0] -  current[0]), Math.Abs(next[1] -  current[1]));   
   }
    
   return result;  
}