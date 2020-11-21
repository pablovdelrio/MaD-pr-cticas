using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.CategoryDao
{
    /// <summary>
    /// Specific Operations for Category
    /// </summary>
    public class CategoryDaoEntityFramework :
        GenericDaoEntityFramework<Category, Decimal>, ICategoryDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public CategoryDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Category by his type_id
        /// </summary>
        /// <param Category="type_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Category FindByType_id(Decimal type_id)
        {
            Category category = null;

            #region Option 2: Using eSQL over dbSet

            //string sqlQuery = "Select * FROM Category where type_id=@type_id";
            //DbParameter type_idParameter =
            //    new System.Data.SqlClient.SqlParameter("type_id", type_id);

            //category = Context.Database.SqlQuery<Category>(sqlQuery, type_idParameter).FirstOrDefault<Category>();

            #endregion Option 2: Using eSQL over dbSet

            if (category == null)
                throw new InstanceNotFoundException(type_id,
                    typeof(Category).FullName);

            return category;
        }
        #endregion ICategoryDao Members
    }
}
