using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;

namespace Es.Udc.DotNet.MaDPractica.Model.TagDao
{
    /// <summary>
    /// Specific Operations for Tag
    /// </summary>
    public class TagDaoEntityFramework :
        GenericDaoEntityFramework<Tag, Decimal>, ITagDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public TagDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his tag_id
        /// </summary>
        /// <param tag="tag_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Tag FindByTagId(Decimal tag_id)
        {
            Tag tag = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Tag where tag_id=@tag_id";
            DbParameter tag_idParameter =
                new System.Data.SqlClient.SqlParameter("tag_id", tag_id);

            tag = Context.Database.SqlQuery<Tag>(sqlQuery, tag_idParameter).FirstOrDefault<Tag>();

            #endregion Option 2: Using eSQL over dbSet

            if (tag == null)
                throw new InstanceNotFoundException(tag_id,
                    typeof(Tag).FullName);

            return tag;
        }
        #endregion ITagDao Members
    }
}
