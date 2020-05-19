/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace SAL.Factory
{
    public abstract class AbstractFactory
    {
        public static AbstractFactory Instance = null;

        protected AbstractFactory() { }

        public abstract IWrapperAccountSettings GetWrapperAccountSettings();

        public abstract IWrapperTrades GetWrapperTrades();

    }
}
