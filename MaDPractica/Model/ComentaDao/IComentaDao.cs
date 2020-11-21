using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.ComentaDao
{
    interface IComentaDao : IGenericDao<Comenta, Decimal>
    {
        /// <summary>
        /// Finds a Comenta by id
        /// </summary>
        /// <param id="ComentaId">id</param>
        /// <returns>The Comenta</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Comenta FindByComentaId(Decimal comenta_id);
    }
}
