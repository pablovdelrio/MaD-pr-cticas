using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Collections.Generic;

namespace Es.Udc.DotNet.MaDPractica.Model.Producto_por_pedidoDao
{
    /// <summary>
    /// Specific Operations for Costumer
    /// </summary>
    public class Product_por_pedidoDaoEntityFramework :
        GenericDaoEntityFramework<Producto_por_pedido, Decimal>, IProducto_por_pedidoDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public Product_por_pedidoDaoEntityFramework()
        {
        }
    
        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his costumer_id
        /// </summary>
        /// <param costumer="costumer_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Producto_por_pedido FindByLineaId(Decimal lineaId)
        {
            return null;
        }
        #endregion ICostumerDao Members
    }
}
