using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }



    public class Node
    {
        public Node(Node prev, Node next, object obj)
        {
            Prev = prev;
            Next = next;
            Object = obj;
        }

        public Node Prev { get; set; }
        public Node Next { get; set; }
        public object Object { get; set; }

       
    }

    public class LinkedList
    {
        private int iCount = 1;
        private int iCurrent = 1;
        private Node nCurrent;

        public LinkedList(object obj)
        {
            nCurrent = new Node(null, null, obj);
            nCurrent.Next = null;
            nCurrent.Prev = null;
        }

        public void AddNode(object obj)
        {
            if (nCurrent.Next == null)
            {
                nCurrent = nCurrent.Next = new Node(nCurrent, null, obj);
            }
            else
            {
                nCurrent = nCurrent.Next = new Node(nCurrent, nCurrent.Next, obj);
            }
            iCount++;
            iCurrent++;
        }

        public void ToNext()
        {
           
            if (nCurrent.Next == null)
            {
                throw new Exception("There is no next node!");
            }
            else 
            {
                nCurrent = nCurrent.Next;
                iCurrent++;
            }
        }

        public void ToPrevious()
        {
           
            if (nCurrent.Prev == null)
            {
                throw new Exception("There is no previous node!");
            }
            else
            {
                nCurrent = nCurrent.Prev;
                iCurrent--;
            }
        }

        public void GoTo(int index)
        {
            if (iCurrent < index)
            {
                ToNext();
            }
            else if (iCurrent > index)
            {
                ToPrevious();
            }
        }

    }
}
