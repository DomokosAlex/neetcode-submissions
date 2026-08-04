public class Solution {
    public bool hasDuplicate(int[] nums) {
HashSet<int> set = new HashSet<int>();

 foreach(var c in nums)
 {
     if (set.Contains(c))
     {
         return true;
     }
     else
     {
         set.Add(c);
     }
 }

 return false;

    }
}