public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new();
        foreach(char ch in s){
            if(ch=='[' || ch == '{' || ch == '(')
                st.Push(ch);
            else{
                if(st.Count==0)
                    return false;
                if(ch==']' && st.Peek()!='[')
                    return false;
                if(ch=='}' && st.Peek()!='{')
                    return false;
                if(ch==')' && st.Peek()!='(')
                    return false;
                st.Pop();
            }
        }
        return st.Count==0;
    }
}
