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
using DirectAccessProvider;

namespace SAL.DirectAccessProxy
{
    public class DirectAccessFactory : AbstractFactory
    {
        public override IWrapperAccountSettings GetWrapperAccountSettings()
        {
            return new DirectAccessAccountSettings();
        }

        public override IWrapperTrades GetWrapperTrades()
        {
            return new DirectAccessTrades();
        }
    }
}
