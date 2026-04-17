public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;

        int[] left = new int[n];
        int[] right = new int[n];
        int maxleft = 0;
        int maxright = 0;
        for(int i=0;i<height.Length;i++){
            left[i] = maxleft;
            maxleft = Math.Max(height[i],maxleft);
        }

        for(int i=height.Length-1;i>=0;i--){
            right[i] = maxright;
            maxright = Math.Max(height[i],maxright);
        }
        int sum = 0;

        for(int i=0;i<height.Length;i++){
            int val =  Math.Min(left[i],right[i]) - height[i];
            if(val>0)
             sum += val;
        }
        return sum;
    }
}
