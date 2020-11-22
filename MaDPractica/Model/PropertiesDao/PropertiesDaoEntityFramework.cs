using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;
using System.Linq;

namespace Es.Udc.DotNet.MaDPractica.Model.PropertiesDao
{ 
    /// <summary>
    /// Specific Operations for Properties
    /// </summary>
public class PropertiesDaoEntityFramework :
        GenericDaoEntityFramework<Properties, Decimal>, IPropertiesDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public PropertiesDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his properties_id
        /// </summary>
        /// <param properties="properties_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Properties FindByPropertiesId(Decimal properties_id)
        {
            Properties properties = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Properties where properties_id=@properties_id";
            DbParameter properties_idParameter =
                new System.Data.SqlClient.SqlParameter("properties_id", properties_id);

            properties = Context.Database.SqlQuery<Properties>(sqlQuery, properties_idParameter).FirstOrDefault<Properties>();

            #endregion Option 2: Using eSQL over dbSet

            if (properties == null)
                throw new InstanceNotFoundException(properties_id,
                    typeof(Properties).FullName);

            return properties;
        }
        #endregion IPropertiesDao Members
    }
}
