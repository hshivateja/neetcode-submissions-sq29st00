public class Solution {
    public int Trap(int[] height) {
        int water = 0;
        int n = height.Length;
        int[] maxLeft = new int[n];
        int[] maxRight = new int[n];
        maxLeft[0] = height[0];
        for(int i=1;i<n;i++){
            maxLeft[i] = Math.Max(maxLeft[i-1],height[i]);
        }
        maxRight[n-1] = height[n-1];
        for(int i=n-2;i>=0;i--){
            maxRight[i] = Math.Max(maxRight[i+1],height[i]);
        }
        for(int i=0;i<n;i++){
            water += Math.Min(maxLeft[i],maxRight[i]) - height[i];
        }
        return water;
    }
}
