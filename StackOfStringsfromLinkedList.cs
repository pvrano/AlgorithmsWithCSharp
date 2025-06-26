using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWithCSharp
{
    public class StackOfStringsfromLinkedList
    {
        private LinkedListNode<string> first = null;
        private class LinkedListNode<T>
        {
            public string item;
            public LinkedListNode<T> next;
        }

        public bool isEmpty()
        {
            return first == null;

        }
        public void push(string item)
        {
            LinkedListNode<string> newNode = first;
            first = new LinkedListNode<string>();
            first.item = item;
            first.next = newNode;

        }

        public string pop()
        {
            string item = first.item;
            first = first.next;
            return item;
        }

    }
}
