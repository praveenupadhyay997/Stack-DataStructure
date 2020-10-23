using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueImplementation
{
    /// <summary>
    /// Defining the most basic unit of the data structure
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value string the data passed to the node
        /// </summary>
        public int value;
        /// <summary>
        /// Next storing either null for the head 
        /// or the next node reference for element in top the stack or in lines to queue
        /// </summary>
        public Node next;
        /// <summary>
        /// Constructor initialising the value of the node
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }
}
