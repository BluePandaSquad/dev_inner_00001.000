using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPRJ
{
    class TestHelper
    {
        private int __countPrivate = 0;
        public int Count;
        static void Main(string[] args)
        {
        }

        //description: check the equality of two objects
        //parameters:
        //      a (I) - object: object one
        //      b (I) - object: object two
        //assumed variables: none
        //returns: true - if equals, false - othersie

        public bool ObjEquals(object a, object b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            return a == b;
        }
    }
}



/*
test cases:
    a - null b - null
    a =int b=in

*/