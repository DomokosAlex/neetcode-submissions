public class Solution {
    public bool hasDuplicate(int[] nums) {

            HashSet<int> ures = new HashSet<int>();


            foreach (int x in nums) 
            {

                if (ures.Contains(x))
                {
                    return true;
                }
                else
                {
                    ures.Add(x);
                }
            
            }

            return false;

    }
}