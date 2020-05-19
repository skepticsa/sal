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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToLongDateString();

            toolStripComboBoxServiceType.Items.Add( "1 - Web Services"  );
            toolStripComboBoxServiceType.Items.Add( "2 - WCF"           );
            toolStripComboBoxServiceType.Items.Add( "3 - Direct Access" );

            toolStripComboBoxServiceType.SelectedIndex = 0;

            SAL.ModuleLoader.DynamicModuleLoader.LoadConcreteFactory(SAL.ModuleLoader.DynamicModuleLoader.ProxyType.WS);

            accountSettingsToolStripMenuItem_Click(null, null);
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountSettings form = new FormAccountSettings();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripComboBoxServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBoxServiceType.SelectedIndex)
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