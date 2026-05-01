public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<char>[] subBox = new HashSet<char>[9];
        HashSet<char>[] rowBox = new HashSet<char>[9];
        HashSet<char>[] columnBox = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            subBox[i] = new HashSet<char>();
            rowBox[i] = new HashSet<char>();
            columnBox[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                char currentVal = board[i][j];
                if(currentVal == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3);
                if(!subBox[boxIndex].Add(currentVal)
                    || !rowBox[i].Add(currentVal)
                    || !columnBox[j].Add(currentVal))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
