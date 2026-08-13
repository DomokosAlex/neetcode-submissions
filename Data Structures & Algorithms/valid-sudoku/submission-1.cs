public class Solution {
    public bool IsValidSudoku(char[][] board) {
            for (int i = 0; i < board.Length; i++)
            {
                HashSet<char> row = new HashSet<char>();
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.') continue;

                    if (row.Contains(board[i][j]))
                    {
                        return false;
                        break;
                    }
                    else
                    {
                        row.Add(board[i][j]);
                    }
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                HashSet<char> col = new HashSet<char>();
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[j][i] == '.') continue;

                    if (col.Contains(board[j][i]))
                    {
                        return false;
                        break;
                    }
                    else
                    {
                        col.Add(board[j][i]);
                    }
                }
            }

            
            Dictionary<int, HashSet<char>> nums = new Dictionary<int, HashSet<char>>() {

                {0, new HashSet<char>()},
                {1, new HashSet<char>()},
                {2, new HashSet<char>()},
                {3, new HashSet<char>()},
                {4, new HashSet<char>()},
                {5, new HashSet<char>()},
                {6, new HashSet<char>()},
                {7, new HashSet<char>()},
                {8, new HashSet<char>()},

            };


            for (int i = 0; i < board.Length; i++)
            {
                
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.') continue;

                    int areakey = ((i / 3) * 3) + (j / 3);

                    if (nums[areakey].Contains(board[i][j]))
                    {
                       return false;
                    }
                    else
                    {
                        nums[areakey].Add(board[i][j]);
                    }


                }
            }

    return true;

}
}
