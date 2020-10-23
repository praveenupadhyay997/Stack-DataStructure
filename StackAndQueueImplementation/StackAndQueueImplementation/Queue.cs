// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StackAndQueueImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Queue
    {
        // Creating the head of the Queue
        Node head;
        /// <summary>
        /// UC3- Function implementing the enquque process to the queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            // Creating the node of the queue
            Node newNode = new Node(value);
            // If the head is null - Assigning the head to the new node
            // Else finding the end of the queue to insert the new Node
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                //Creating a temporary queue
                Node temp = this.head;
                //Iterating till we find the head of the node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                //Assigning the new node to the end of the queue
                temp.next = newNode;
            }
            Console.WriteLine("Inserted into the Queue =  " + newNode.value);
        }
        /// <summary>
        /// Implementing the Display functionality to the Queue
        /// </summary>
        public void Display()
        {
            // Creating a temporary node
            Node temp = this.head;
            // Checking the end condition if the queue is Empty
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty. Nothing to Display...");
                return;
            }
            else
            {
                // Traversing till the head of the queue
                // Displaying the element in the queue and then incrementing the position
                while (temp != null)
                {
                    Console.Write(temp.value + "  ");
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// UC4- Implementing the functionality of Dequque for the Queue Operations
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            // Checking the end Condition of the queue, if empty then return NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return 0;
            }
            // Shorting the head of the node using a temporary Node
            // Storing the head pointer to the next node pointer
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("\nElement to be deleted from the queue = {0}", temp.value);
            return temp.value;
        }
    }
}
