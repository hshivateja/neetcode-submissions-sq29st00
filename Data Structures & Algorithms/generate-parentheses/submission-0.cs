public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> res = new();
        BackTrack("",0,0,res,n);
        return res;
    }
    private void BackTrack(string current, int open, int close, List<string> res, int n){
        if(current.Length == n*2){
            res.Add(current);
            return;
        }
        if(open<n){
            BackTrack(current+"(",open+1,close,res,n);
        }
        if(close<open){
            BackTrack(current+")",open,close+1,res,n);
        }
    }
}

