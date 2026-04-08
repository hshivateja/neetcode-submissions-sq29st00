public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int rowLen = board.GetLength(0);
        int colLen = board[0].Length;
        for(int i=0;i<rowLen;i++){
            HashSet<char> set = new();
            for(int j=0;j<colLen;j++){
                if(board[i][j]!='.'){
                    var ch = board[i][j];
                    if(set.Contains(ch))
                        return false;
                    else
                        set.Add(ch);
                }
            }
        }
        for(int i=0;i<rowLen;i++){
            HashSet<char> set = new();
            for(int j=0;j<colLen;j++){
                if(board[j][i]!='.'){
                    var ch = board[j][i];
                    if(set.Contains(ch))
                        return false;
                    else
                        set.Add(ch);
                }
            }
        }
        for(int i=0;i<rowLen;i=i+3){
            for(int j=0;j<colLen;j=j+3){
                HashSet<char> set = new();
                for(int p=0;p<3;p++){
                    for(int q=0;q<3;q++){
                        int row = i+p;
                        int col = j+q;
                        var ch = board[row][col];
                        if(ch=='.')
                            continue;
                        if(set.Contains(ch))
                            return false;
                        else
                            set.Add(ch);
                    }
                }
            }
        }
        return true;
    }
}
