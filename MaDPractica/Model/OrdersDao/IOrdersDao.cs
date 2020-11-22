using Es.Udc.DotNet.ModelUtil.Dao;
using System;
using System.Collections.Generic;

namespace Es.Udc.DotNet.MaDPractica.Model.OrdersDao
{
    interface IOrdersDao : IGenericDao<Orders, Decimal>
    {
        /// <summary>
        /// Finds a Order by id
        /// </summary>
        /// <param id="OrderId">id</param>
        /// <returns>The Order</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Orders FindByOrderId(Decimal OrderId);

        /// <summary>
        /// List orders of costumer
        /// </summary>
        /// <param id="CostumerId">id</param>
        /// <returns>The list of Orders</returns>
        /// <exception cref="InstanceNotFoundException"/>
        List<Orders> FindOrders(Decimal costumer_Id);
    }
}