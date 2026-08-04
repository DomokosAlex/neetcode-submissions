public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         Dictionary<string, List<string>> masterdict = new Dictionary<string, List<string>>();

for (int i = 0; i < strs.Length; i++)
{
    int[] hash = new int[26];
    
    foreach(char c in strs[i]){
        hash[c - 'a']++;
    }

    string key = string.Join(",", hash);

    if (masterdict.ContainsKey(key))
    {
        masterdict[key].Add(strs[i]);
    }
    else
    {
        masterdict[key] = new List<string>() { strs[i] };
    }



}

List<List<string>> returnable = new List<List<string>>();


foreach(var c in masterdict)
{
   
    List<string> group = new List<string>();
    foreach(var m in c.Value)
    {
        group.Add(m);
        
    }

    returnable.Add(group);
    
}

return returnable;

    }
}
