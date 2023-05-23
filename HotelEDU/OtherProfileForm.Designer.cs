namespace HotelEDU
{
    partial class OtherProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherProfileForm));
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CurrencyTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Communications3TextBox = new System.Windows.Forms.TextBox();
            this.Communications3Button = new System.Windows.Forms.Button();
            this.CommunicationsType3TextBox = new System.Windows.Forms.TextBox();
            this.Communications2TextBox = new System.Windows.Forms.TextBox();
            this.Communications2Button = new System.Windows.Forms.Button();
            this.OwnerTextBox = new System.Windows.Forms.TextBox();
            this.InternalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeButton = new System.Windows.Forms.Button();
            this.CommunicationsType2TextBox = new System.Windows.Forms.TextBox();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.Communications1TextBox = new System.Windows.Forms.TextBox();
            this.OwnerButton = new System.Windows.Forms.Button();
            this.Communications1Button = new System.Windows.Forms.Button();
            this.CommunicationsType1TextBox = new System.Windows.Forms.TextBox();
            this.CommunicationsLabel = new System.Windows.Forms.Label();
            this.CorporateIDLabel = new System.Windows.Forms.Label();
            this.CorporateIDTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.IndividualLabel = new System.Windows.Forms.Label();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.AddressInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryButton = new System.Windows.Forms.Button();
            this.CountryStateLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ARAAddressTextBox = new System.Windows.Forms.TextBox();
            this.ARAAddresslabel = new System.Windows.Forms.Label();
            this.ProfileOtherSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.CommunicationSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.InternalInfoGroupBox.SuspendLayout();
            this.AddressInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(22, 100);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrencyLabel.TabIndex = 25;
            this.CurrencyLabel.Text = "Currency";
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Location = new System.Drawing.Point(77, 97);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(108, 20);
            this.CurrencyTextBox.TabIndex = 13;
            // 
            // CurrencyButton
            // 
            this.CurrencyButton.FlatAppearance.BorderSize = 0;
            this.CurrencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencyButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyButton.Image")));
            this.CurrencyButton.Location = new System.Drawing.Point(191, 95);
            this.CurrencyButton.Name = "CurrencyButton";
            this.CurrencyButton.Size = new System.Drawing.Size(22, 22);
            this.CurrencyButton.TabIndex = 14;
            this.CurrencyButton.Text = " ";
            this.CurrencyButton.UseVisualStyleBackColor = true;
            this.CurrencyButton.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Location = new System.Drawing.Point(553, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 284);
            this.panel1.TabIndex = 125;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 258);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(3, 229);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 26;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 200);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(3, 171);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 24;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Communications3TextBox
            // 
            this.Communications3TextBox.Location = new System.Drawing.Point(120, 227);
            this.Communications3TextBox.Name = "Communications3TextBox";
            this.Communications3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications3TextBox.TabIndex = 23;
            // 
            // Communications3Button
            // 
            this.Communications3Button.FlatAppearance.BorderSize = 0;
            this.Communications3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications3Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications3Button.Image")));
            this.Communications3Button.Location = new System.Drawing.Point(92, 225);
            this.Communications3Button.Name = "Communications3Button";
            this.Communications3Button.Size = new System.Drawing.Size(22, 22);
            this.Communications3Button.TabIndex = 22;
            this.Communications3Button.Text = " ";
            this.Communications3Button.UseVisualStyleBackColor = true;
            this.Communications3Button.Click += new System.EventHandler(this.Communications3Button_Click);
            // 
            // CommunicationsType3TextBox
            // 
            this.CommunicationsType3TextBox.Location = new System.Drawing.Point(8, 227);
            this.CommunicationsType3TextBox.Name = "CommunicationsType3TextBox";
            this.CommunicationsType3TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType3TextBox.TabIndex = 21;
            // 
            // Communications2TextBox
            // 
            this.Communications2TextBox.Location = new System.Drawing.Point(120, 201);
            this.Communications2TextBox.Name = "Communications2TextBox";
            this.Communications2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications2TextBox.TabIndex = 20;
            // 
            // Communications2Button
            // 
            this.Communications2Button.FlatAppearance.BorderSize = 0;
            this.Communications2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications2Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications2Button.Image")));
            this.Communications2Button.Location = new System.Drawing.Point(92, 199);
            this.Communications2Button.Name = "Communications2Button";
            this.Communications2Button.Size = new System.Drawing.Size(22, 22);
            this.Communications2Button.TabIndex = 19;
            this.Communications2Button.Text = " ";
            this.Communications2Button.UseVisualStyleBackColor = true;
            this.Communications2Button.Click += new System.EventHandler(this.Communications2Button_Click);
            // 
            // OwnerTextBox
            // 
            this.OwnerTextBox.Location = new System.Drawing.Point(77, 45);
            this.OwnerTextBox.Name = "OwnerTextBox";
            this.OwnerTextBox.Size = new System.Drawing.Size(108, 20);
            this.OwnerTextBox.TabIndex = 10;
            // 
            // InternalInfoGroupBox
            // 
            this.InternalInfoGroupBox.Controls.Add(this.TypeTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.TypeLabel);
            this.InternalInfoGroupBox.Controls.Add(this.TypeButton);
            this.InternalInfoGroupBox.Controls.Add(this.Communications3TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.Communications3Button);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyLabel);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType3TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.Communications2TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyButton);
            this.InternalInfoGroupBox.Controls.Add(this.Communications2Button);
            this.InternalInfoGroupBox.Controls.Add(this.OwnerTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType2TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.OwnerLabel);
            this.InternalInfoGroupBox.Controls.Add(this.Communications1TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.OwnerButton);
            this.InternalInfoGroupBox.Controls.Add(this.Communications1Button);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType1TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsLabel);
            this.InternalInfoGroupBox.Controls.Add(this.CorporateIDLabel);
            this.InternalInfoGroupBox.Controls.Add(this.CorporateIDTextBox);
            this.InternalInfoGroupBox.Location = new System.Drawing.Point(320, 32);
            this.InternalInfoGroupBox.Name = "InternalInfoGroupBox";
            this.InternalInfoGroupBox.Size = new System.Drawing.Size(227, 261);
            this.InternalInfoGroupBox.TabIndex = 118;
            this.InternalInfoGroupBox.TabStop = false;
            this.InternalInfoGroupBox.Text = "Internal Information";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(77, 19);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(108, 20);
            this.TypeTextBox.TabIndex = 8;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(40, 23);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 46;
            this.TypeLabel.Text = "Type";
            // 
            // TypeButton
            // 
            this.TypeButton.FlatAppearance.BorderSize = 0;
            this.TypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeButton.Image = ((System.Drawing.Image)(resources.GetObject("TypeButton.Image")));
            this.TypeButton.Location = new System.Drawing.Point(191, 17);
            this.TypeButton.Name = "TypeButton";
            this.TypeButton.Size = new System.Drawing.Size(22, 22);
            this.TypeButton.TabIndex = 9;
            this.TypeButton.Text = " ";
            this.TypeButton.UseVisualStyleBackColor = true;
            this.TypeButton.Click += new System.EventHandler(this.TypeButton_Click);
            // 
            // CommunicationsType2TextBox
            // 
            this.CommunicationsType2TextBox.Location = new System.Drawing.Point(8, 201);
            this.CommunicationsType2TextBox.Name = "CommunicationsType2TextBox";
            this.CommunicationsType2TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType2TextBox.TabIndex = 18;
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(33, 48);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(38, 13);
            this.OwnerLabel.TabIndex = 29;
            this.OwnerLabel.Text = "Owner";
            // 
            // Communications1TextBox
            // 
            this.Communications1TextBox.Location = new System.Drawing.Point(120, 175);
            this.Communications1TextBox.Name = "Communications1TextBox";
            this.Communications1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications1TextBox.TabIndex = 17;
            // 
            // OwnerButton
            // 
            this.OwnerButton.FlatAppearance.BorderSize = 0;
            this.OwnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnerButton.Image = ((System.Drawing.Image)(resources.GetObject("OwnerButton.Image")));
            this.OwnerButton.Location = new System.Drawing.Point(191, 43);
            this.OwnerButton.Name = "OwnerButton";
            this.OwnerButton.Size = new System.Drawing.Size(22, 22);
            this.OwnerButton.TabIndex = 11;
            this.OwnerButton.Text = " ";
            this.OwnerButton.UseVisualStyleBackColor = true;
            this.OwnerButton.Click += new System.EventHandler(this.OwnerButton_Click);
            // 
            // Communications1Button
            // 
            this.Communications1Button.FlatAppearance.BorderSize = 0;
            this.Communications1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications1Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications1Button.Image")));
            this.Communications1Button.Location = new System.Drawing.Point(92, 173);
            this.Communications1Button.Name = "Communications1Button";
            this.Communications1Button.Size = new System.Drawing.Size(22, 22);
            this.Communications1Button.TabIndex = 16;
            this.Communications1Button.Text = " ";
            this.Communications1Button.UseVisualStyleBackColor = true;
            this.Communications1Button.Click += new System.EventHandler(this.Communications1Button_Click);
            // 
            // CommunicationsType1TextBox
            // 
            this.CommunicationsType1TextBox.Location = new System.Drawing.Point(8, 175);
            this.CommunicationsType1TextBox.Name = "CommunicationsType1TextBox";
            this.CommunicationsType1TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType1TextBox.TabIndex = 15;
            // 
            // CommunicationsLabel
            // 
            this.CommunicationsLabel.AutoSize = true;
            this.CommunicationsLabel.Location = new System.Drawing.Point(5, 157);
            this.CommunicationsLabel.Name = "CommunicationsLabel";
            this.CommunicationsLabel.Size = new System.Drawing.Size(84, 13);
            this.CommunicationsLabel.TabIndex = 35;
            this.CommunicationsLabel.Text = "Communications";
            // 
            // CorporateIDLabel
            // 
            this.CorporateIDLabel.AutoSize = true;
            this.CorporateIDLabel.Location = new System.Drawing.Point(4, 74);
            this.CorporateIDLabel.Name = "CorporateIDLabel";
            this.CorporateIDLabel.Size = new System.Drawing.Size(67, 13);
            this.CorporateIDLabel.TabIndex = 33;
            this.CorporateIDLabel.Text = "Corporate ID";
            // 
            // CorporateIDTextBox
            // 
            this.CorporateIDTextBox.Location = new System.Drawing.Point(77, 71);
            this.CorporateIDTextBox.Name = "CorporateIDTextBox";
            this.CorporateIDTextBox.ReadOnly = true;
            this.CorporateIDTextBox.Size = new System.Drawing.Size(136, 20);
            this.CorporateIDTextBox.TabIndex = 12;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(194, 227);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(94, 20);
            this.StateTextBox.TabIndex = 7;
            // 
            // IndividualLabel
            // 
            this.IndividualLabel.AutoSize = true;
            this.IndividualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndividualLabel.Location = new System.Drawing.Point(12, 9);
            this.IndividualLabel.Name = "IndividualLabel";
            this.IndividualLabel.Size = new System.Drawing.Size(75, 20);
            this.IndividualLabel.TabIndex = 116;
            this.IndividualLabel.Text = "Account";
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(88, 19);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(200, 20);
            this.AccountTextBox.TabIndex = 0;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Location = new System.Drawing.Point(47, 22);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(35, 13);
            this.AccountLabel.TabIndex = 1;
            this.AccountLabel.Text = "Name";
            // 
            // AddressInfoGroupBox
            // 
            this.AddressInfoGroupBox.Controls.Add(this.AccountTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.StateTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.AccountLabel);
            this.AddressInfoGroupBox.Controls.Add(this.CountryTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.CountryButton);
            this.AddressInfoGroupBox.Controls.Add(this.CountryStateLabel);
            this.AddressInfoGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.PostalCodeLabel);
            this.AddressInfoGroupBox.Controls.Add(this.CityTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.AddressLabel);
            this.AddressInfoGroupBox.Controls.Add(this.CityLabel);
            this.AddressInfoGroupBox.Controls.Add(this.AddressTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.ARAAddressTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.ARAAddresslabel);
            this.AddressInfoGroupBox.Location = new System.Drawing.Point(16, 32);
            this.AddressInfoGroupBox.Name = "AddressInfoGroupBox";
            this.AddressInfoGroupBox.Size = new System.Drawing.Size(298, 261);
            this.AddressInfoGroupBox.TabIndex = 117;
            this.AddressInfoGroupBox.TabStop = false;
            this.AddressInfoGroupBox.Text = "Address Information";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(88, 227);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(72, 20);
            this.CountryTextBox.TabIndex = 5;
            // 
            // CountryButton
            // 
            this.CountryButton.FlatAppearance.BorderSize = 0;
            this.CountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryButton.Image = ((System.Drawing.Image)(resources.GetObject("CountryButton.Image")));
            this.CountryButton.Location = new System.Drawing.Point(166, 225);
            this.CountryButton.Name = "CountryButton";
            this.CountryButton.Size = new System.Drawing.Size(22, 22);
            this.CountryButton.TabIndex = 6;
            this.CountryButton.Text = " ";
            this.CountryButton.UseVisualStyleBackColor = true;
            this.CountryButton.Click += new System.EventHandler(this.CountryButton_Click);
            // 
            // CountryStateLabel
            // 
            this.CountryStateLabel.AutoSize = true;
            this.CountryStateLabel.Location = new System.Drawing.Point(9, 230);
            this.CountryStateLabel.Name = "CountryStateLabel";
            this.CountryStateLabel.Size = new System.Drawing.Size(73, 13);
            this.CountryStateLabel.TabIndex = 17;
            this.CountryStateLabel.Text = "Country/State";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(88, 201);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.PostalCodeTextBox.TabIndex = 4;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(18, 204);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalCodeLabel.TabIndex = 15;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(88, 175);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(200, 20);
            this.CityTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(37, 100);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(58, 178);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(88, 97);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddressTextBox.TabIndex = 1;
            // 
            // ARAAddressTextBox
            // 
            this.ARAAddressTextBox.Location = new System.Drawing.Point(88, 123);
            this.ARAAddressTextBox.Name = "ARAAddressTextBox";
            this.ARAAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.ARAAddressTextBox.TabIndex = 2;
            // 
            // ARAAddresslabel
            // 
            this.ARAAddresslabel.AutoSize = true;
            this.ARAAddresslabel.Location = new System.Drawing.Point(12, 126);
            this.ARAAddresslabel.Name = "ARAAddresslabel";
            this.ARAAddresslabel.Size = new System.Drawing.Size(70, 13);
            this.ARAAddresslabel.TabIndex = 11;
            this.ARAAddresslabel.Text = "ARA Address";
            // 
            // ProfileOtherSqlCommand
            // 
            this.ProfileOtherSqlCommand.CommandText = "ProfileOtherInsertUpdateDelete";
            this.ProfileOtherSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ProfileOtherSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mode", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@profileid", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0"),
            new System.Data.SqlClient.SqlParameter("@account", System.Data.SqlDbType.NVarChar, 30),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 30),
            new System.Data.SqlClient.SqlParameter("@araaddress", System.Data.SqlDbType.NVarChar, 30),
            new System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.NVarChar, 2),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.NVarChar, 25),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.NVarChar, 20),
            new System.Data.SqlClient.SqlParameter("@postalcode", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@owner", System.Data.SqlDbType.NVarChar, 5),
            new System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.NVarChar, 2),
            new System.Data.SqlClient.SqlParameter("@currency", System.Data.SqlDbType.NVarChar, 3)});
            // 
            // CommunicationSqlCommand
            // 
            this.CommunicationSqlCommand.CommandText = "Communication_ProfilesOtherInsertUpdateDelete";
            this.CommunicationSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.CommunicationSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mode", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@communication", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@profile", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@info", System.Data.SqlDbType.NVarChar, 30)});
            // 
            // OtherProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InternalInfoGroupBox);
            this.Controls.Add(this.IndividualLabel);
            this.Controls.Add(this.AddressInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Profile";
            this.panel1.ResumeLayout(false);
            this.InternalInfoGroupBox.ResumeLayout(false);
            this.InternalInfoGroupBox.PerformLayout();
            this.AddressInfoGroupBox.ResumeLayout(false);
            this.AddressInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.TextBox CurrencyTextBox;
        private System.Windows.Forms.Button CurrencyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox Communications3TextBox;
        private System.Windows.Forms.Button Communications3Button;
        private System.Windows.Forms.TextBox CommunicationsType3TextBox;
        private System.Windows.Forms.TextBox Communications2TextBox;
        private System.Windows.Forms.Button Communications2Button;
        private System.Windows.Forms.TextBox OwnerTextBox;
        private System.Windows.Forms.GroupBox InternalInfoGroupBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button TypeButton;
        private System.Windows.Forms.TextBox CommunicationsType2TextBox;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.TextBox Communications1TextBox;
        private System.Windows.Forms.Button OwnerButton;
        private System.Windows.Forms.Button Communications1Button;
        private System.Windows.Forms.TextBox CommunicationsType1TextBox;
        private System.Windows.Forms.Label CommunicationsLabel;
        private System.Windows.Forms.Label CorporateIDLabel;
        private System.Windows.Forms.TextBox CorporateIDTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Label IndividualLabel;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.GroupBox AddressInfoGroupBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Button CountryButton;
        private System.Windows.Forms.Label CountryStateLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ARAAddressTextBox;
        private System.Windows.Forms.Label ARAAddresslabel;
        private System.Data.SqlClient.SqlCommand ProfileOtherSqlCommand;
        private System.Data.SqlClient.SqlCommand CommunicationSqlCommand;
    }
}