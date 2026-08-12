public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

Dictionary<int,int> freq = new Dictionary<int,int>();
List<int> returnable = new List<int>();

foreach(int c in nums)
{
    if (freq.ContainsKey(c))
    {
        freq[c]++;
    }
    else
    {
        freq[c] = 1;
    }
}

for (int i = 0; i < k; i++)
{
    int m = 0;
    int key = 0;
    foreach(KeyValuePair<int, int> kvp in freq)
    {
        if(kvp.Value > m)
        {
            m = kvp.Value;
            key = kvp.Key;
        }
    }
    returnable.Add(key);
    freq.Remove(key);

}

            return returnable.ToArray();
    }
}
