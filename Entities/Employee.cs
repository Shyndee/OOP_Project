using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person
    {
        //needs this to solve red squigles under Emloyee
        public Employee(string name, int id) : base(name, id)
        {
        }//end ctor

        //prop
        public int Salary { get; set; }
    }//end class
}//end namespace
