public class Solution {

    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<(int,int)> st = new();
        for(int i=0;i<temperatures.Length;i++){
            while(st.Count>0 && temperatures[i]>st.Peek().Item1){
                int index = st.Peek().Item2;
                res[index] = i - index;
                st.Pop();
            }
            st.Push((temperatures[i],i));
        }
        return res;
    }
}