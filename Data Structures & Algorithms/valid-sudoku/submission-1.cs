public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i=0;i<board.GetLength(0);i++){
            for(int j=0;j<board[0].Length;j++){
                if(board[i][j]!='.'){
                    if(ValidatedRow(i,board[i][j],board) && ValidatedColumn(j,board[i][j],board) && ValidatedGrid(i,j,board)){
                        continue;
                    }
                    else
                        return false;
                }
            }
        }
        return true;
    }

    private bool ValidatedRow(int row, char val, char[][] board){
        HashSet<char> set = new();
        for(int j=0;j<board[0].Length;j++){
            if(board[row][j]=='.') continue;
            if(set.Contains(board[row][j]))
                return false;
            set.Add(board[row][j]);
        }
        return true;
    }

    private bool ValidatedColumn(int col, char val, char[][] board){
        HashSet<char> set = new();
        for(int j=0;j<board.Length;j++){
            if(board[j][col]=='.')
                continue;
            if(set.Contains(board[j][col]))
                return false;
            set.Add(board[j][col]);
        }
        return true;
    }

    private bool ValidatedGrid(int row, int col, char[][] board){
        HashSet<char> set = new();
        int startRow = (row/3) * 3;
        int startCol = (col/3) * 3;

        for(int i=startRow;i<startRow+3;i++){
            for(int j=startCol;j<startCol+3;j++){
                if(board[i][j]=='.')
                continue;
                if(set.Contains(board[i][j]))
                    return false;
                set.Add(board[i][j]);
            }
        }
        return true;
    }
}
