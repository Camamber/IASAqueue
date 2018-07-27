using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace IASAqueue_Server
{
    class Queue
    {
        List<int> queue;
        Stopwatch timer;
        List<TimeSpan> timing;
        private int last;

        public Queue()
        {
            queue = new List<int>();
            last = 0;
            timer = new Stopwatch();
            timing = new List<TimeSpan>();
        }

        public int Add()
        {
            last++;
            queue.Add(last);
            return last;
        }

        public int Last
        {
            get { return last; }
        }

        public int Length
        {
            get { return queue.Count; }
        }

        public int Next()
        {
            timing.Add(timer.Elapsed);
            timer.Restart();
            int current = 0;
            if (queue.Count > 0)
            {
                current = queue[0];
                queue.RemoveAt(0);

            }
            return current;
        }

        public int Skip(int num)
        {
            timer.Restart();
            if (queue.Count >= 16)
                queue.Insert(15, num);
            else
                queue.Add(num);
            return Next();
        }

        public string Predict(int count)
        {
            int max = queue.Count >= count ? count : queue.Count;
            string prediction = "";
            for (int i = 0; i < max; i++)
                prediction += queue[i] + " ";
            return prediction;
        }

        public TimeSpan Average()
        {
            long avr = 0;
            if (timing.Count > 0)
            {
                foreach (TimeSpan dt in timing)
                    avr += dt.Ticks;
                avr = avr / timing.Count;
            }
            return new TimeSpan(avr);

        }

        public void Serialize(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                byte[] data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new SerializedQueue { Queue = queue, Last = last }));
                fs.Write(data, 0, data.Length);
            }
        }

        public void Deserialize(string file)
        {
            SerializedQueue restore = JsonConvert.DeserializeObject<SerializedQueue>(File.ReadAllText(file));
            this.queue = restore.Queue;
            this.last = restore.Last;
        }
    }

    public class SerializedQueue
    {
        public List<int> Queue { get; set; }
        public int Last { get; set; }
    }
}
