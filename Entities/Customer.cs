using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Person
    {
        public CreditCard CreditC;//should really be private
        //public CreditCard CD { get; set; }

        //ctor
        public Customer(string name, int id, CreditCard CreditCardCTOR) : base(name, id)
        {
            CreditC = CreditCardCTOR;
             
        }//end ctor

        public override string ToString()
        {
            return "Name: " + Name + "\t" + "Id Num: " + ID /*+ CreditC.ToString()*/;
        }//end tostring

    }//end class
}//end namespace
