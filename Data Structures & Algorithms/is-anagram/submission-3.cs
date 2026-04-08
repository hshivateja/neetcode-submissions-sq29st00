public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> map = new();
        if(s.Length != t.Length)
            return false;
        foreach(char ch in s){
            if(map.ContainsKey(ch)){
                map[ch]++;
            }
            else
                map[ch] = 1;
        }
        foreach(char ch in t){
            if(!map.ContainsKey(ch)){
                return false;
            }
            map[ch]--;
            if(map[ch]==0)
                map.Remove(ch);
        }
        return true;
    }
}
