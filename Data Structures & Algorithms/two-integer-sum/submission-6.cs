public class Solution {
    public int[] TwoSum(int[] nums, int target) {
             Dictionary<int, int> seen = new Dictionary<int, int>();

 List<int> returnable = new List<int>();

 for (int i = 0; i < nums.Length; i++)
 {
     int check = target - nums[i];
     if (seen.ContainsKey(check))
     {
         returnable.Add(seen[check]);
         returnable.Add(i);
     }
     else
     {
           seen.Add(nums[i], i);
     }
 }


return returnable.ToArray();


    }
}
