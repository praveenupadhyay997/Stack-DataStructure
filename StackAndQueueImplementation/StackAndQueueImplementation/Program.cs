// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StackAndQueueImplementation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to the Stack implementation");
            Console.WriteLine("===================================");
            // Creating a stack and then pushing elements to it
            Stack newStack = new Stack();
            newStack.Push(70);
            newStack.Push(30);
            newStack.Push(56);
            //Displaying the stack
            newStack.Display();
            //Peek and Pop from the Stack till the Stack is Empty
            newStack.IsEmpty();

            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to the Stack implementation");
            Console.WriteLine("===================================");
            //Creating a queue and then Enqueue the node to the Queue
            Queue newQueue = new Queue();
            newQueue.Enqueue(56);
            newQueue.Enqueue(30);
            newQueue.Enqueue(70);
            //Displaying the Queue
            newQueue.Display();
        }
    }
}
