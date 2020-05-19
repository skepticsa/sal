using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SAL.WCFServiceHost
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class WCFAccountSettings : IAccountSettings
    {
        public AccountSettings GetAccountSettings(AccountId id)
        {
            AccountSettings accSet = new AccountSettings();

            accSet.Id = id;

            accSet.BuyingPower = 8000;
            accSet.Name = "WCF Jane Smith";
            accSet.Address = "Some Street on Mars";

            return accSet;
        }
        public void SetAccountBuyingPower(AccountId id, Decimal bp)
        {
        }
    }
}
