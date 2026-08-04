public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> s = new HashSet<int>();
        foreach(int c in nums){
            if(s.Contains(c)){
                return true;
            }
                s.Add(c);
        }

        return false;
    }
}