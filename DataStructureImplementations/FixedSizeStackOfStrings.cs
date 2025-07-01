using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWithCSharp.DataStructureImplementations
{
    public class FixedSizeStackOfStrings
    {
        private string[] s;
        private int N = 0;

        public FixedSizeStackOfStrings(int capacity)
        {
            s = new string[capacity];
        }
        public bool isEmpty()
        {
            return N == 0;
        }
        public void push(string item)
        {
            s[N++] = item;
        }

        public string pop()
        {
            string item = s[--N];
            s[N] = null;
            return item;

        }
    }
}
