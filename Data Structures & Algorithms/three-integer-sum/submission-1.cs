public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new();
        Array.Sort(nums);
        int i =0;
        while(i<nums.Length-2){
            if(i!=0 && nums[i-1]==nums[i]){
                i++;
                continue;
            }
            int val = nums[i];
            int left = i+1;
            int right = nums.Length-1;
            while(left<right){
                int sum = val + nums[left] + nums[right];
                if(sum>0){
                    right--;
                }
                else if(sum<0){
                    left++;
                }
                else{
                    res.Add(new List<int>() {val, nums[left], nums[right]});
                    left++;
                    while(left<right && nums[left-1]==nums[left])
                        left++;
                }
            }
            i++;
        }
        return res;
    }
}
