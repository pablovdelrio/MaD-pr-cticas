using Es.Udc.DotNet.ModelUtil.Dao;
using System;

namespace Es.Udc.DotNet.MaDPractica.Model.Credit_cardDao
{
    interface ICredit_cardDao : IGenericDao<Credit_card, string>
    {
        /// <summary>
        /// Finds a CreditCadrd by number
        /// </summary>
        /// <param number="creditCardNumber">number</param>
        /// <returns>The CreditCard</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Credit_card FindByCreditCardNumber(String creditCardNumber);
    }
}