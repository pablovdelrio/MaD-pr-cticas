﻿using Es.Udc.DotNet.ModelUtil.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es.Udc.DotNet.MaDPractica.Model.CostumerDao
{
    public interface ICostumerDao : IGenericDao<Costumer, Decimal>
    {
        /// <summary>
        /// Finds a Costumer by costumerId
        /// </summary>
        /// <param costumer="costumerId">loginName</param>
        /// <returns>The Costumer</returns>
        /// <exception cref="InstanceNotFoundException"/>
        Costumer FindByCostumerId(Decimal costumerId);
    }
}