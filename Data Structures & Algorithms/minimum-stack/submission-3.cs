public class MinStack {
    Stack<(int,int)> st;
    int minValue = int.MaxValue;
    public MinStack() {
        st = new();
    }
    
    public void Push(int val) {
        if(st.Count==0){
            st.Push((val,val));
        }
        else{
            st.Push((val,Math.Min(st.Peek().Item2,val)));
        }
    }
    
    public void Pop() {
        st.Pop();

    }
    
    public int Top() {
        return st.Peek().Item1;
    }
    
    public int GetMin() {
        return st.Peek().Item2;
    }
}
