public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                List<int> res = new List<int>() {1 };

int temp = 1;

for (int i = 0; i < nums.Length - 1; i++)
{
    temp *= nums[i];
    res.Add(temp);
    
}

temp = 1;
for (int i = nums.Length - 1; i >= 0; i--)
{
    
    res[i] *= temp;

    temp *= nums[i];

}

return res.ToArray();

    }
}
