using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    public class Node
    {
        public Node Next {  get; set; }
        public Houses House { get; set; }

        public Node(Houses house) 
        {
            Next = null;
            House = house;
        
        }
    }
}
