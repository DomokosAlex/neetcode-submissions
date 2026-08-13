public class Solution {
    public int LongestConsecutive(int[] nums) {
        
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return 1;
            }


            var halmaz = nums.ToHashSet();
            int lc = 0;
            foreach(var c in halmaz)
            {
                if(!halmaz.Contains(c - 1))
                {
                    int l = 0;
                    int counter = c - 1;
                    while(halmaz.Contains(counter + 1))
                    {
                        l++;
                        counter++;
                    }

                    if(lc < l)
                    {
                        lc = l;
                    }
                }
            }

            return lc;
    }
}
