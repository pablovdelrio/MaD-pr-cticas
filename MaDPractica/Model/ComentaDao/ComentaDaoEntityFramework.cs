using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;
using System.Linq;

namespace Es.Udc.DotNet.MaDPractica.Model.ComentaDao
{
    /// <summary>
    /// Specific Operations for Comenta
    /// </summary>
    public class ComentaDaoEntityFramework :
        GenericDaoEntityFramework<Comenta, decimal>, IComentaDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public ComentaDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his comenta_id
        /// </summary>
        /// <param comenta="comenta_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Comenta FindByComentaId(Decimal comenta_id)
        {
            Comenta comenta = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Comenta where comenta_id=@comenta_id";
            DbParameter comenta_idParameter =
                new System.Data.SqlClient.SqlParameter("comenta_id", comenta_id);

            comenta = Context.Database.SqlQuery<Comenta>(sqlQuery, comenta_idParameter).FirstOrDefault<Comenta>();

            #endregion Option 2: Using eSQL over dbSet

            if (comenta == null)
                throw new InstanceNotFoundException(comenta_id,
                    typeof(Comenta).FullName);

            return comenta;
        }
        #endregion IComentaDao Members
    }
}
