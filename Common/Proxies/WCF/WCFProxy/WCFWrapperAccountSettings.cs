/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using SAL.Factory;

using WCFProxy.WCFProxyAccountSettings;

namespace SAL.WCFProxy
{
    public class WCFWrapperAccountSettings : IWrapperAccountSettings
    {
        #region IWrapperAccountSettings Members

        public SAL.DataContainers.AccountSettings GetAccountSettings(SAL.DataContainers.AccountId id)
        {
            SAL.DataContainers.AccountSettings accSettings = new SAL.DataContainers.AccountSettings();

            try
            {
                AccountSettingsClient client = new AccountSettingsClient();

                AccountId wcfAccId = new AccountId();
                wcfAccId.ClearingId = id.ClearingId;

                AccountSettings wcfAccSet = client.GetAccountSettings(wcfAccId);
                accSettings.Id = new SAL.DataContainers.AccountId();

                accSettings.Id.ClearingId = wcfAccSet.Id.ClearingId;

                accSettings.Name = wcfAccSet.Name;
                accSettings.Address = wcfAccSet.Address;
                accSettings.BuyingPower = wcfAccSet.BuyingPower;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            return accSettings;
        }


        public void SetAccountBuyingPower(SAL.DataContainers.AccountId id, decimal bp)
        {
            try
            {
                AccountSettingsClient client = new AccountSettingsClient();

                AccountId wcfAccId = new AccountId();
                wcfAccId.ClearingId = id.ClearingId;

                client.SetAccountBuyingPower(wcfAccId, bp);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

        #endregion
    }
}
