public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();
        for(int i=0;i<board.GetLength(0);i++){
            for(int j=0;j<board[0].Length;j++){
                char val = board[i][j];
                if(val == '.')
                    continue;
                
                string rowKey = val + " in row " + i;
                string colKey = val + " in col " + j;
                string gridKey = val + " in row " + i/3 + " col in " + j/3;
                
                if(seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(gridKey))
                    return false;
                seen.Add(rowKey);
                seen.Add(colKey);
                seen.Add(gridKey);
            }
        }
        return true;
    }
}
