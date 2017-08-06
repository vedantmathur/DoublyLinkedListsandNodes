using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddToEnd(55);
            dll.AddToEnd(22);
            dll.AddToEnd(11);

            Console.WriteLine(dll.ToString());
            Console.ReadKey();

        }
    }
}
