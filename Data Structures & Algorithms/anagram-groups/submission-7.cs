public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         List<List<string>> masterlist = new List<List<string>>(); 

            Dictionary<string, List<string>> 
            dict = new Dictionary<string, List<string>>();

Dictionary<string, List<string>> masterdict = new Dictionary<string, List<string>>();

foreach (string str in strs) 
{

    int[] key = new int[26];

    foreach (char c in str)
    {
        key[c - 'a']++;
    }
    string keyst = String.Join(",", key);


    if (masterdict.ContainsKey(keyst)) {

        masterdict[keyst].Add(str);
    }
    else
    {
        masterdict[keyst] = new List<string> { str };
    }

}


List<List<string>> returnable = new List<List<string>>();

foreach(KeyValuePair<string, List<string>> kvp in masterdict)
{
    returnable.Add(kvp.Value);
}

return returnable;


    }
}
