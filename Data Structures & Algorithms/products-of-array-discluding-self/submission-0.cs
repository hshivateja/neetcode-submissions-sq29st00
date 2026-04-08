public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int[] pref = new int[n];
        int[] suffix = new int[n];
        pref[0] = 1;
        suffix[n-1] = 1;
        for(int i=1;i<n;i++){
            pref[i] = nums[i-1] * pref[i-1];
        }
        for(int i=n-2;i>=0;i--){
            suffix[i] = nums[i+1] * suffix[i+1];
        }
        for(int i=0;i<n;i++){
            result[i] = pref[i] * suffix[i];
        }
        return result;
    }
}
