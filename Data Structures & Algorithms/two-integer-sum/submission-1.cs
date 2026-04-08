public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> res = new();
        for(int i=0;i<nums.Length;i++){
            if(res.ContainsKey(target-nums[i]))
                return new int[] {res[target-nums[i]],i};
            res.Add(nums[i],i);
        }
        return new int[]{-1,-1};
    }
}
