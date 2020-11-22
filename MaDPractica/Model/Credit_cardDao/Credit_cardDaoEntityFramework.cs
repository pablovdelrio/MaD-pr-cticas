using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;
using System.Linq;

namespace Es.Udc.DotNet.MaDPractica.Model.Credit_cardDao
{
    /// <summary>
    /// Specific Operations for Credit_card
    /// </summary>
    public class Credit_cardDaoEntityFramework :
        GenericDaoEntityFramework<Credit_card, String>, ICredit_cardDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public Credit_cardDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his credit_card_id
        /// </summary>
        /// <param credit_card="credit_card_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Credit_card FindByCreditCardNumber(String credit_card_id)
        {
            Credit_card credit_card = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Credit_card where credit_card_id=@credit_card_id";
            DbParameter credit_card_idParameter =
                new System.Data.SqlClient.SqlParameter("credit_card_id", credit_card_id);

            credit_card = Context.Database.SqlQuery<Credit_card>(sqlQuery, credit_card_idParameter).FirstOrDefault<Credit_card>();

            #endregion Option 2: Using eSQL over dbSet

            if (credit_card == null)
                throw new InstanceNotFoundException(credit_card_id,
                    typeof(Credit_card).FullName);

            return credit_card;
        }
        #endregion ICreidt_cardDao Members
    }
}
