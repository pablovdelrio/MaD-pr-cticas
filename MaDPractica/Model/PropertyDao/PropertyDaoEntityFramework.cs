using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;
using System.Linq;

namespace Es.Udc.DotNet.MaDPractica.Model.PropertyDao
{
    /// <summary>
    /// Specific Operations for Property
    /// </summary>
    public class PropertyDaoEntityFramework :
        GenericDaoEntityFramework<Property, Decimal>, IPropertyDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public PropertyDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his property_id
        /// </summary>
        /// <param property="property_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Property FindByPropertyId(Decimal property_id)
        {
            Property property = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Property where property_id=@property_id";
            DbParameter property_idParameter =
                new System.Data.SqlClient.SqlParameter("property_id", property_id);

            property = Context.Database.SqlQuery<Property>(sqlQuery, property_idParameter).FirstOrDefault<Property>();

            #endregion Option 2: Using eSQL over dbSet

            if (property == null)
                throw new InstanceNotFoundException(property_id,
                    typeof(Property).FullName);

            return property;
        }
        #endregion IPropertyDao Members
    }
}
