﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc8_SearchAndInsert
{
    class Node
    {
        //creating Node
        public int data;
        public Node next;



        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}