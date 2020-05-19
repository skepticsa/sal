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

namespace SAL.WSProxy
{
    public class WSFactory : AbstractFactory
    {
        public override IWrapperAccountSettings GetWrapperAccountSettings()
        {
            return new WSWrapperAccountSettings();
        }

        public override IWrapperTrades GetWrapperTrades()
        {
            return new WSWrapperTrades();
        }
    }
}
