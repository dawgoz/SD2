using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2
{
    public class Deque
    {
        List<string> deq = new List<string>();
        public int size { get; set; }
        public int deqSize { get; set; }
        public bool IsEmpty()
        {
            return deq.Count != 0 ? false : true;
        }

       /* public string pollFirst()
        {
            string returnable = deq.ElementAt(0);
            deq.Remove(deq.ElementAt(0));
            return deq.ElementAt(0);
        }*/

        public bool IsFull(int size)
        {
            return deq.Count == size ? true : false; 
        }
        public void InsertLast(string arg)
        {
            deq.Add(arg);
        }

        public void InsertFront(string arg)
        {
            deq.Insert(0, arg);
        }

        public void DeleteFront()
        {
            deq.RemoveAt(0);
        }

        public void DeleteLast()
        {
            deq.RemoveAt(deq.Count - 1);
        }

        public string GetFront()
        {
             return deq.ElementAt(0);
        }

        public string GetRear()
        {
            if (deq.ElementAt(deq.Count - 1) == null) return "null";
            else return deq.ElementAt(deq.Count-1);
        }

        public int GetSize(int size)
        {
            return size;
        }

        public string Read()
        {
            string result ="";
            foreach (var item in deq)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
