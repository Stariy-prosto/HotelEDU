namespace HotelEDU
{
    partial class TypesProfilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypesProfilesForm));
            this.IndividualRadioButton = new System.Windows.Forms.RadioButton();
            this.CompanyRadioButton = new System.Windows.Forms.RadioButton();
            this.TravelAgentRadioButton = new System.Windows.Forms.RadioButton();
            this.SourceRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupRadioButton = new System.Windows.Forms.RadioButton();
            this.ContactRadioButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IndividualRadioButton
            // 
            this.IndividualRadioButton.AutoSize = true;
            this.IndividualRadioButton.Location = new System.Drawing.Point(12, 12);
            this.IndividualRadioButton.Name = "IndividualRadioButton";
            this.IndividualRadioButton.Size = new System.Drawing.Size(70, 17);
            this.IndividualRadioButton.TabIndex = 0;
            this.IndividualRadioButton.TabStop = true;
            this.IndividualRadioButton.Text = "Individual";
            this.IndividualRadioButton.UseVisualStyleBackColor = true;
            // 
            // CompanyRadioButton
            // 
            this.CompanyRadioButton.AutoSize = true;
            this.CompanyRadioButton.Location = new System.Drawing.Point(12, 35);
            this.CompanyRadioButton.Name = "CompanyRadioButton";
            this.CompanyRadioButton.Size = new System.Drawing.Size(69, 17);
            this.CompanyRadioButton.TabIndex = 1;
            this.CompanyRadioButton.TabStop = true;
            this.CompanyRadioButton.Text = "Company";
            this.CompanyRadioButton.UseVisualStyleBackColor = true;
            // 
            // TravelAgentRadioButton
            // 
            this.TravelAgentRadioButton.AutoSize = true;
            this.TravelAgentRadioButton.Location = new System.Drawing.Point(12, 58);
            this.TravelAgentRadioButton.Name = "TravelAgentRadioButton";
            this.TravelAgentRadioButton.Size = new System.Drawing.Size(86, 17);
            this.TravelAgentRadioButton.TabIndex = 2;
            this.TravelAgentRadioButton.TabStop = true;
            this.TravelAgentRadioButton.Text = "Travel Agent";
            this.TravelAgentRadioButton.UseVisualStyleBackColor = true;
            // 
            // SourceRadioButton
            // 
            this.SourceRadioButton.AutoSize = true;
            this.SourceRadioButton.Location = new System.Drawing.Point(12, 81);
            this.SourceRadioButton.Name = "SourceRadioButton";
            this.SourceRadioButton.Size = new System.Drawing.Size(59, 17);
            this.SourceRadioButton.TabIndex = 3;
            this.SourceRadioButton.TabStop = true;
            this.SourceRadioButton.Text = "Source";
            this.SourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupRadioButton
            // 
            this.GroupRadioButton.AutoSize = true;
            this.GroupRadioButton.Location = new System.Drawing.Point(12, 104);
            this.GroupRadioButton.Name = "GroupRadioButton";
            this.GroupRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GroupRadioButton.TabIndex = 4;
            this.GroupRadioButton.TabStop = true;
            this.GroupRadioButton.Text = "Group";
            this.GroupRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContactRadioButton
            // 
            this.ContactRadioButton.AutoSize = true;
            this.ContactRadioButton.Location = new System.Drawing.Point(12, 127);
            this.ContactRadioButton.Name = "ContactRadioButton";
            this.ContactRadioButton.Size = new System.Drawing.Size(62, 17);
            this.ContactRadioButton.TabIndex = 5;
            this.ContactRadioButton.TabStop = true;
            this.ContactRadioButton.Text = "Contact";
            this.ContactRadioButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 150);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(93, 150);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TypesProfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 181);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ContactRadioButton);
            this.Controls.Add(this.GroupRadioButton);
            this.Controls.Add(this.SourceRadioButton);
            this.Controls.Add(this.TravelAgentRadioButton);
            this.Controls.Add(this.CompanyRadioButton);
            this.Controls.Add(this.IndividualRadioButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypesProfilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypesProfilesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton CompanyRadioButton;
        private System.Windows.Forms.RadioButton TravelAgentRadioButton;
        private System.Windows.Forms.RadioButton SourceRadioButton;
        private System.Windows.Forms.RadioButton GroupRadioButton;
        private System.Windows.Forms.RadioButton ContactRadioButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.RadioButton IndividualRadioButton;
    }
}