using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperation
{
    class Node
    {
        //creating Node
        public int data;
        public Node next;



#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Node(int d)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            data = d;
            next = null;
        }
    }
}