public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0 || nums.Length==1)
            return nums.Length;
        Array.Sort(nums);
        int currSequence = 1;
        int max = 1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[i-1]) 
                continue;
            if(nums[i]-nums[i-1]==1){
                currSequence++;
            }
            else{
                currSequence = 1;
            }
            max = Math.Max(currSequence,max);
        }
        return max;
    }
}