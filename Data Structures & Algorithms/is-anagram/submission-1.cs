public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
            return false;
        Dictionary<char,int> res = new();
        foreach(char ch in s){
            if(res.ContainsKey(ch)){
                res[ch]++;
            }
            else
                res.Add(ch,1);
        }
        foreach(char ch in t){
            if(!res.ContainsKey(ch) || res[ch]==0)
                return false;
            res[ch]--;
        }
        return true;
    }
}
