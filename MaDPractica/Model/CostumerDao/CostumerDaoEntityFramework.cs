﻿using Es.Udc.DotNet.ModelUtil.Dao;
using Es.Udc.DotNet.ModelUtil.Exceptions;
using System;
using System.Data.Common;
using System.Linq;

namespace Es.Udc.DotNet.MaDPractica.Model.CostumerDao
{
    /// <summary>
    /// Specific Operations for Costumer
    /// </summary>
    public class CostumerDaoEntityFramework :
        GenericDaoEntityFramework<Costumer, Decimal>, ICostumerDao
    {
        #region Public Constructors

        /// <summary>
        /// Public Constructor
        /// </summary>
        public CostumerDaoEntityFramework()
        {
        }

        #endregion Public Constructors

        #region IUserProfileDao Members. Specific Operations

        /// <summary>
        /// Finds a Cosumer by his costumer_id
        /// </summary>
        /// <param costumer="costumer_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public Costumer FindByCostumerId(Decimal costumer_id)
        {
            Costumer costumer = null;

            #region Option 2: Using eSQL over dbSet

            string sqlQuery = "Select * FROM Costumer where costumer_id=@costumer_id";
            DbParameter costumer_idParameter =
                new System.Data.SqlClient.SqlParameter("costumer_id", costumer_id);

            costumer = Context.Database.SqlQuery<Costumer>(sqlQuery, costumer_idParameter).FirstOrDefault<Costumer>();

            #endregion Option 2: Using eSQL over dbSet

            if (costumer == null)
                throw new InstanceNotFoundException(costumer_id,
                    typeof(Costumer).FullName);

            return costumer;
        }

        /// <summary>
        /// Finds a Cosumer by his costumer_id
        /// </summary>
        /// <param costumer="costumer_id"></param>
        /// <returns></returns>
        /// <exception cref="InstanceNotFoundException"></exception>
        public void UpdateCostumer(Decimal costumer_id, String direccion, String email, String idioma, String country)
        {
            Costumer costumer = null;
            costumer = FindByCostumerId(costumer_id);

            if (!String.IsNullOrEmpty(direccion))
            {
                costumer.direccion = direccion;
            }
            if (!String.IsNullOrEmpty(email))
            {
                costumer.email = email;
            }
            if (!String.IsNullOrEmpty(idioma))
            {
                costumer.idioma = idioma;
            }
            if (!String.IsNullOrEmpty(country))
            {
                costumer.country = country;
            }

            #region Option 2: Using eSQL over dbSet

            //string sqlQuery = "Select * FROM Costumer where costumer_id=@costumer_id";
            //DbParameter costumer_idParameter =
            //    new System.Data.SqlClient.SqlParameter("costumer_id", costumer_id);

            //costumer = Context.Database.SqlQuery<Costumer>(sqlQuery, costumer_idParameter).FirstOrDefault<Costumer>();

            #endregion Option 2: Using eSQL over dbSet

            if (costumer == null)
                throw new InstanceNotFoundException(costumer_id,
                    typeof(Costumer).FullName);
        }
        #endregion ICostumerDao Members
    }
}
