using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.PropertyDao
{
    interface IPropertyDao : IGenericDao<Property, Decimal>
    {
        /// <summary>
        /// Finds a Property by id
        /// </summary>
        /// <param id="PropertyId">id</param>
        /// <returns>The Property</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Property FindByPropertyId(Decimal PropertyId);
    }
}