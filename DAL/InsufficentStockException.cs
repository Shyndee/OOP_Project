using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InsufficentStockException : Exception
    {
        public InsufficentStockException() : base("Sorry! There are not enough products in stock.")
        {

        }//end ctor
    }
}
