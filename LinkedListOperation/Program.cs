﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseCase 1
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertBetween(2, 30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Appending*****");
            obj.Display();
        }
    }
}