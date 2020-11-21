using Es.Udc.DotNet.ModelUtil.Dao;
using System;

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
    }
}