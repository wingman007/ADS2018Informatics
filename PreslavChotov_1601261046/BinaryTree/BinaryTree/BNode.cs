using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BNode
    {
        public int Value { get; set; }
        public BNode Left { get; set; }
        public BNode Right { get; set; }

        public BNode(int value)
        {
            

            this.Value = value;
        }
    }
}
