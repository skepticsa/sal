﻿/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;

using SAL.DataContainers;
using SAL.Factory;

namespace SAL.WSProxy
{
    public class WSWrapperTrades : IWrapperTrades
    {
        #region IWrapperTrades Members

        public System.Data.DataSet GetTrades(AccountId id)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
