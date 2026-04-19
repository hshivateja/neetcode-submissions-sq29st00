public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minSoFar = int.MaxValue;
        foreach(int price in prices){
            minSoFar = Math.Min(minSoFar,price);
            maxProfit = Math.Max(price-minSoFar,maxProfit);
        }
        return maxProfit;
    }
}
