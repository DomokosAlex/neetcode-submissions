public class Solution {
    public bool hasDuplicate(int[] nums) {

            List<int> ures = new List<int>();


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