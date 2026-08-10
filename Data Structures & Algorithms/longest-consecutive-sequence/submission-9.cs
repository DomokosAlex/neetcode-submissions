public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        
            var s = nums.ToHashSet();
            if(s.Count() == 0){
                return 0;
            }

            if(s.Count() == 1){
                return 1;
            }

            int l = 1;
            int lc = 1;


            foreach (int i in s)
            {
                if (!s.Contains(i - 1))
                {
                    l = 1;
                    while (s.Contains(i + l))
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
