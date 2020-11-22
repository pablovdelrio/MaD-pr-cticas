using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

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
        public Producto_por_pedido FindByLineaId(Decimal order_id, Decimal product_id)
        {
            Producto_por_pedido linea = null; /*

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Costumer where costumer_id=@costumer_id";
            DbParameter costumer_idParameter =
                new System.Data.SqlClient.SqlParameter("costumer_id", costumer_id);

            costumer = Context.Database.SqlQuery<Costumer>(sqlQuery, costumer_idParameter).FirstOrDefault<Costumer>();

            #endregion Option 2: Using eSQL over dbSet

            if (linea == null)
                throw new InstanceNotFoundException(order_id,
                    typeof(Costumer).FullName);
        */
            return linea;
        }
        #endregion ICostumerDao Members
    }
}
