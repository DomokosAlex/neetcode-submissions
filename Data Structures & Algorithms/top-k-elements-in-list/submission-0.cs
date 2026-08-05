public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                    
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> returnable = new List<int>();

            foreach (int i in nums)
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;
                }
                else
                {
                    freq[i] = 1;
                }


            }


            while(k > 0)
            {
                int num = 0;
                int amount = 0;

                foreach(KeyValuePair<int,int> i in freq)
                {
                    if(i.Value > amount)
                    {
                        amount = i.Value;
                        num = i.Key;
                    }
                }

                k--;
                returnable.Add(num);
                freq.Remove(num);
                amount = 0;

            }
            return returnable.ToArray();
    }
}
