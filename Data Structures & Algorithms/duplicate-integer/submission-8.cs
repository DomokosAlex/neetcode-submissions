public class Solution {
    public bool hasDuplicate(int[] nums) {

        Dictionary<int, int> ures = new Dictionary<int,int>();


foreach (int x in nums) 
{

    if (ures.ContainsKey(x))
    {
        return true;
    }
    else
    {
        ures[x] = 1;
    }

}

return false;


    }
}