public class Solution {
    public bool IsValidSudoku(char[][] board) {

    for (int i = 0; i < board.Length; i++)
    {
        HashSet<char> seenbefore = new HashSet<char>();
        for (int j = 0; j < board[i].Length; j++)
        {
            if (seenbefore.Contains(board[j][i]) && board[j][i] != '.')
            {
                return false;
            }
            else
            {
                seenbefore.Add(board[j][i]);
            }
        
        }
        
    }

    //row
    for (int i = 0; i < board.Length; i++)
    {
        HashSet<char> seenbefore = new HashSet<char>();
        for (int j = 0; j < board[i].Length; j++)
        {
            if (seenbefore.Contains(board[i][j]) && board[i][j] != '.')
            {
                return false;
            }
            else
            {
                seenbefore.Add(board[i][j]);
            }

        }

    }


Dictionary<int, HashSet<char>> masterdict = new Dictionary<int, HashSet<char>>
{
    {0, new HashSet<char>() },
    {1, new HashSet<char>() },
    {2, new HashSet<char>() },
    {3, new HashSet<char>() },
    {4, new HashSet<char>() },
    {5, new HashSet<char>() },
    {6, new HashSet<char>() },
    {7, new HashSet<char>() },
    {8, new HashSet<char>() },
};

//3x3
for (int i = 0; i < board.Length; i++)
{
    
    for (int j = 0; j < board[i].Length; j++)
    {
        
        if (masterdict[(i / 3) * 3 + (j / 3)].Contains(board[i][j]) && board[i][j] != '.')
        {
            return false;
        }
        else
        {
            masterdict[(i / 3) * 3 + (j / 3)].Add(board[i][j]);
        }

    }

}

    return true;

}
}
