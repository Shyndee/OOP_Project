using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderAlreadyExists : Exception
    {
        public OrderAlreadyExists() : base("Sorry :(, this order already exists")
        {

        }//ctor

    }//end class
}
