using System;
namespace c_net_stack
{
    public class DelayneList
    {
        int count = 0;

        public int Size()
        {
            return count;
            
        }

        public void add(int v)
        {
            count++;
        }
    }
}
