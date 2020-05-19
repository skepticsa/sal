using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SALPrototypeWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            comboBoxServiceType.Items.Add("1 - Web Services");
            comboBoxServiceType.Items.Add("2 - WCF");
            comboBoxServiceType.Items.Add("3 - Direct Access");

            comboBoxServiceType.SelectedIndex = 0;

            SAL.ModuleLoader.DynamicModuleLoader.LoadConcreteFactory(SAL.ModuleLoader.DynamicModuleLoader.ProxyType.WS);
        }

        private void buttonRetrieve_Click(object sender, RoutedEventArgs e)
        {
            Cursor oldCrs = this.Cursor;
            this.Cursor = Cursors.Wait;

            try
            {
                SAL.Factory.IWrapperAccountSettings accSettingsFactory = SAL.Factory.AbstractFactory.Instance.GetWrapperAccountSettings();

                SAL.DataContainers.AccountId id = new SAL.DataContainers.AccountId();

                SAL.DataContainers.AccountSettings accSettings = accSettingsFactory.GetAccountSettings(id);

                textBoxName.Text = accSettings.Name;
                textBoxAddress.Text = accSettings.Address;
                textBoxBuyingPower.Text = accSettings.BuyingPower.ToString("#,##0.00");
            }
            finally
            {
                this.Cursor = oldCrs;
            }
        }

        private void comboBoxServiceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBoxServiceType.SelectedIndex)
            {
                case 0:
                    SAL.ModuleLoader.DynamicModuleLoader.LoadConcreteFactory(SAL.ModuleLoader.DynamicModuleLoader.ProxyType.WS);
                    break;
                case 1:
                    SAL.ModuleLoader.DynamicModuleLoader.LoadConcreteFactory(SAL.ModuleLoader.DynamicModuleLoader.ProxyType.WCF);
                    break;
                case 2:
                    SAL.ModuleLoader.DynamicModuleLoader.LoadConcreteFactory(SAL.ModuleLoader.DynamicModuleLoader.ProxyType.DirectAccess);
                    break;

            }

        }
    }
}
