using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductBL
    {
        //creating a variable of type ProductDal so that we can call all the mwethods on it.
        ProductDAL productD;
        #region CTOR
        public ProductBL()
        {
            productD = new ProductDAL();
        }//ctor
        #endregion
         //List<Product> listBL = ProductDAL.RetrieveAll();
        #region CreateBL
        public void CreateBL(Product product)
        {

            //ProductDAL pd = new ProductDAL();
            //pd.Create(product);
            try
            {
                productD.Create(product);
            }//end try
            
            
            //List<Product> list = ProductDAL.RetrieveAll();
            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            catch(ProductAlreadyExists pde)
            {
                //to be caught in the UI
                throw new ProductAlreadyExists();
            }//end catch
        }//end Create
        #endregion
        #region RetrieveBL
        public Product RetrieveBL(int productNum)
        {
            try
            {
                //if the retrieve in the DAL works, it will return a Product, here I am just returning the product.
                //same as saying Product p = mthod call; return p
                return productD.Retrieve(productNum);
            }//end try
            catch
            {
                throw new ProductDoesNotExist();
            }//end catch
        }//end retrieve

        #endregion
        #region Retrieve All BL
        public List<Product> RetrieveAllBL()
        {
            List<Product> list = productD.RetrieveAll();
            return list;
           
        }//end retrieveAll
        #endregion
        #region Update BL
        public void UpdateBL(Product product)
        {
            try
            {
                productD.Update(product);
            }//end try
            catch
            {
                throw new ProductDoesNotExist();
            }//end catch

        }//end update
        #endregion
        #region Delete BL
        public Product DeleteBL(int productNum)
        {
            try
            {
                //showing that there is another clearer way to do it, could really do it in one line.
                Product pr = productD.Delete(productNum);
                return pr;
            }//end try
            catch
            {
                throw new ProductDoesNotExist();
            }//end catch
        }//end delete
        #endregion
        #region Print List
        public void PrintListBL()
        {
            //accesing the list through retrieve all
            List<Product> listBL = productD.RetrieveAll();

            foreach (Product i in listBL)
            {
                Console.WriteLine(i);
            }//end foreach
        }//end PrintList
        #endregion
    }//end class
}//end namespace
