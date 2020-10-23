using System;

namespace StackAndQueueImplementation
{
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
        }
    }
}
