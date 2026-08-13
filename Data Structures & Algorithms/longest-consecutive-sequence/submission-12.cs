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
                    
                    while(halmaz.Contains(c + l))
                    {
                        l++;
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
