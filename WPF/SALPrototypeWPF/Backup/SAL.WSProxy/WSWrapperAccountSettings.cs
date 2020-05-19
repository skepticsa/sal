/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;

using SAL.Factory;
using SAL.DataContainers;

namespace SAL.WSProxy
{
    public class WSWrapperAccountSettings : IWrapperAccountSettings
    {
        #region IWrapperAccountSettings Members

        public AccountSettings GetAccountSettings(AccountId id)
        {
            SAL.WSProxy.WSAccountSettings ws = new SAL.WSProxy.WSAccountSettings();

            SAL.WSProxy.AccountId wsId = new SAL.WSProxy.AccountId();

            wsId.ClearingId = id.ClearingId;

            SAL.WSProxy.AccountSettings wsAccSettings = ws.GetAccountSettings(wsId);

            AccountSettings accSettings = new AccountSettings();

            accSettings.Id = new AccountId();

            accSettings.Id.ClearingId = wsAccSettings.Id.ClearingId;

            accSettings.BuyingPower = wsAccSettings.BuyingPower;
            accSettings.Name = wsAccSettings.Name;
            accSettings.Address = wsAccSettings.Address;

            return accSettings;
        }

        public void SetAccountBuyingPower(AccountId id, decimal bp)
        {
            SAL.WSProxy.WSAccountSettings ws = new SAL.WSProxy.WSAccountSettings();

            SAL.WSProxy.AccountId wsId = new SAL.WSProxy.AccountId();

            wsId.ClearingId = id.ClearingId;

            ws.SetAccountBuyingPower(wsId, bp);
        }

        #endregion
    }
}
