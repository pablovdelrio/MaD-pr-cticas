using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.PropertiesDao
{
    interface IPropertiesDao : IGenericDao<Properties, Decimal>
    {
        /// <summary>
        /// Finds a Properties by id
        /// </summary>
        /// <param id="PropertiesId">id</param>
        /// <returns>The Properties</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Properties FindByPropertiesId(Decimal PropertiesId);
    }
}