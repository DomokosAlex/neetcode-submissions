public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        if(numbers.Length == 2)
        {
            return [1,2];
        }

        
        int L = 0;
        int R = numbers.Length - 1;
        List<int> returnable = new List<int>();

while(L < R)
{
    if (numbers[L] + numbers[R] == target)
    {
        returnable.Add(L + 1);
        returnable.Add(R + 1);
        break;
    }
    else if (numbers[L] + numbers[R] > target)
    {
        R--;
    }
    else if (numbers[L] + numbers[R] < target)
    {
        L++;
    }
}


        return returnable.ToArray();
    }
}
