public class Solution {
    public bool hasDuplicate(int[] nums) {

HashSet<int> lattam = new HashSet<int>();

foreach (int i in nums)
{
    if (lattam.Contains(i))
    {
        return true;
    }
    else
    {
        lattam.Add(i);
    }
}
return false;





    }
}