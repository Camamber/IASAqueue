using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class Queue
    {
        List<int> queue;
        int last;

        public Queue()
        {
            queue = new List<int>();
            last = 0;
        }

        public int Add()
        {
            last++;
            queue.Add(last);
            return last;
        }

        public int Next()
        {
            int current = 0;
            if (queue.Count > 0)
            {
                current = queue[0];
                queue.RemoveAt(0);
                
            }
            return current;
        }      
    }
}
