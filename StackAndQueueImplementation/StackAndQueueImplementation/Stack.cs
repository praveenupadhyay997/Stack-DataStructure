// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StackAndQueueImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Stack
    {
        // Declaring the top node of the stack
        public Node top;
        /// <summary>
        /// Constructor declaring the top of the stack to contain null as reference
        /// </summary>
        public Stack()
        {
            this.top = null;
        }
        /// <summary>
        /// Creating the function to push the node to the top of the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            //Creating a node with the value passed to Push Function
            Node node = new Node(value);
           // Initialising the next of new node to top which is null
            if (this.top == null)
            {
                node.next = null;
            }
            // If the stack is empty then pushing the incoming node to bottom of the stack
            else
            {
                node.next = this.top;
            }
            // Initialising the top to the new node thence creating a link between top and incoming node
            this.top = node;
            Console.WriteLine("Inserting {0} in the stack...", value);
        }
        /// <summary>
        /// Display the stack element by traversing the stack
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.Write(temp.value + "  ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// UC2- Peek from the top of the stack and displaying the element
        /// </summary>
        public void Peek()
        {
            //Returning the end condition when Stack is empty
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty....");
                return;
            }
            //Displaying the value in the top of the stack
            Console.WriteLine("\nValue in the top of the stack is = "+this.top.value);
        }
        /// <summary>
        /// Popping from the Stack till the stack is empty
        /// </summary>
        public void Pop()
        {
            // Checking for the end condition till the Stack is Empty
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty. No Further deletion possible in the Stack...");
                return;
            }
            Console.WriteLine("Value to be popped is ="+ this.top.value);
            //Popping the node by shorting the node 
            //Shorting the node by restoring the next node reference to current node
            this.top = this.top.next;
        }
        /// <summary>
        /// Popping till the Stack is empty and Peeking from the top element in the Stack
        /// </summary>
        public void IsEmpty()
        {
            // Iterating till the entire stack is empty
            while(this.top != null)
            {
                //Denoting the top element of the Stack
                Peek();
                //Popping the element from the Stack
                Pop();
            }
        }
    }
}
