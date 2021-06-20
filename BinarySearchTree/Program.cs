using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> LefNode { get; set; }
        public Node<T> RightNode { get; set; }
    }

    public class Tree<T>
    {
        public Node<T> TopNode { get; set; }

        public void Add(params T[] values)
        {
            if (values ==null || !values.Any())
            {
                throw new ArgumentException("Please fill values Parameters!");
            }

            var _values = new List<T>(values);

            var middle = _values.OrderBy(v => v).Skip(_values.Count / 2).First();
            _values.Remove(middle);
            _values.Insert(0,middle);

            foreach (var value in values)
            {
                if (this.TopNode == null)
                {
                    TopNode = new Node<T>() {Value = value};
                    continue;
                }

                var current = this.TopNode;
                var added = false;

                do
                {
                    if (Comparer<T>.Default.Compare(value, current.Value) == -1 || Comparer<T>.Default.Compare(value, current.Value) == 0)
                    {
                        if (current.LefNode == null)
                        {
                            current.LefNode = new Node<T>() {Value = value};
                            added = true;
                        }
                        else
                        {
                            current = current.LefNode;
                        }
                    }

                    else
                    {
                        if (current.RightNode==null)
                        {
                            current.RightNode = new Node<T>() {Value = value};
                            added=true;
                        }
                        else
                        {
                            current = current.RightNode;
                        }
                    }

                } while (!added);

            }


        }
    }
}
