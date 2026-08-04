public class Solution {
    public int[] TwoSum(int[] nums, int target) {



           Dictionary<int, int> seen = new Dictionary<int, int>();

            List<int> returnable = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {

                

                if(seen.ContainsKey(target - nums[i]))
                {
                    returnable.Add(seen[target - nums[i]]);

                    returnable.Add(i);
break;
                    
                    
                }
                else
                {
                    seen[nums[i]] = i;
                }
                

            }


return returnable.ToArray();


    }
}
