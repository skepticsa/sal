using System;
using System.Collections.Generic;
using System.Text;

using SAL.DataContainers;
using SAL.Factory;

namespace DirectAccessProvider
{
    public class DirectAccessAccountSettings : IWrapperAccountSettings
    {
        #region IWrapperAccountSettings Members

        public SAL.DataContainers.AccountSettings GetAccountSettings(SAL.DataContainers.AccountId id)
        {
            AccountSettings accSettings = new AccountSettings();
            accSettings.Id = id;

            accSettings.BuyingPower = 7000;
            accSettings.Name = "I'm a simple guy";
            accSettings.Address = "Delta Quadrant";

            return accSettings;
        }

        public void SetAccountBuyingPower(SAL.DataContainers.AccountId id, decimal bp)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
