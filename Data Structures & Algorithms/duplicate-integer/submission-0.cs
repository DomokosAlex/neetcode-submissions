public class Solution {
    public bool hasDuplicate(int[] nums) {

        var numsSet = nums.ToHashSet();
        return numsSet.Count != nums.Length;


        


    }
}