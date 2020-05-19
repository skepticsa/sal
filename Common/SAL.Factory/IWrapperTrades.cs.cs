/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using SAL.DataContainers;

namespace SAL.Factory
{
    public interface IWrapperTrades
    {
        DataSet GetTrades(AccountId id);
    }
}
