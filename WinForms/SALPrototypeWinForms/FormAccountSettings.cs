/*********************************************************
 * Author: Danut Prisacaru
 * 
 * Application Architect
 * 
*********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SALPrototypeWinForms
{
    public partial class FormAccountSettings : Form
    {
        public FormAccountSettings()
        {
            InitializeComponent();
        }

        private void FormAccountSettings_Load(object sender, EventArgs e)
        {
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            Cursor oldCrs = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                SAL.Factory.IWrapperAccountSettings accSettingsFactory = SAL.Factory.AbstractFactory.Instance.GetWrapperAccountSettings();

                SAL.DataContainers.AccountId id = new SAL.DataContainers.AccountId();

                SAL.DataContainers.AccountSettings accSettings = accSettingsFactory.GetAccountSettings(id);

                textBoxName       .Text = accSettings.Name;
                textBoxAddress    .Text = accSettings.Address;
                textBoxBuyingPower.Text = accSettings.BuyingPower.ToString("#,##0.00");
            }
            finally
            {
                this.Cursor = oldCrs;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Cursor oldCrs = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                SAL.Factory.IWrapperAccountSettings accSettingsFactory = SAL.Factory.AbstractFactory.Instance.GetWrapperAccountSettings();

                SAL.DataContainers.AccountId id = new SAL.DataContainers.AccountId();

                accSettingsFactory.SetAccountBuyingPower(id, Convert.ToDecimal(textBoxBuyingPower.Text));
            }
            finally
            {
                this.Cursor = oldCrs;
            }
        }
    }
}