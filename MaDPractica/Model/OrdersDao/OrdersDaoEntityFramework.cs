﻿using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.OrdersDao
{
    /// <summary>
    /// Specific Operations for Orders
    /// </summary>
    public class OrdersDaoEntityFramework :
        GenericDaoEntityFramework<Orders, Decimal>, IOrdersDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public OrdersDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his orders_id
        /// </summary>
        /// <param orders="orders_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Orders FindByOrderId(Decimal orders_id)
        {
            Orders orders = null;

            #region Option 2: Using eSQL over dbSet

            //string sqlQuery = "Select * FROM Orders where orders_id=@orders_id";
            //DbParameter orders_idParameter =
            //    new System.Data.SqlClient.SqlParameter("orders_id", orders_id);

            //orders = Context.Database.SqlQuery<Orders>(sqlQuery, orders_idParameter).FirstOrDefault<Orders>();

            #endregion Option 2: Using eSQL over dbSet

            if (orders == null)
                throw new InstanceNotFoundException(orders_id,
                    typeof(Orders).FullName);

            return orders;
        }
        #endregion IOrdersDao Members
    }
}