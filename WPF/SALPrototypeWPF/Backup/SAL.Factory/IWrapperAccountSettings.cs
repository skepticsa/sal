/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;

using SAL.DataContainers;

namespace SAL.Factory
{
    public interface IWrapperAccountSettings
    {
        AccountSettings GetAccountSettings(AccountId id);
        void SetAccountBuyingPower(AccountId id, Decimal bp);
    }
}
