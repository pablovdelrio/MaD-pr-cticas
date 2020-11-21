using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.Producto_por_pedidoDao
{
    interface IProducto_por_pedidoDao : IGenericDao<Producto_por_pedido, Decimal>
    {
        /// <summary>
        /// Finds a Linea by id
        /// </summary>
        /// <param id="LineaId">id</param>
        /// <returns>The Linea</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Producto_por_pedido FindByLineaId(Decimal lineaId);
    }
}