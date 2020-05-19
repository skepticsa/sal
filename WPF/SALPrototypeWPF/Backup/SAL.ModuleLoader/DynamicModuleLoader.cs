using System;
using System.Collections.Generic;
using System.Text;

namespace SAL.ModuleLoader
{
    public class DynamicModuleLoader
    {
        public enum ProxyType
        {
            WS,
            WCF,
            DirectAccess,
        }

        public static void LoadConcreteFactory()
        {


        }
        public static void LoadConcreteFactory(ProxyType proxyType)
        {
            switch (proxyType)
            {
                case ProxyType.WS:
                    SAL.Factory.AbstractFactory.Instance = new SAL.WSProxy.WSFactory();
                    break;
                case ProxyType.WCF:
                    SAL.Factory.AbstractFactory.Instance = new SAL.WCFProxy.WCFFactory();
                    break;
                case ProxyType.DirectAccess:
                    SAL.Factory.AbstractFactory.Instance = new SAL.DirectAccessProxy.DirectAccessFactory();
                    break;

            }
        }
    }
}
