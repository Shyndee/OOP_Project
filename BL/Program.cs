using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Program
    {

        static void Main(string[] args)
        {
            #region Testing Product
           /* ProductBL productBL = new ProductBL();
            #region testing create 
                 // testing create exception
                 Console.WriteLine("Create exeption");
                 productBL.CreateBL(new Product("Computer", 800, 0962318, 34));
                 Console.WriteLine();
                 productBL.CreateBL(new Product("Watch", 150, 7654321, 78));
                 Console.WriteLine();
                 Console.WriteLine("Printing list after adding watch");
                 productBL.PrintListBL();*//*
            #endregion
            #region Testing Retrieve
            ////both working
            ////testing retrieve found
            //Console.WriteLine("testing retrieve found\n");
            //Console.WriteLine(productBL.RetrieveBL(0962318));

            ////testing retrieve exception
            //Console.WriteLine();
            //Console.WriteLine("testing retrieve notfound");
            //Console.WriteLine(productBL.RetrieveBL(12345));

            #endregion
            #region Testing Retrieve All
            //List<Product> list = productBL.RetrieveAllBL();       
            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Testing Update
            //// both work perfectly
            ////testin update
            //Console.WriteLine("testing update found");
            //productBL.UpdateBL(new Entities.Product("Computer", 800, 0962318, 23));

            //Console.WriteLine("Printing list after update");
            //productBL.PrintListBL();
            //Console.WriteLine();
            ////testing update exception
            //Console.WriteLine("Testing update exception");
            //productBL.UpdateBL(new Entities.Product("name", 25, 12345, 34));
            #endregion
            #region Testing Delete
            //working
            ////testing delete found
            //Console.WriteLine("testing delete found\n");
            //productBL.DeleteBL(0962318);
            //productBL.PrintListBL();
            ////testing delete notfound
            //Console.WriteLine();
            ////testing delete exception
            //Console.WriteLine("testing delete notfound");
            //productBL.DeleteBL(12345);
            #endregion*/

            #endregion

            #region Testing Customer
            /*CustomerBL customerBL = new CustomerBL();

            #region testing create 
            //// testing create exception
            //Console.WriteLine("Create exeption");
            //customerBL.CreateBL(new Customer("Computer", 12345));
            //Console.WriteLine();

            //Console.WriteLine("Testing Create");
            //customerBL.CreateBL(new Customer("Jill", 7654321));
            //Console.WriteLine();
            //Console.WriteLine("Printing list after adding Jill");
            //customerBL.PrintListBL();
            #endregion
            #region Testing Retrieve
            ////both working
            ////testing retrieve found
            //Console.WriteLine("testing retrieve found\n");
            //Console.WriteLine(customerBL.RetrieveBL(12345));

            ////testing retrieve exception
            //Console.WriteLine();
            //Console.WriteLine("testing retrieve notfound");
            //Console.WriteLine(customerBL.RetrieveBL(0962318));

            #endregion
            #region Testing Retrieve All
            //List<Customer> list = customerBL.RetrieveAllBL();
            //foreach (Customer p in list)
            //{
            //    Console.WriteLine(p);
            //}//end Foreach

            #endregion
            #region Testing Update
            ////testing update
            //Console.WriteLine("testing update found");
            //customerBL.UpdateBL(new Entities.Customer("Shaindy", 12345));

            //Console.WriteLine("Printing list after update, changed Shyndee to Shaindy");
            //customerBL.PrintListBL();
            //Console.WriteLine();
            ////testing update exception
            //Console.WriteLine("Testing update exception");
            //customerBL.UpdateBL(new Entities.Customer("name", 25));
            #endregion
            #region Testing Delete

            ////testing delete found
            //Console.WriteLine("testing delete found\n");
            //customerBL.DeleteBL(12345);
            //customerBL.PrintListBL();
            ////testing delete notfound
            //Console.WriteLine();
            ////testing delete exception
            //Console.WriteLine("testing delete notfound");
            //customerBL.DeleteBL(1345);
            #endregion*/
            #endregion

            #region Testing Order
            OrderBL OrderBl = new OrderBL();
            // OrderBl.PrintListBL();
            #region testing create 
            //// testing create exception
            //Console.WriteLine("Create exeption");
            //OrderBl.CreateBL(new Entities.Order(12345678, 9786754, 32, 13.45));
            //Console.WriteLine();

            //Console.WriteLine("Testing Create");
            //OrderBl.CreateBL(new Entities.Order(13243546, 9786754, 32, 13.45));
            //Console.WriteLine();
            //Console.WriteLine("Printing list after adding order");
            //OrderBl.PrintListBL();


            #endregion
            #region Testing Retrieve
            ////both working
            ////testing retrieve found
            //Console.WriteLine("testing retrieve found\n");
            //Console.WriteLine(OrderBl.RetrieveBL(12345678));

            ////testing retrieve exception
            //Console.WriteLine();
            //Console.WriteLine("testing retrieve notfound");
            //Console.WriteLine(OrderBl.RetrieveBL(0962318));

            #endregion
            #region Testing Retrieve By customer
            ////both working
            ////testing retrieve found
            //Console.WriteLine("testing retrieve found\n");
            //List<Order> list = OrderBl.RetrieveByCustomerBL(34567890);
            //foreach (Order p in list)
            //{
            //    Console.WriteLine(p);
            //}//end Foreach
            ////testing retrieve exception
            //Console.WriteLine();
            //Console.WriteLine("testing retrieve notfound");
            //Console.WriteLine(OrderBl.RetrieveByCustomerBL(0962318));
            #endregion
            #region Testing Retrieve By Product
            ////both working
            ////testing retrieve found
            //Console.WriteLine("testing retrieve found\n");
            //List<Order> list = OrderBl.RetrieveByProductBL(98765432);
            //foreach (Order p in list)
            //{
            //    Console.WriteLine(p);
            //}//end Foreach
            ////testing retrieve exception
            //Console.WriteLine();
            //Console.WriteLine("testing retrieve notfound");
            //List<Order> list2 = OrderBl.RetrieveByProductBL(8425729);
            #endregion
            #region Testing Retrieve All
            //List<Order> list = OrderBl.RetrieveAllBL();
            //foreach (Order p in list)
            //{
            //    Console.WriteLine(p);
            //}//end Foreach

            #endregion
            #region Testing Update
            //testing update

            //Console.WriteLine("testing update found");
            //OrderBl.UpdateBL(2222222, 50, 98765432);

            //Console.WriteLine("Printing list after update, changed Shyndee to Shaindy");
            //OrderBl.PrintListBL();
            //Console.WriteLine();
            //testing update exception
            //Console.WriteLine("Testing update exception");
            //Console.WriteLine();
            //Console.WriteLine("Invalid order num");
            //OrderBl.UpdateBL(0000,634, 98765432);
            //Console.WriteLine("Invalid product num");
            //OrderBl.UpdateBL(5555555, 634, 634);
            #endregion
            #region Testing Delete

            ////testing delete found
            //Console.WriteLine("testing delete found\n");
            //OrderBl.DeleteBL(12345678);

            //OrderBl.PrintListBL();
            ////testing delete notfound
            //Console.WriteLine();

            ////testing delete exception
            //Console.WriteLine("testing delete notfound");
            //OrderBl.DeleteBL(12345);
            #endregion
            #endregion

        }//end main
    }//end class
}//end namespace
