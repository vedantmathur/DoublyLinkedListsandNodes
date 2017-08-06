using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T>
    {
        DoublyLinkedNode<T> head;
        DoublyLinkedNode<T> tail;

        public DoublyLinkedList()
        {
            //head = new DoublyLinkedNode<T>();
            //tail = new DoublyLinkedNode<T>();
        }

        public void AddToEnd(T value)
        {
            if(Count() == 0)
            {
                head = new DoublyLinkedNode<T>(value);
                tail = new DoublyLinkedNode<T>(value, previous: head);
                head.Next = tail;
                return;
            }
            if(Count() == 2)
            {
                tail = new DoublyLinkedNode<T>(value, head);
                return;
            }

            DoublyLinkedNode<T> nodeToSee = tail.Previous;
            nodeToSee.Next = new DoublyLinkedNode<T>(value, nodeToSee);
        }

        public void AddToFront(T value)
        {
            DoublyLinkedNode<T> tempNode = new DoublyLinkedNode<T>(value, null, head);
            head = tempNode;
        }

        public void AddAt(int position, T value)
        {
            DoublyLinkedNode<T> nodeToSee = head;
            int count = 0;
            while (count != position)
            {
                nodeToSee = nodeToSee.Next;
                count++;
            }
            DoublyLinkedNode<T> tempNode = new DoublyLinkedNode<T>(value, nodeToSee.Previous, nodeToSee);
        }

        public void RemoveFromFront()
        {
            head.Next.Previous = head.Previous;
            head = head.Next;
        }

        public void RemoveFromEnd()
        {
            DoublyLinkedNode<T> nodeToSee = tail.Previous;
            tail = tail.Previous;
            tail.Next = null;
        }

        public bool RemoveAt(int position)
        {
            if(position == 0)
            {
                RemoveFromFront();
                return true;
            }
            else if (position == Count())
            {
                RemoveFromEnd();
                return true;
            }
            else if (position > Count())
            {
                return false;
            }
            else
            {
                DoublyLinkedNode<T> nodeToSee = head;
                int nodeAt = 0;
                while(nodeAt < position)
                {
                    nodeToSee = nodeToSee.Next;
                    nodeAt++;
                }
                nodeToSee.Next.Previous = nodeToSee.Previous;
                nodeToSee.Previous.Next = nodeToSee.Next;
                return true;
            }
        }

        public bool IsEmpty()
        {
            if(head != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string str = "";
            DoublyLinkedNode<T> nodeToSee = head;
            while(nodeToSee != null && nodeToSee != tail)
            {
                str += nodeToSee.Value;
                nodeToSee = nodeToSee.Next;
            }
            str += tail.Value;
            return str;
        }

        public int Count()
        {
            int count = 0;
            DoublyLinkedNode<T> nodeToSee = head;
            while (nodeToSee != null && nodeToSee != tail)
            {
                count++;
                nodeToSee = nodeToSee.Next;
            }
            return count;
        }

        /*
         * void	AddToEnd(T value)	Add a node to the end of the list

           void	AddToFront(T value)	Add a node to the front of the list
           
           void	AddAt(int position, T value)	Add a node to a random position in the list
           
           bool	RemoveFromFront()	Remove a node from the front of the list
           
           bool	RemoveFromEnd()	Remove a node from the end of the list
           
           bool	RemoveAt(int position)	Remove a node at the given position
           
           bool	IsEmpty()	Determine if list is empty
           
           string ToString()	Return the values of the nodes
           
           int	Count	Return the number of nodes in the list
         *
         */
    }
}
