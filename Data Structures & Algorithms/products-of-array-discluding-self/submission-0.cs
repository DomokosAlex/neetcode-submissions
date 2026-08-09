public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                List<int> output = new List<int>();

        List<int> left = new List<int>() {1};
        List<int> right = new List<int>() {1};


                
        for (int i = 0; i < nums.Length - 1; i++)
        {
            left.Add(left[i] * nums[i]);
            
        }

        int rightnum = 1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            
            right.Add(rightnum * nums[i]);
            rightnum *= nums[i];
        }




        for (int i = 0; i < left.Count; i++)
        {
            output.Add(left[i] * right[(right.Count - 1) - i]);
        }
        return output.ToArray();

    }
}
