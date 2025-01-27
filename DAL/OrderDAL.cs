using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        static List<Order> list = new List<Order>();
        //for later use in retrieve all
        static bool loaded = false; //added by ERP
        ProductDAL pd = new ProductDAL();
        #region CTOR
        //ctor
        public OrderDAL()
        {
            InitializeList();
        }//end ctor
        #endregion
        #region Intialize List
        public static void InitializeList()
        {
            if (loaded == false)
            {
                StreamReader reader = new StreamReader(@"..\..\..\..\DAL\bin\Debug\OrderDAL.txt");

                using (reader)
                {
                    string line = reader.ReadLine();

                    //Console.WriteLine("Read line from file");
                    while (line != null)
                    {
                        int customerID = int.Parse(line);
                        int OrderQuantity = int.Parse(reader.ReadLine());
                        int ProductNum = int.Parse(reader.ReadLine());
                        int orderNumber = int.Parse(reader.ReadLine());
                        //DateTime orderDate =DateTime.Parse(reader.ReadLine());

                        Order order = new Order(customerID, OrderQuantity, ProductNum, orderNumber/*,orderDate*/);

                        line = reader.ReadLine();
                        list.Add(order);

                    }//end while
                    loaded = true;
                }//end using
            }//end if
        }//end Initialize list
        #endregion
        #region Create
        //Crud
        public void Create(Order o)
        {
            Order toUse = new Order(o.CustomerID, o.ProductNum, o.OrderQuantity, o.OrderNumber/*,o.OrderDate*/);

            //try
            //{
            bool flag = false;

            for (int i = 0; i < list.Count; i++)
            {
                //I want to make it as accurate as possuble, seeing as there is no order number, I will check 2 factors
                //of the order
                if (toUse.OrderNumber.Equals(list[i].OrderNumber))
                {
                    flag = true;
                    break;
                }//end if

            }//end for

            if (flag == false)
            {
                //updating order quantity
                Product p = pd.Retrieve(o.ProductNum);
                int AmountInStock = p.AmountInStock-o.OrderQuantity;
                Product update = new Product(p.ProductName, p.CostPerUnit, p.ProductNumber, AmountInStock);
                pd.Update(update);
                list.Add(toUse);
            }//end if
            else
            {
                throw new OrderAlreadyExists();
            }//end else

            //}//end try 

            //catch (OrderAlreadyExists ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}//end catch

        }//End Create
        #endregion         
        #region Retrieve
        //cRud  
        public Order Retrieve(int orderNum)
        {
            //Finds the object, returns a copy
            //making a copy of my list
            List<Order> newOrderList = list.ConvertAll(order => new Order(order.CustomerID,  order.ProductNum, order.OrderQuantity, order.OrderNumber/*, order.OrderDate*/));
            bool flag = false;

            //try
            //{
            for (int i = 0; i < newOrderList.Count; i++)
            {

                if (newOrderList[i].OrderNumber.Equals(orderNum))
                {
                    flag = true;
                    return newOrderList[i];
                }//end if

            }//end for
            if (flag == false)
            {
                throw new OrderDoesNotExist();
            }//end if
             //  }//end try
             //catch (OrderDoesNotExist dne)
             //{
             //    Console.WriteLine(dne.Message);
             //}//end catch

            return null;

        }//end method
        #endregion
        #region Retrieve By product
        public List<Order> RetrieveByProduct(int ProductNum)
        {
            //making a copy of my list
            List<Order> newOrderList = list.ConvertAll(order => new Order(order.CustomerID, order.ProductNum, order.OrderQuantity, order.OrderNumber/*,order.OrderDate*/));
            bool flag = false;
            //list to hold the orders we will return
            List<Order> toReturn = new List<Order>();

            for (int i = 0; i < newOrderList.Count; i++)
            {
                if (newOrderList[i].ProductNum.Equals(ProductNum))
                {
                    flag = true;
                    toReturn.Add(newOrderList[i]);
                }//end if
            }//end for
            if (flag)//equals true
                return toReturn;
            else
            {
                throw new ProductDoesNotExist();
            }//end if
        }//end RetrieveByProduct
        #endregion
        #region Retrieve by Customer
        public List<Order> RetrieveByCustomer(int CustID)
        {

            //making a copy of my list
            List<Order> newOrderList = list.ConvertAll(order => new Order(order.CustomerID, order.ProductNum, order.OrderQuantity, order.OrderNumber/*,order.OrderDate*/));
            bool flag = false;
            List<Order> toReturn = new List<Order>();

            for (int i = 0; i < newOrderList.Count; i++)
            {
                if (newOrderList[i].CustomerID.Equals(CustID))
                {
                    flag = true;
                    toReturn.Add(newOrderList[i]);

                }//end if

            }//end for
            if (flag)//equals true
                return toReturn;
            else
            {
                throw new CustomerDoesNotExist();
            }//end if
        }// end RetrieveByCustomer
        #endregion
        #region Retrieve All
        public List<Order> RetrieveAll()
        {
            //making a copy of my list
            List<Order> newOrderList = list.ConvertAll(order => new Order(order.CustomerID,  order.ProductNum, order.OrderQuantity, order.OrderNumber/* ,order.OrderDate*/));
            return newOrderList;

        }//end method
        #endregion
        #region Update
        //crUd
        #region Bad Update
        /*        public void Update(Order o)
                //will receive a product, find a product with the same number in the list, deletes the old one, and places the one i received in the list
                {
                    Order toUse = new Order(o.CustomerID, o.OrderQuantity, o.ProductNum, o.OrderNumber);

                    //try
                    //{
                    bool flag = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (toUse.OrderNumber.Equals(list[i].OrderNumber))
                        {
                            flag = true;
                            list[i] = toUse;
                            //for testing
                            Console.WriteLine(toUse);
                        }//end if

                    }//end for
                    if (flag == false)
                    {
                        throw new OrderDoesNotExist();
                    }//end if
                     // }//end try
                     //catch (OrderDoesNotExist ex)
                     //{
                     //    Console.WriteLine(ex.Message + ", so I can't update it");
                     //}//end catch   
                }//end method
        */
        #endregion
        public void Update(int OrderNum, int Quantity, int ProductNum)
        //the update will have the ability to Change the quantity or the product num, 
        //gets the OrderNUm only to find the order, because changing the order num or
        //the Customer ID is essentially creating a new order.
        {
            //for loop to check ProductNum Is valid
            bool ValidNum = false;
            for(int j = 0; j < list.Count; j++)
            {
                if (list[j].ProductNum == ProductNum)
                {
                    ValidNum= true;
                }//end if
            }//end for
            //try
            //{
            if(ValidNum)
            {
                bool flag = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderNumber.Equals(OrderNum))
                    {
                        Order BeforeEdit = list[i];
                        Order toUse = new Order(list[i].CustomerID, ProductNum, Quantity, list[i].OrderNumber/*,list[i].OrderDate*/);
                        Product p = pd.Retrieve(BeforeEdit.ProductNum);
                        if(Quantity > BeforeEdit.OrderQuantity)
                        {
                            int diffarence = Quantity - BeforeEdit.OrderQuantity;
                            int AmountInStock = p.AmountInStock - diffarence;
                            if(Quantity > p.AmountInStock)
                            {
                                throw new InsufficentStockException();
                            }//end if
                            Product update = new Product(p.ProductName, p.CostPerUnit, p.ProductNumber, AmountInStock);
                            pd.Update(update);
                        }//end if
                        else if(Quantity < BeforeEdit.OrderQuantity)
                        {
                            int diffarence = Quantity + BeforeEdit.OrderQuantity;
                            int AmountInStock = p.AmountInStock + diffarence;
                            Product update = new Product(p.ProductName, p.CostPerUnit, p.ProductNumber, AmountInStock);
                            pd.Update(update);
                        }//end else if
                        
                        //check revise
                        flag = true;
                        list[i] = toUse;
                        //for testing
                        //Console.WriteLine(toUse);
                    }//end if

                }//end for
                if (flag == false)
                {
                    throw new OrderDoesNotExist();
                }//end if
            }//end if Valid num
            else
            {
                throw new ProductDoesNotExist();
                //Console.WriteLine("Product does not exist");
            }//end if
            
            // }//end try
            //catch (OrderDoesNotExist ex)
            //{
            //    Console.WriteLine(ex.Message + ", so I can't update it");
            //}//end catch   
        }//end method
        #endregion
        #region Delete
        //cruD
        public Order Delete(int orderNum)
        //finds an object by property and deletes it
        {
            //try
            //{
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].OrderNumber == orderNum)
                {
                    flag = true;
                    Order o = list[i];
                    //updating product quantity
                    Product p = pd.Retrieve(o.ProductNum);
                    int AmountInStock = p.AmountInStock + o.OrderQuantity;
                    Product update = new Product(p.ProductName, p.CostPerUnit, p.ProductNumber, AmountInStock);
                    pd.Update(update);
                    list.Remove(list[i]);
                    return o;
                }//end if

            }//end for
            if (flag == false)
            {
                throw new OrderDoesNotExist();
            }//end if

            //will never get her
            return null;
             //  }//end try
             //catch (OrderDoesNotExist ex)
             //{
             //    Console.WriteLine(ex.Message + ", so I can't delete it");
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
