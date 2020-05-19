/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using SAL.DataContainers;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WSAccountSettings : System.Web.Services.WebService
{
    public WSAccountSettings()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public AccountSettings GetAccountSettings(AccountId id)
    {
        DirectAccessProvider.DirectAccessAccountSettings daSettings = new DirectAccessProvider.DirectAccessAccountSettings();

        AccountSettings accSettings = daSettings.GetAccountSettings(id);

        accSettings.BuyingPower = 5000;
        accSettings.Name = "Web Services Joe Doe";
        accSettings.Address = "Local Web Services Street, Austin Texas";

        return accSettings;
    }


    [WebMethod]
    public void SetAccountBuyingPower(AccountId id, Decimal bp)
    {

    }

}
