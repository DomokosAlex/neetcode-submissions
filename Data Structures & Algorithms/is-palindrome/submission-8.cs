public class Solution {
    public bool IsPalindrome(string s) {

            string filtered = "";
foreach(var c in s)
{
    if (char.IsLetterOrDigit(c))
    {
        filtered += c;
    }
}

filtered = filtered.ToLower();
for (int i = 0; i < filtered.Length / 2; i++)
{
    if (filtered[i] != filtered[filtered.Length - 1 - i])
    {
        return false;
    }
}
return true;    

    }
}
