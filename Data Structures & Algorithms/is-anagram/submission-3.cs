public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Count() != t.Count()){
            return false;
        }
Dictionary<char, int> fiw = new Dictionary<char, int>();
Dictionary<char, int> sew = new Dictionary<char, int>();

for (int i = 0; i < s.Length; i++)
{
    if (!fiw.ContainsKey(s[i]))
    {
        fiw[s[i]] = 1;
    }
    else
    {
        fiw[s[i]]++;
    }
}


for (int i = 0; i < t.Length; i++)
{
    if (!sew.ContainsKey(t[i]))
    {
        sew[t[i]] = 1;
    }
    else
    {
        sew[t[i]]++;
    }
}


foreach (KeyValuePair<char, int> i in fiw)
{
    if (!sew.ContainsKey(i.Key)){
        return false;
    }
    else
    {
        if (sew[i.Key] != i.Value)
        {
            return false;
        }
    }
}
return true;


       

    }
}
