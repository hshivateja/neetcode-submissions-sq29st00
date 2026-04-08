public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        int len = temperatures.Length;
        for(int i=0;i<len;i++){
            for(int j= i+1;j<len;j++){
                if(temperatures[j]>temperatures[i]){
                    res[i] = j-i;
                    break;
                }
            }
        }
        return res;
    }
}
