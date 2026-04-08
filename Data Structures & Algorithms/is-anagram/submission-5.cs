public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> map = new();
        if(s.Length != t.Length)
            return false;
        foreach(char ch in s){
            map[ch] = map.GetValueOrDefault(ch) + 1;
        }
        foreach(char ch in t){
            if(!map.TryGetValue(ch, out int count))
                return false;
            if(count==1)
                map.Remove(ch);
            else
                map[ch] = count-1;
        }
        return true;
    }
}
