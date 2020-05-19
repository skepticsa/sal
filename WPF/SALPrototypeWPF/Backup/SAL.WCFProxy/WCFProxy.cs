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
using SAL.Factory;

namespace SAL.WCFProxy
{
    public class WCFFactory : AbstractFactory
    {
        public override IWrapperAccountSettings GetWrapperAccountSettings()
        {
            return new WCFWrapperAccountSettings();
        }

        public override IWrapperTrades GetWrapperTrades()
        {
            return new WCFWrapperTrades();
        }
    }
}
