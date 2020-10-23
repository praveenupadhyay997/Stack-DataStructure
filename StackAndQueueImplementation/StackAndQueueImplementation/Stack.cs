using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
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

    }
}
