using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.ProductDao
{
    interface IProductDao : IGenericDao<Product, decimal>
    {
        /// <summary>
        /// Finds a Product by id
        /// </summary>
        /// <param id="ProductId">id</param>
        /// <returns>The Product</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Product FindByProductId(Decimal ProductId);
    }
}