using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class CustomerDAL
    {
        static List<Customer> list = new List<Customer>();
        static bool loaded = false; //added by ERP
        #region CTOR
        //ctor
        public CustomerDAL()
        {
            InitializeList();
        }//end ctor
        #endregion
        #region Intialize List
        public static void InitializeList()
        {
            if (loaded == false)
            {
                //StreamReader reader1 = new StreamReader(@"C:\Users\User\source\repos\OOP C# Programming 2\OOP_Project_stuff\OOP_PROJECT\DAL\bin\Debug\custemorDAL.txt");
                StreamReader reader1 = new StreamReader(@"..\..\..\..\DAL\bin\Debug\custemorDAL.txt");

                using (reader1)
                {
                    string line = reader1.ReadLine();

                    //Console.WriteLine("Read line from file");
                    while (line != null)
                    {
                        string name = line;

                        int IDnumber = int.Parse(reader1.ReadLine());
                       
                        CreditCard creditCard = new CreditCard(int.Parse(reader1.ReadLine()), reader1.ReadLine(), DateTime.Parse(reader1.ReadLine()),/*double.Parse(reader1.ReadLine()),*/ int.Parse(reader1.ReadLine()));

                        Customer cust = new Customer(name, IDnumber, creditCard);

                        line = reader1.ReadLine();
                        list.Add(cust);

                    }//end while
                    loaded = true;
                }//end using
            }//end if
        }//end Initialize list
        #endregion
        #region Create
        //Crud
        public void Create(Customer c)
        {
            Customer toUse = new Customer(c.Name, c.ID, c.CreditC);
            //try
            //{
            bool flag = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (toUse.ID.Equals(list[i].ID))
                {
                    flag = true;
                    break;
                }//end if

            }//end for

            if (flag == false)
            {
                list.Add(toUse);
            }//end if
            else
            {
                throw new CustomerAlreadyExists();
            }//end else

            //}//end try 

            //catch (CustomerAlreadyExists cae)
            //{
            //    Console.WriteLine(cae.Message);
            //}//end catch

        }//End Create
        #endregion         
        #region Retrieve
        //cRud  
        public Customer Retrieve(int IDnum)
        //Finds the object, returns a copy
        {
            //making a copy of my list
            List<Customer> newCustomerList = list.ConvertAll(customer => new Customer(customer.Name, customer.ID, customer.CreditC));
            bool flag = false;

            //try
            //{
            for (int i = 0; i < newCustomerList.Count; i++)
            {
                if (newCustomerList[i].ID.Equals(IDnum))
                {
                    flag = true;
                    return newCustomerList[i];
                }//end if

            }//end for
            if (flag == false)
            {
                throw new CustomerDoesNotExist();
            }//end if
            //}//end try
            //catch (CustomerDoesNotExist dne)
            //{
            //    Console.WriteLine(dne.Message);
            //}//end catch

            return null;

        }//end method

        #endregion
        #region Retrieve All
        public List<Customer> RetrieveAll()
        {
            //making a copy of my list
            List<Customer> newCustomerList = list.ConvertAll(customer => new Customer(customer.Name, customer.ID, customer.CreditC));
            ////for testing
            //PrintList();
            return newCustomerList;

        }//end method
        #endregion
        #region Update
        //crUd
        //update the list (one property like name)
        public void Update(Customer customer)
        //will receive a product, find a product with the same number in the list, deletes the old one, and places the one i received in the list
        {
            Customer toUse = new Customer(customer.Name, customer.ID, customer.CreditC);

            //try
            //{
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (toUse.ID.Equals(list[i].ID))
                {
                    flag = true;
                    list[i] = toUse;
                }//end if
            }//end for
            if (flag == false)
            {
                throw new CustomerDoesNotExist();
            }//end if
             //}//end try
             //catch (CustomerDoesNotExist cne)
             //{
             //    Console.WriteLine(cne.Message + ", so I can't update it");
             //}//end catch   
        }//end method
        #endregion
        #region Delete
        //cruD
        public Customer Delete(int IDnum)
        //finds an object by property and deletes it
        {
            //try
            //{
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID == IDnum)
                {
                    flag = true;
                    Customer c = list[i];
                    list.Remove(list[i]);
                    return c;
                }//end if
            }//end for
            if (flag == false)
            {
                throw new CustomerDoesNotExist();
            }//end if

            //will never get here
            return null;
            //}//end try
            //catch (CustomerDoesNotExist cne)
            //{
            //    Console.WriteLine(cne.Message + ", so I can't delete it");
            //}//end catch
        }//end method
        #endregion
        #region PrintList
        public void PrintList()
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }//end foreach
        }//end PrintList
        #endregion
    }//end class
}//end namespace
