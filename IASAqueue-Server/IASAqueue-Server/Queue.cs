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
        public event EventHandler QueueUpdated;        

        public Queue()
        {
            queue = new List<int>();
            last = 0;
            timer = new Stopwatch();
            timing = new List<TimeSpan>();
        }

        protected virtual void OnQueueUpdated(EventArgs e)
        {
            if (QueueUpdated != null)
                QueueUpdated(this, e);
        }

        public int Add()
        {
            last++;
            queue.Add(last);
            OnQueueUpdated(new EventArgs());
            return last;
        }
        public int Add(int number)
        {
            queue.Add(number);
            OnQueueUpdated(new EventArgs());
            return last;
        }

        public void Remove(int number)
        {
            queue.Remove(number);
            OnQueueUpdated(new EventArgs());
        }

        public int Move(int number, int offset)
        {
            int index = queue.IndexOf(number);
            if (index + offset < queue.Count&& index + offset>=0)
            {
                index += offset;
                queue.Remove(number);
                queue.Insert(index, number);

            }
            OnQueueUpdated(new EventArgs());
            return index;
        }
       

        public int Last
        {
            get { return last; }
            set { last = value; }
        }

        public int[] QueueArr
        {
            get { return queue.ToArray(); }
        }

        public int Length
        {
            get { return queue.Count; }
        }

        public bool isContain(int number)
        {
            return queue.Contains(number);
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
            OnQueueUpdated(new EventArgs());
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

        public void Reset()
        {
            queue.Clear();
            timing.Clear();
            last = 0;
            OnQueueUpdated(new EventArgs());
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
            OnQueueUpdated(new EventArgs());
        }
    }

    public class SerializedQueue
    {
        public List<int> Queue { get; set; }
        public int Last { get; set; }
    }
}
