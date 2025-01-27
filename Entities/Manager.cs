using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Manager : Employee
    {
        //ctor
        public Manager(string name, int id) : base(name, id)
        {
        }//end ctor

        //prop
        public int Vetek { get; set; }
    }//end class
}
