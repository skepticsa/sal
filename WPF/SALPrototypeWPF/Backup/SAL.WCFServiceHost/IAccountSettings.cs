using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SAL.WCFServiceHost
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
    [ServiceContract()]
    public interface IAccountSettings
    {
        [OperationContract]
        AccountSettings GetAccountSettings(AccountId id);

        [OperationContract]
        void SetAccountBuyingPower(AccountId id, Decimal bp);
    }

    [DataContract]
    public class AccountId
    {
        String _ClearingId = "";

        [DataMember]
        public string ClearingId
        {
            get { return _ClearingId; }
            set { _ClearingId = value; }
        }
    }

    [DataContract]
    public class AccountSettings
    {
        AccountId _id = null;
        Decimal _BuyingPower;
        String _Name = "";
        String _Address = "";

        [DataMember]
        public AccountId Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public Decimal BuyingPower
        {
            get { return _BuyingPower; }
            set { _BuyingPower = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
