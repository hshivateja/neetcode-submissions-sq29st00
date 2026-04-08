public class Solution {
    public bool IsPalindrome(string s) {
        string str = s.ToLower();
        int left = 0, right = str.Length-1;
        while(left<right){
            while(left<right && !char.IsLetterOrDigit(str[left]))
                left++;
            while(left<right && !char.IsLetterOrDigit(str[right]))
                right--;
            if(str[left]!=str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
