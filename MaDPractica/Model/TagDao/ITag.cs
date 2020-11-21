using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.TagDao
{
    interface ITagDao : IGenericDao<Tag, Decimal>
    {
        /// <summary>
        /// Finds a Tag by id
        /// </summary>
        /// <param id="TagId">id</param>
        /// <returns>The Tag</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Tag FindByTagId(Decimal TagId);
    }
}