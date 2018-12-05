using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestCycle {
    class Node<T> {
        private readonly T value;
        private readonly int index;
        private Connection<T> prev = null;

        public T Value { get { return value; } }
        public Connection<T> Prev { get { return prev; } set { prev = value; } }
        public Node<T> PrevNode { get { return prev.GetOther(this); } }
        public int Index { get { return index; } }

        public Node(T value, int index) {
            this.value = value;
            this.index = index;
        }
    }
}
