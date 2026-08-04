public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         List<List<string>> masterlist = new List<List<string>>(); 

            Dictionary<string, List<string>> 
            dict = new Dictionary<string, List<string>>();


            for(int i = 0; i < strs.Length; i++)
            {
                int[] fin = new int[26];


                foreach(char c in strs[i])
                {
                    fin[c - 'a']++;
                }

                string print = string.Join(",", fin);

                if (dict.ContainsKey(print))
                {
                    dict[print].Add(strs[i]);
                }
                else
                {
                    dict[print] = new List<string>() { strs[i] };
                }
            }


            foreach(var c in dict)
            {
                masterlist.Add(c.Value);
            }
            return masterlist;


    }
}
