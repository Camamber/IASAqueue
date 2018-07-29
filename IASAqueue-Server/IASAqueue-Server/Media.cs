using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IASAqueue_Server
{
    class Media
    {
        List<string> files;
        int current=0;
        bool played = true;
        public event EventHandler MediaUpdated;
             
        public Media()
        {
            files = new List<string>();
        }

        protected virtual void OnMediaUpdated(EventArgs e)
        {
            if (MediaUpdated != null)
                MediaUpdated(this, e);
        }

        public void Add(IEnumerable<string> items)
        {
            files.AddRange(items);
            OnMediaUpdated(new EventArgs());
        }
     
        public string Get()
        {
            return files[current];
        }

        public void Remove(int index)
        {
            files.RemoveAt(index);
            if (index < current)
                current--;
            OnMediaUpdated(new EventArgs());
        }

        public string[] MediaArr
        {
            get { return files.ToArray(); }
        }

        public int Current
        {
            get
            {
                return current;
            }

            set
            {
                if (value < files.Count)
                    current = value; 
                else
                    current = 0;
                OnMediaUpdated(new EventArgs());
            }
        }

        public bool isEmpty
        {
            get { return !(files.Count > 0); }
        }

        public bool Played
        {
            get
            {
                return played;
            }

            set
            {
                played = value;
                OnMediaUpdated(new EventArgs());
            }
        }
    }
}
