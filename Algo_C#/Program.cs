using System;
using System.Collections.Generic;

namespace algo_C_
{
    public class MinStack 
    {
        public List<int> stack;
        public List<int> minStack;
        public MinStack() 
        {
            stack = new List<int>();
            minStack = new List<int>();
        }
        
        public void Push(int val) 
        {
            stack.Add(val);
            if (minStack.Count == 0 || stack[minStack[minStack.Count - 1]] >= val)
            {
                minStack.Add(stack.Count - 1);
            }
        }
        
        public void Pop() 
        {
            if (minStack[minStack.Count - 1] == stack.Count - 1)
            {
                minStack.RemoveAt(minStack.Count - 1);
            }
            stack.RemoveAt(stack.Count - 1);
        }
        
        public int Top() 
        {
            return stack[stack.Count - 1];
        }
        
        public int GetMin() 
        {
            return stack[minStack.Count - 1];
        }
    }
}
