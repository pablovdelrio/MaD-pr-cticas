using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.CategoryDao
{
    interface ICategoryDao : IGenericDao<Category, Decimal>
    {
        /// <summary>
        /// Finds a Category by id
        /// </summary>
        /// <param id="typeId">id</param>
        /// <returns>The Category</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Category FindByType_id(Decimal type_id);
    }
}
