using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDoesNotExist : Exception
    {
        public CustomerDoesNotExist() : base("Sorry :(, this customer does not exist ")
        {
        }//end ctor
    }//end class
}//end namespace
