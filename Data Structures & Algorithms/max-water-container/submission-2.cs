public class Solution {
    public int MaxArea(int[] heights) {
        int maxarea = 0;
        int left = 0;
        int right = heights.Length-1;
        while(left<right){
            maxarea = Math.Max(maxarea,(right-left) * Math.Min(heights[left],heights[right]));
            if(heights[left]<heights[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxarea;
    }
}
