public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> set = new();
       foreach(int num in nums){
            set.Add(num);
       }
       int longest = 0;
       foreach(int num in set){
            if(!set.Contains(num-1)){
                int current = num;
                int length = 1;
                while(set.Contains(current+length)){
                    length++;
                }
                longest = Math.Max(length,longest);
            }
       }
       return longest;
    }
}
