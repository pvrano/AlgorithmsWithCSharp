using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWithCSharp.DataStructureImplementations
{
    public class LinkedQueueOfStrings
    {
        //creating a custom Node for mimicing the linkedlist
        private Node first, last;
        private class Node
        {
            public string itemToBeInserted;
            public Node next;
            
        }

        //method to check if the queue is empty
        public bool isEmpty()
        {
            return first == null;
        }

        public void enqueue(string itemToBeInserted)
        {
            Node oldLast = last;
            last = new Node();
            last.itemToBeInserted = itemToBeInserted;
            last.next = null;
            if (isEmpty())
            {
                first = last;
            }
            else
            {
                oldLast = first;
            }
        }

        public string Dequeue()
        {
            string item = first.itemToBeInserted;
            first = first.next;
            if (isEmpty())
            {
                last = null;
            }
            return item;
        }

    }
}
