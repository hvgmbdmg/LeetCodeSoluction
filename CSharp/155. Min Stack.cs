public class MinStack {

    /** initialize your data structure here. */
    
    //private 
    private List<int> myStack;
    private int count;
    public MinStack() {
        myStack = new List<int>();
        count = 0;
    }
    
    public void Push(int x) {
        myStack.Add(x);
        count ++;
    }
    
    public void Pop() {
        myStack.RemoveAt(count-1);
        count--;
    }
    
    public int Top() {
        return myStack[count-1];
    }
    
    public int GetMin() {
        if( count==0 )
            return -1;
        else
            return myStack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */