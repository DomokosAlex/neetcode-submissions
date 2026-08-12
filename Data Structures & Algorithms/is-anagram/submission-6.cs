public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

Dictionary<char, int> elso = new Dictionary<char, int>();
Dictionary<char, int> masodik = new Dictionary<char, int>();


foreach (char c in s) 
{

    if (elso.ContainsKey(c))
    {
        elso[c]++;
    }
    else
    {
        elso[c] = 1;
    }


}

foreach (char c in t)
{

    if (masodik.ContainsKey(c))
    {
        masodik[c]++;
    }
    else
    {
        masodik[c] = 1;
    }
}


foreach(KeyValuePair<char, int> kvp in elso)
{
    if (masodik.ContainsKey(kvp.Key))
    {
        if (masodik[kvp.Key] != kvp.Value)
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
