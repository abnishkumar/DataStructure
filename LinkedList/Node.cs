using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node : System.Object
    {
        public Node Next;
        public string Data;

        public Node(string data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return "Node("+this.Data + ")=>";
        }
    }

    public class DNode
    {
        public DNode Prev;
        public DNode Next;
        public string Data;

        public DNode(string data)
        {
            this.Data = data;
        }
    }
}
