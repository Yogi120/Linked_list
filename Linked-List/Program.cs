using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddFirst(20);
            list.AddFirst(30);
            list.AddFirst(67);

            list.AddLast(45);
            list.AddLast(34);
            list.AddLast(87);

            Console.WriteLine("Before deleting");
            list.PrintList();

            Console.WriteLine("After deleting First");
            list.DeleteFirst();
            list.PrintList();

            Console.WriteLine("After Deleting last Node");
            list.DeleteLast();
            list.PrintList();
        }
    }
}
