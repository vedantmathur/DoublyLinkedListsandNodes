using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next { get; set; }
        public DoublyLinkedNode<T> Previous { get; set; }

        public T Value { get; set; }

        public DoublyLinkedNode()
        {
            Next = null;
            Previous = null;
        }
        public DoublyLinkedNode(T value, DoublyLinkedNode<T> previous = null, DoublyLinkedNode<T> next = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

    }
}
