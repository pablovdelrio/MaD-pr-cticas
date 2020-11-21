using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.ProductDao
{
    /// <summary>
    /// Specific Operations for Product
    /// </summary>
    public class ProductDaoEntityFramework :
        GenericDaoEntityFramework<Product, Decimal>, IProductDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public ProductDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his product_id
        /// </summary>
        /// <param product="product_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Product FindByProductId(Decimal product_id)
        {
            Product product = null;

            #region Option 2: Using eSQL over dbSet

            //string sqlQuery = "Select * FROM Product where product_id=@product_id";
            //DbParameter product_idParameter =
            //    new System.Data.SqlClient.SqlParameter("product_id", product_id);

            //product = Context.Database.SqlQuery<Product>(sqlQuery, product_idParameter).FirstOrDefault<Product>();

            #endregion Option 2: Using eSQL over dbSet

            if (product == null)
                throw new InstanceNotFoundException(product_id,
                    typeof(Product).FullName);

            return product;
        }
        #endregion IProductDao Members
    }
}
