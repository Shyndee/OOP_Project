using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CustomerBL
    {
        CustomerDAL CustomerD;
        #region CTOR

        public CustomerBL()
        {
            CustomerD = new CustomerDAL();
        }//end ctor

        #endregion
        #region CreateBL
        public void CreateBL(Customer customer)
        {

            try
            {
                CustomerD.Create(customer);
            }//end try
            catch (CustomerAlreadyExists cae)
            {
                throw new CustomerAlreadyExists();
                //Console.WriteLine(cae.Message);
            }//end catch


            //List<Product> list = ProductDAL.RetrieveAll();
            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            /*    catch (ProductAlreadyExists pde)
                {
                    throw new ProductAlreadyExists();
                }*/
        }//end Create
        #endregion
        #region RetrieveBL

        public Customer RetrieveBL(int IDnum)
        {
            try
            {
                return CustomerD.Retrieve(IDnum);

            }//end try
            catch (CustomerDoesNotExist dne)
            {
                throw new CustomerDoesNotExist();
                //Console.WriteLine(dne.Message);
            }//end catch
            return null;
        }//end retrieve

        #endregion
        #region Retrieve All BL
        public List<Customer> RetrieveAllBL()
        {
            List<Customer> list = CustomerD.RetrieveAll();
            return list;

        }//end retrieveAll
        #endregion
        #region Update BL
        public void UpdateBL(Customer customer)
        {
            try
            {
                CustomerD.Update(customer);

            }//end try
            catch(CustomerDoesNotExist cde)
            {
               // Console.WriteLine(cde.Message);
                throw new CustomerDoesNotExist();
            }//end catch


        }//end update
        #endregion
        #region Delete BL
        public Customer DeleteBL(int IDnum)
        {
            try
            {
               return CustomerD.Delete(IDnum);
            }//end try
            catch (CustomerDoesNotExist cne)
            {
                throw new CustomerDoesNotExist();
               // Console.WriteLine(cne.Message + ", so I can't delete it");
            }//end catch
            //catch
            //{
            //    throw new ProductDoesNotExist();
            //}
        }//end delete
        #endregion
        #region Print List
        public void PrintListBL()
        {
            List<Customer> listBL = CustomerD.RetrieveAll();

            foreach (Customer i in listBL)
            {
                Console.WriteLine(i);
            }//end foreach
        }//end PrintList
        #endregion
    }//end class
}//end namespace
