using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsWithCSharp.DataStructureImplementations
{
    public class StackOfStringsfromLinkedList
    {
        private Node first = null;
        private class Node
        {
            public string item;
            public Node next;
        }

        public bool isEmpty()
        {
            return first == null;

        }
        public void push(string itemToBeInserted)
        {
            Node newNode = first;
            first = new Node();
            first.item = itemToBeInserted;
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
