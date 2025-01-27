using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderBL
    {
        #region CTOR
        OrderDAL orderD;
        ProductDAL productD = new ProductDAL();
        CustomerDAL customerDAL = new CustomerDAL();
        public OrderBL()
        {
          orderD = new OrderDAL();

        }//ctor
        #endregion
        #region CreateBL
        public void CreateBL(Order order)
        {

            try
            {
                productD.Retrieve(order.ProductNum);
                customerDAL.Retrieve(order.CustomerID);
                int Quant = productD.Retrieve(order.ProductNum).AmountInStock;
                if(order.OrderQuantity > Quant)
                {
                    throw new InsufficentStockException();
                }//end if
                orderD.Create(order);
            }//end try
            catch (OrderAlreadyExists ex)
            {
                //Console.WriteLine(ex.Message);
                throw new OrderAlreadyExists();
            }//end catch
            catch(ProductDoesNotExist pde)
            {
                throw new ProductDoesNotExist();
            }//end catch
            catch (CustomerDoesNotExist cde)
            {
                throw new CustomerDoesNotExist();
            }//end cathch
        }//end Create
        #endregion
        #region RetrieveBL
        public Order RetrieveBL(int OrderNum)
        {
            try
            {
                return orderD.Retrieve(OrderNum);

            }//end try
            catch (OrderDoesNotExist dne)
            {
                throw new OrderDoesNotExist();
                // Console.WriteLine(dne.Message);
                //return null;
            }//end catch

            //catch
            //{
            //    throw new ProductDoesNotExist();
            //}//end catch
        }//end retrieve
        #endregion
        #region Retrieve by Product
        public List<Order> RetrieveByProductBL(int ProductNum)
        {

            try
            {
                //can be done in one line
                /*List<Order> list =*/
                return orderD.RetrieveByProduct(ProductNum);
                //return list;
            }//end try
            catch (ProductDoesNotExist dne)
            {
                throw new ProductDoesNotExist();
                //Console.WriteLine(dne.Message);
                //return null;
            }//end catch

        }//end retrieve by prod
        #endregion
        #region Retrieve by Customer
        public List<Order> RetrieveByCustomerBL(int CustID)
        {
            try
            {
                /*  List<Order> list = */
                return orderD.RetrieveByCustomer(CustID);
                //return list;

            }//end try

            catch (OrderDoesNotExist dne)
            {
                throw new CustomerDoesNotExist();
                //    Console.WriteLine(dne.Message);
                //    return null;
            }//end catch
        }//end retrieve by prod
        #endregion
        #region Retrieve All BL
        public List<Order> RetrieveAllBL()
        {
            List<Order> list = orderD.RetrieveAll();
            return list;

        }//end retrieveAll
        #endregion
        #region Update BL
        public void UpdateBL(int OrderNum, int Quantity, int ProductNum)
        {
            try
            {
                orderD.Update(OrderNum, Quantity, ProductNum);
            }//end try
            catch (OrderDoesNotExist ex)
            {
                //Console.WriteLine(ex.Message + ", so I can't update it");
                throw new OrderDoesNotExist();
            }//end catch 
            catch (ProductDoesNotExist pde)
            {
                throw new ProductDoesNotExist();
            }//end catch

        }//end update
        #endregion
        #region Delete BL
        public Order DeleteBL(int CustID)
        {
            try
            {
                Order o = orderD.Delete(CustID); 
              /*  productD.Retrieve(o.ProductNum).AmountInStock -= o.OrderQuantity;
                //foreach(var i in productD.list)
                //p.AmountInStock = p.AmountInStock - o.OrderQuantity;*/
                return o;
                //return o;
            }//end try
            catch (OrderDoesNotExist ex)
            {
                //Console.WriteLine(ex.Message + ", so I can't delete it");
                throw new OrderDoesNotExist();
            }//end catch
        }//end delete
        #endregion
        #region Print List
        public void PrintListBL()
        {
            List<Order> listBL = orderD.RetrieveAll();

            foreach (Order i in listBL)
            {
                Console.WriteLine(i);
            }//end foreach
        }//end PrintList
        #endregion
    }//end class
}//end Namespace
