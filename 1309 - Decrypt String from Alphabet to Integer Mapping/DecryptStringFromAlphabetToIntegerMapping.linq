<Query Kind="Program" />

void Main()
{
	string s = "10#11#12";
	Console.WriteLine(FreqAlphabets(s));
}

// Define other methods and classes here
public string FreqAlphabets(string s) 
{
    string res = String.Empty;
    for (int i = 0; i < s.Length; i++) 
    {
        if (i < s.Length - 2 && s[i + 2] == '#') 
        {
            char c = Convert.ToChar(96 + Int32.Parse(s.Substring(i, 2)));
            res += c;
            i += 2;
        }
        else
        {
			int t = s[i] - 48;
            char c = Convert.ToChar(96 + t);
            res += c;
        }
    }
    
    return res;
}