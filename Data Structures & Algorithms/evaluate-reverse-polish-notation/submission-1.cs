public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new();
        foreach(string str in tokens){
            if(str == "*" || str == "/" || str == "+" || str == "-"){
                int val1 = st.Pop();
                int val2 = st.Pop();
                if(str=="*"){
                    st.Push(val1*val2);
                }
                else if(str=="/"){
                    st.Push(val2/val1);
                }
                else if(str=="+"){
                    st.Push(val1+val2);
                }
                else{
                    st.Push(val2-val1);
                }
            }
            else{
                int val = int.Parse(str);
                st.Push(val);
            }
        }
        return st.Peek();
    }
}
