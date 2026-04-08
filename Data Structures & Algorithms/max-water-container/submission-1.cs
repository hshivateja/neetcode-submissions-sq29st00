public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = int.MinValue;
        int left = 0;
        int right = heights.Length-1;
        while(left<right){
            maxArea = Math.Max(maxArea,(right-left)*Math.Min(heights[left],heights[right]));
            if(heights[left]>heights[right])
                right--;
            else
                left++;
        }
        return maxArea;
    }
}
