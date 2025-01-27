using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
    public class CreditCard
    {
        public int CardNum { get; set; }
        public string CardHolder { get; set; }
        //public double Expiration { get; set; }
        public DateTime Expiration { get; set; }
        public int CVV { get; set; }
        
        
        public CreditCard(int cardNum, string cardHolder, /*double experationDate,*/DateTime experationDate, int cvv)
        {
            CardNum = cardNum;
            CardHolder = cardHolder;
            Expiration = experationDate;
            CVV = cvv;
        }//end ctor

        public override string ToString()
        {
            return "Name: " + CardHolder + "\t" + "Card Number: " + CardNum + "\t" + "Expiration: " + Expiration.Month + "/" + Expiration.Year + "\t" + "CVV: " + CVV + "\t";
        }//end to string
    }//end class
}//end namespace
