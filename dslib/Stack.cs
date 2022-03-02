using System.Collections.Generic;

namespace dslib
{
    public class Stack
    {

        public List<object> Storage { get; set; } = new List<object>();

        public int Length 
        { 
            get
            {
                return Storage.Count;
            }
        }

        public void Push(object item)
        {
            Storage.Add(item);
        }
        public object Pop()
        {
            return null;
        }
    }
}

