public class Solution {
    public bool hasDuplicate(int[] nums) {

        
        HashSet<int> s = new HashSet<int>();
        bool flag = false;
        for(int i = 0; i < nums.Length; i++){
            if(s.Contains(nums[i])){
                flag = true;
                break;
            }else{
                s.Add(nums[i]);
            }
        }
        
        return flag;


    }
}