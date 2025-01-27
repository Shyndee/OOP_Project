using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerAlreadyExists : Exception
    {
        public CustomerAlreadyExists() : base("Sorry :(, this cutomer already exists")
        {

        }//ctor

    }//end class
}//end namespace
