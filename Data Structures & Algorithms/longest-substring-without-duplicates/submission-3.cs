public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int len = s.Length;
        int left = 0;
        int right = 0;
        int maxLen = 0;
        Dictionary<char,int> hashMap = new();
        while(right<len){
            if(hashMap.ContainsKey(s[right]) && hashMap[s[right]]>=left){
                left = hashMap[s[right]]+1;
            }
            hashMap[s[right]] = right;
            maxLen = Math.Max(maxLen,right-left+1);
            right++;
        }
        return maxLen;
    }
}
