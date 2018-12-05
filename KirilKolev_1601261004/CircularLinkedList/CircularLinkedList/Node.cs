using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedList
{
    public sealed class Node<T>
    {
        public T Value { get; private set; }

        public Node<T> Next { get; internal set; }

        public Node<T> Previous { get; internal set; }

        internal Node( T item )
        {
            this.Value =    item;
        }
    }
}
