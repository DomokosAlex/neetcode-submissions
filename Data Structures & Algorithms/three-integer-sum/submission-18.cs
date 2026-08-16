public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> masterlist = new List<List<int>>();

Array.Sort(nums);
HashSet<string> seen = new HashSet<string>();
            
for (int i = 0; i < nums.Length; i++)
{
    
    int j = i + 1;
    int k = nums.Length - 1;

    int target = -(nums[i]);

    while (j < k)
    {
        if (nums[j] + nums[k] == target)
{
    List<int> trip = new List<int>();
    trip.Add(nums[j]);
    trip.Add(nums[k]);
    trip.Add(nums[i]);
    string pattern = String.Join(",", trip);
    if (!seen.Contains(pattern))
    {   
        masterlist.Add(trip);
        seen.Add(pattern);
        
    }
   j++;
   k--;

}else if(nums[j] + nums[k] < target)
{
    j++;
}
else
{
    k--;
}
    }



}

return masterlist;
    }
}
