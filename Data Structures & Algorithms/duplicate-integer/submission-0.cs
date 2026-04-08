public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> res = new();
        foreach(int num in nums){
            if(res.Contains(num))
                return true;
            res.Add(num);
        }
        return false;
    }
}