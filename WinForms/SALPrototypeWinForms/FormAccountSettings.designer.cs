namespace SALPrototypeWinForms
{
    partial class FormAccountSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.groupBoxAccountId = new System.Windows.Forms.GroupBox();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.groupBoxAccountSettings = new System.Windows.Forms.GroupBox();
            this.textBoxBuyingPower = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelBuyingPower = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAccountId.SuspendLayout();
            this.groupBoxAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Location = new System.Drawing.Point(14, 22);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(62, 13);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "&Account Id:";
            // 
            // textBoxAccountId
            // 
            this.textBoxAccountId.Location = new System.Drawing.Point(82, 19);
            this.textBoxAccountId.MaxLength = 10;
            this.textBoxAccountId.Name = "textBoxAccountId";
            this.textBoxAccountId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountId.TabIndex = 1;
            // 
            // groupBoxAccountId
            // 
            this.groupBoxAccountId.Controls.Add(this.textBoxAccountId);
            this.groupBoxAccountId.Controls.Add(this.labelAccountId);
            this.groupBoxAccountId.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAccountId.Name = "groupBoxAccountId";
            this.groupBoxAccountId.Size = new System.Drawing.Size(200, 54);
            this.groupBoxAccountId.TabIndex = 2;
            this.groupBoxAccountId.TabStop = false;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(231, 16);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrieve.TabIndex = 3;
            this.buttonRetrieve.Text = "&Retrieve";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // groupBoxAccountSettings
            // 
            this.groupBoxAccountSettings.Controls.Add(this.textBoxBuyingPower);
            this.groupBoxAccountSettings.Controls.Add(this.textBoxAddress);
            this.groupBoxAccountSettings.Controls.Add(this.labelBuyingPower);
            this.groupBoxAccountSettings.Controls.Add(this.labelAddress);
            this.groupBoxAccountSettings.Controls.Add(this.textBoxName);
            this.groupBoxAccountSettings.Controls.Add(this.labelName);
            this.groupBoxAccountSettings.Location = new System.Drawing.Point(12, 81);
            this.groupBoxAccountSettings.Name = "groupBoxAccountSettings";
            this.groupBoxAccountSettings.Size = new System.Drawing.Size(392, 147);
            this.groupBoxAccountSettings.TabIndex = 4;
            this.groupBoxAccountSettings.TabStop = false;
            this.groupBoxAccountSettings.Text = "Account S&ettings:";
            // 
            // textBoxBuyingPower
            // 
            this.textBoxBuyingPower.Location = new System.Drawing.Point(95, 109);
            this.textBoxBuyingPower.MaxLength = 10;
            this.textBoxBuyingPower.Name = "textBoxBuyingPower";
            this.textBoxBuyingPower.Size = new System.Drawing.Size(111, 20);
            this.textBoxBuyingPower.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(95, 52);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(282, 44);
            this.textBoxAddress.TabIndex = 1;
            // 
            // labelBuyingPower
            // 
            this.labelBuyingPower.AutoSize = true;
            this.labelBuyingPower.Location = new System.Drawing.Point(14, 112);
            this.labelBuyingPower.Name = "labelBuyingPower";
            this.labelBuyingPower.Size = new System.Drawing.Size(75, 13);
            this.labelBuyingPower.TabIndex = 0;
            this.labelBuyingPower.Text = "&Buying Power:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(14, 55);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "A&ddress:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(282, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "&Name:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(329, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAccountSettings
            // 
            this.AcceptButton = this.buttonRetrieve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 240);
            this.Controls.Add(this.groupBoxAccountSettings);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.groupBoxAccountId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.FormAccountSettings_Load);
            this.groupBoxAccountId.ResumeLayout(false);
            this.groupBoxAccountId.PerformLayout();
            this.groupBoxAccountSettings.ResumeLayout(false);
            this.groupBoxAccountSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.TextBox textBoxAccountId;
        private System.Windows.Forms.GroupBox groupBoxAccountId;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.GroupBox groupBoxAccountSettings;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBuyingPower;
        private System.Windows.Forms.TextBox textBoxBuyingPower;
        private System.Windows.Forms.Button buttonSave;
    }
}