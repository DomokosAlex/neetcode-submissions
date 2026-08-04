public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }



Dictionary<char, int> w1 = new Dictionary<char, int>();
Dictionary<char, int> w2 = new Dictionary<char, int>();

foreach(var c in s)
{
    if (w1.ContainsKey(c))
    {
        w1[c]++;
    }
    else
    {
        w1[c] = 1; 
    }
}
foreach (var c in t)
{
    if (w2.ContainsKey(c))
    {
        w2[c]++;
    }
    else
    {
        w2[c] = 1;
    }
}

foreach(KeyValuePair<char, int> c in w1)
{
    if (w2.ContainsKey(c.Key))
    {
        if (w2[c.Key] != c.Value)
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}
return true;

    }
}
