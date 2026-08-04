public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> s = new HashSet<int>();
        bool flag = false;
        foreach(int c in nums){
            if(s.Contains(c)){
                flag = true;
                break;
            }else{
                s.Add(c);
            }
        }
        
        return flag;


    }
}