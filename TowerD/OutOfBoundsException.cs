using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerD
{
    public class OutOfBoundsException : System.Exception
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
