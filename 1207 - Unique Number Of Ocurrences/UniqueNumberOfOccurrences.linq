<Query Kind="Expression" />

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        HashSet<int> set = new HashSet<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++) 
        {
            dict[arr[i]] = dict.ContainsKey(arr[i]) ? dict[arr[i]] + 1 : 0;    
        }
        
        foreach (int val in dict.Values)
        {
            set.Add(val);    
        }
		
//		foreach (int val in dict.Values)
//        {
//            if (set.Contains(val)) return false;
//            set.Add(val);    
//        }
        
        return set.Count == dict.Count;
    }
}