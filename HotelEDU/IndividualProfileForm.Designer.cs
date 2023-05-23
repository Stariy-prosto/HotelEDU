namespace HotelEDU
{
    partial class IndividualProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualProfileForm));
            this.IndividualLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FistMiddleLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageButton = new System.Windows.Forms.Button();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.HomeAddressTextBox = new System.Windows.Forms.TextBox();
            this.HomeAddresslabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.CountryStateLabel = new System.Windows.Forms.Label();
            this.CountryButton = new System.Windows.Forms.Button();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.AddressInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SalutationLabel = new System.Windows.Forms.Label();
            this.SalutationTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CurrencyTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyButton = new System.Windows.Forms.Button();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBitrhCalendarButton = new System.Windows.Forms.Button();
            this.PassportTextButton = new System.Windows.Forms.TextBox();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.ClientIDLabel = new System.Windows.Forms.Label();
            this.ClientIDTextBox = new System.Windows.Forms.TextBox();
            this.CommunicationsLabel = new System.Windows.Forms.Label();
            this.CommunicationsType1TextBox = new System.Windows.Forms.TextBox();
            this.Communications1Button = new System.Windows.Forms.Button();
            this.Communications1TextBox = new System.Windows.Forms.TextBox();
            this.Communications2TextBox = new System.Windows.Forms.TextBox();
            this.Communications2Button = new System.Windows.Forms.Button();
            this.CommunicationsType2TextBox = new System.Windows.Forms.TextBox();
            this.Communications3TextBox = new System.Windows.Forms.TextBox();
            this.Communications3Button = new System.Windows.Forms.Button();
            this.CommunicationsType3TextBox = new System.Windows.Forms.TextBox();
            this.InternalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ProfileIndividualsqlCommand = new System.Data.SqlClient.SqlCommand();
            this.CommunicationSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.AddressInfoGroupBox.SuspendLayout();
            this.InternalInfoGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IndividualLabel
            // 
            this.IndividualLabel.AutoSize = true;
            this.IndividualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndividualLabel.Location = new System.Drawing.Point(8, 9);
            this.IndividualLabel.Name = "IndividualLabel";
            this.IndividualLabel.Size = new System.Drawing.Size(85, 20);
            this.IndividualLabel.TabIndex = 0;
            this.IndividualLabel.Text = "Individual";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(24, 22);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(88, 19);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // FistMiddleLabel
            // 
            this.FistMiddleLabel.AutoSize = true;
            this.FistMiddleLabel.Location = new System.Drawing.Point(23, 48);
            this.FistMiddleLabel.Name = "FistMiddleLabel";
            this.FistMiddleLabel.Size = new System.Drawing.Size(59, 13);
            this.FistMiddleLabel.TabIndex = 3;
            this.FistMiddleLabel.Text = "Fist/Middle";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(88, 45);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(188, 45);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleNameTextBox.TabIndex = 2;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(27, 74);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(55, 13);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageButton
            // 
            this.LanguageButton.FlatAppearance.BorderSize = 0;
            this.LanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageButton.Image = global::HotelEDU.Properties.Resources.Download_Btn_20;
            this.LanguageButton.Location = new System.Drawing.Point(266, 69);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(22, 22);
            this.LanguageButton.TabIndex = 4;
            this.LanguageButton.TabStop = false;
            this.LanguageButton.UseVisualStyleBackColor = true;
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(88, 71);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(172, 20);
            this.LanguageTextBox.TabIndex = 3;
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
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(88, 97);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // HomeAddressTextBox
            // 
            this.HomeAddressTextBox.Location = new System.Drawing.Point(88, 123);
            this.HomeAddressTextBox.Name = "HomeAddressTextBox";
            this.HomeAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.HomeAddressTextBox.TabIndex = 6;
            // 
            // HomeAddresslabel
            // 
            this.HomeAddresslabel.AutoSize = true;
            this.HomeAddresslabel.Location = new System.Drawing.Point(6, 126);
            this.HomeAddresslabel.Name = "HomeAddresslabel";
            this.HomeAddresslabel.Size = new System.Drawing.Size(76, 13);
            this.HomeAddresslabel.TabIndex = 11;
            this.HomeAddresslabel.Text = "Home Address";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(88, 175);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(200, 20);
            this.CityTextBox.TabIndex = 7;
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
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(88, 201);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.PostalCodeTextBox.TabIndex = 8;
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
            // CountryStateLabel
            // 
            this.CountryStateLabel.AutoSize = true;
            this.CountryStateLabel.Location = new System.Drawing.Point(9, 230);
            this.CountryStateLabel.Name = "CountryStateLabel";
            this.CountryStateLabel.Size = new System.Drawing.Size(73, 13);
            this.CountryStateLabel.TabIndex = 17;
            this.CountryStateLabel.Text = "Country/State";
            // 
            // CountryButton
            // 
            this.CountryButton.FlatAppearance.BorderSize = 0;
            this.CountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryButton.Image = ((System.Drawing.Image)(resources.GetObject("CountryButton.Image")));
            this.CountryButton.Location = new System.Drawing.Point(166, 225);
            this.CountryButton.Name = "CountryButton";
            this.CountryButton.Size = new System.Drawing.Size(22, 22);
            this.CountryButton.TabIndex = 10;
            this.CountryButton.TabStop = false;
            this.CountryButton.Text = " ";
            this.CountryButton.UseVisualStyleBackColor = true;
            this.CountryButton.Click += new System.EventHandler(this.CountryButton_Click);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(88, 227);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(72, 20);
            this.CountryTextBox.TabIndex = 9;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(194, 227);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(94, 20);
            this.StateTextBox.TabIndex = 11;
            // 
            // AddressInfoGroupBox
            // 
            this.AddressInfoGroupBox.Controls.Add(this.LastNameTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.StateTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.LastNameLabel);
            this.AddressInfoGroupBox.Controls.Add(this.FistMiddleLabel);
            this.AddressInfoGroupBox.Controls.Add(this.CountryTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.CountryButton);
            this.AddressInfoGroupBox.Controls.Add(this.MiddleNameTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.CountryStateLabel);
            this.AddressInfoGroupBox.Controls.Add(this.LanguageLabel);
            this.AddressInfoGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.LanguageButton);
            this.AddressInfoGroupBox.Controls.Add(this.PostalCodeLabel);
            this.AddressInfoGroupBox.Controls.Add(this.LanguageTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.CityTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.AddressLabel);
            this.AddressInfoGroupBox.Controls.Add(this.CityLabel);
            this.AddressInfoGroupBox.Controls.Add(this.AddressTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.HomeAddressTextBox);
            this.AddressInfoGroupBox.Controls.Add(this.HomeAddresslabel);
            this.AddressInfoGroupBox.Location = new System.Drawing.Point(12, 32);
            this.AddressInfoGroupBox.Name = "AddressInfoGroupBox";
            this.AddressInfoGroupBox.Size = new System.Drawing.Size(298, 286);
            this.AddressInfoGroupBox.TabIndex = 22;
            this.AddressInfoGroupBox.TabStop = false;
            this.AddressInfoGroupBox.Text = "Address Information";
            // 
            // SalutationLabel
            // 
            this.SalutationLabel.AutoSize = true;
            this.SalutationLabel.Location = new System.Drawing.Point(18, 22);
            this.SalutationLabel.Name = "SalutationLabel";
            this.SalutationLabel.Size = new System.Drawing.Size(54, 13);
            this.SalutationLabel.TabIndex = 23;
            this.SalutationLabel.Text = "Salutation";
            // 
            // SalutationTextBox
            // 
            this.SalutationTextBox.Location = new System.Drawing.Point(78, 19);
            this.SalutationTextBox.Name = "SalutationTextBox";
            this.SalutationTextBox.Size = new System.Drawing.Size(136, 20);
            this.SalutationTextBox.TabIndex = 12;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(23, 48);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrencyLabel.TabIndex = 25;
            this.CurrencyLabel.Text = "Currency";
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Location = new System.Drawing.Point(78, 45);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(108, 20);
            this.CurrencyTextBox.TabIndex = 13;
            // 
            // CurrencyButton
            // 
            this.CurrencyButton.FlatAppearance.BorderSize = 0;
            this.CurrencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencyButton.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyButton.Image")));
            this.CurrencyButton.Location = new System.Drawing.Point(192, 43);
            this.CurrencyButton.Name = "CurrencyButton";
            this.CurrencyButton.Size = new System.Drawing.Size(22, 22);
            this.CurrencyButton.TabIndex = 14;
            this.CurrencyButton.TabStop = false;
            this.CurrencyButton.Text = " ";
            this.CurrencyButton.UseVisualStyleBackColor = true;
            this.CurrencyButton.Click += new System.EventHandler(this.CurrencyButton_Click);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(6, 100);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(66, 13);
            this.DateOfBirthLabel.TabIndex = 29;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // DateOfBitrhCalendarButton
            // 
            this.DateOfBitrhCalendarButton.FlatAppearance.BorderSize = 0;
            this.DateOfBitrhCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateOfBitrhCalendarButton.Image = global::HotelEDU.Properties.Resources.Calendar_Btn_20;
            this.DateOfBitrhCalendarButton.Location = new System.Drawing.Point(192, 95);
            this.DateOfBitrhCalendarButton.Name = "DateOfBitrhCalendarButton";
            this.DateOfBitrhCalendarButton.Size = new System.Drawing.Size(22, 22);
            this.DateOfBitrhCalendarButton.TabIndex = 16;
            this.DateOfBitrhCalendarButton.UseVisualStyleBackColor = true;
            this.DateOfBitrhCalendarButton.Click += new System.EventHandler(this.DateOfBitrhCalendarButton_Click);
            // 
            // PassportTextButton
            // 
            this.PassportTextButton.Location = new System.Drawing.Point(78, 123);
            this.PassportTextButton.Name = "PassportTextButton";
            this.PassportTextButton.Size = new System.Drawing.Size(136, 20);
            this.PassportTextButton.TabIndex = 17;
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Location = new System.Drawing.Point(24, 126);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(48, 13);
            this.PassportLabel.TabIndex = 32;
            this.PassportLabel.Text = "Passport";
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(28, 152);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(44, 13);
            this.ClientIDLabel.TabIndex = 33;
            this.ClientIDLabel.Text = "ClientID";
            // 
            // ClientIDTextBox
            // 
            this.ClientIDTextBox.Location = new System.Drawing.Point(78, 149);
            this.ClientIDTextBox.Name = "ClientIDTextBox";
            this.ClientIDTextBox.ReadOnly = true;
            this.ClientIDTextBox.Size = new System.Drawing.Size(136, 20);
            this.ClientIDTextBox.TabIndex = 34;
            // 
            // CommunicationsLabel
            // 
            this.CommunicationsLabel.AutoSize = true;
            this.CommunicationsLabel.Location = new System.Drawing.Point(6, 183);
            this.CommunicationsLabel.Name = "CommunicationsLabel";
            this.CommunicationsLabel.Size = new System.Drawing.Size(84, 13);
            this.CommunicationsLabel.TabIndex = 35;
            this.CommunicationsLabel.Text = "Communications";
            // 
            // CommunicationsType1TextBox
            // 
            this.CommunicationsType1TextBox.Location = new System.Drawing.Point(9, 201);
            this.CommunicationsType1TextBox.Name = "CommunicationsType1TextBox";
            this.CommunicationsType1TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType1TextBox.TabIndex = 18;
            // 
            // Communications1Button
            // 
            this.Communications1Button.FlatAppearance.BorderSize = 0;
            this.Communications1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications1Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications1Button.Image")));
            this.Communications1Button.Location = new System.Drawing.Point(93, 199);
            this.Communications1Button.Name = "Communications1Button";
            this.Communications1Button.Size = new System.Drawing.Size(22, 22);
            this.Communications1Button.TabIndex = 19;
            this.Communications1Button.Text = " ";
            this.Communications1Button.UseVisualStyleBackColor = true;
            this.Communications1Button.Click += new System.EventHandler(this.Communications1Button_Click);
            // 
            // Communications1TextBox
            // 
            this.Communications1TextBox.Location = new System.Drawing.Point(121, 201);
            this.Communications1TextBox.Name = "Communications1TextBox";
            this.Communications1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications1TextBox.TabIndex = 20;
            // 
            // Communications2TextBox
            // 
            this.Communications2TextBox.Location = new System.Drawing.Point(121, 227);
            this.Communications2TextBox.Name = "Communications2TextBox";
            this.Communications2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications2TextBox.TabIndex = 23;
            // 
            // Communications2Button
            // 
            this.Communications2Button.FlatAppearance.BorderSize = 0;
            this.Communications2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications2Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications2Button.Image")));
            this.Communications2Button.Location = new System.Drawing.Point(93, 225);
            this.Communications2Button.Name = "Communications2Button";
            this.Communications2Button.Size = new System.Drawing.Size(22, 22);
            this.Communications2Button.TabIndex = 22;
            this.Communications2Button.Text = " ";
            this.Communications2Button.UseVisualStyleBackColor = true;
            this.Communications2Button.Click += new System.EventHandler(this.Communications2Button_Click);
            // 
            // CommunicationsType2TextBox
            // 
            this.CommunicationsType2TextBox.Location = new System.Drawing.Point(9, 227);
            this.CommunicationsType2TextBox.Name = "CommunicationsType2TextBox";
            this.CommunicationsType2TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType2TextBox.TabIndex = 21;
            // 
            // Communications3TextBox
            // 
            this.Communications3TextBox.Location = new System.Drawing.Point(121, 253);
            this.Communications3TextBox.Name = "Communications3TextBox";
            this.Communications3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Communications3TextBox.TabIndex = 26;
            // 
            // Communications3Button
            // 
            this.Communications3Button.FlatAppearance.BorderSize = 0;
            this.Communications3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Communications3Button.Image = ((System.Drawing.Image)(resources.GetObject("Communications3Button.Image")));
            this.Communications3Button.Location = new System.Drawing.Point(93, 251);
            this.Communications3Button.Name = "Communications3Button";
            this.Communications3Button.Size = new System.Drawing.Size(22, 22);
            this.Communications3Button.TabIndex = 25;
            this.Communications3Button.Text = " ";
            this.Communications3Button.UseVisualStyleBackColor = true;
            this.Communications3Button.Click += new System.EventHandler(this.Communications3Button_Click);
            // 
            // CommunicationsType3TextBox
            // 
            this.CommunicationsType3TextBox.Location = new System.Drawing.Point(9, 253);
            this.CommunicationsType3TextBox.Name = "CommunicationsType3TextBox";
            this.CommunicationsType3TextBox.Size = new System.Drawing.Size(78, 20);
            this.CommunicationsType3TextBox.TabIndex = 24;
            // 
            // InternalInfoGroupBox
            // 
            this.InternalInfoGroupBox.Controls.Add(this.DateOfBirthMaskedTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.SalutationTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.Communications3TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.SalutationLabel);
            this.InternalInfoGroupBox.Controls.Add(this.Communications3Button);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyLabel);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType3TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyTextBox);
            this.InternalInfoGroupBox.Controls.Add(this.Communications2TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.CurrencyButton);
            this.InternalInfoGroupBox.Controls.Add(this.Communications2Button);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType2TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.InternalInfoGroupBox.Controls.Add(this.Communications1TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.DateOfBitrhCalendarButton);
            this.InternalInfoGroupBox.Controls.Add(this.Communications1Button);
            this.InternalInfoGroupBox.Controls.Add(this.PassportTextButton);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsType1TextBox);
            this.InternalInfoGroupBox.Controls.Add(this.PassportLabel);
            this.InternalInfoGroupBox.Controls.Add(this.CommunicationsLabel);
            this.InternalInfoGroupBox.Controls.Add(this.ClientIDLabel);
            this.InternalInfoGroupBox.Controls.Add(this.ClientIDTextBox);
            this.InternalInfoGroupBox.Location = new System.Drawing.Point(316, 32);
            this.InternalInfoGroupBox.Name = "InternalInfoGroupBox";
            this.InternalInfoGroupBox.Size = new System.Drawing.Size(235, 286);
            this.InternalInfoGroupBox.TabIndex = 45;
            this.InternalInfoGroupBox.TabStop = false;
            this.InternalInfoGroupBox.Text = "Internal Information";
            // 
            // DateOfBirthMaskedTextBox
            // 
            this.DateOfBirthMaskedTextBox.Location = new System.Drawing.Point(78, 97);
            this.DateOfBirthMaskedTextBox.Mask = "00-00-0000";
            this.DateOfBirthMaskedTextBox.Name = "DateOfBirthMaskedTextBox";
            this.DateOfBirthMaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.DateOfBirthMaskedTextBox.TabIndex = 15;
            this.DateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Location = new System.Drawing.Point(557, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 306);
            this.panel1.TabIndex = 115;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 280);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 32;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(3, 251);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 31;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 222);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(3, 193);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 29;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ProfileIndividualsqlCommand
            // 
            this.ProfileIndividualsqlCommand.CommandText = "ProfileIndividualInsertUpdateDelete";
            this.ProfileIndividualsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ProfileIndividualsqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mode", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@profileid", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0"),
            new System.Data.SqlClient.SqlParameter("@lastname", System.Data.SqlDbType.NVarChar, 32),
            new System.Data.SqlClient.SqlParameter("@firstname", System.Data.SqlDbType.NVarChar, 30),
            new System.Data.SqlClient.SqlParameter("@middlename", System.Data.SqlDbType.NVarChar, 30),
            new System.Data.SqlClient.SqlParameter("@language", System.Data.SqlDbType.NVarChar, 2),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 40),
            new System.Data.SqlClient.SqlParameter("@homeaddress", System.Data.SqlDbType.NVarChar, 40),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.NVarChar, 20),
            new System.Data.SqlClient.SqlParameter("@postalcode", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.NVarChar, 2),
            new System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.NVarChar, 25),
            new System.Data.SqlClient.SqlParameter("@solutation", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@currency", System.Data.SqlDbType.NVarChar, 3),
            new System.Data.SqlClient.SqlParameter("@dateofbirth", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@passport", System.Data.SqlDbType.NVarChar, 11)});
            // 
            // CommunicationSqlCommand
            // 
            this.CommunicationSqlCommand.CommandText = "Communication_ProfileIndividualInsertUpdateDelete";
            this.CommunicationSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.CommunicationSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@mode", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@profile", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@communication", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@info", System.Data.SqlDbType.NVarChar, 30)});
            // 
            // IndividualProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InternalInfoGroupBox);
            this.Controls.Add(this.AddressInfoGroupBox);
            this.Controls.Add(this.IndividualLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndividualProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual Profile ID - ?";
            this.AddressInfoGroupBox.ResumeLayout(false);
            this.AddressInfoGroupBox.PerformLayout();
            this.InternalInfoGroupBox.ResumeLayout(false);
            this.InternalInfoGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndividualLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FistMiddleLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button LanguageButton;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox HomeAddressTextBox;
        private System.Windows.Forms.Label HomeAddresslabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label CountryStateLabel;
        private System.Windows.Forms.Button CountryButton;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.GroupBox AddressInfoGroupBox;
        private System.Windows.Forms.Label SalutationLabel;
        private System.Windows.Forms.TextBox SalutationTextBox;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.TextBox CurrencyTextBox;
        private System.Windows.Forms.Button CurrencyButton;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Button DateOfBitrhCalendarButton;
        private System.Windows.Forms.TextBox PassportTextButton;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.Label ClientIDLabel;
        private System.Windows.Forms.TextBox ClientIDTextBox;
        private System.Windows.Forms.Label CommunicationsLabel;
        private System.Windows.Forms.TextBox CommunicationsType1TextBox;
        private System.Windows.Forms.Button Communications1Button;
        private System.Windows.Forms.TextBox Communications1TextBox;
        private System.Windows.Forms.TextBox Communications2TextBox;
        private System.Windows.Forms.Button Communications2Button;
        private System.Windows.Forms.TextBox CommunicationsType2TextBox;
        private System.Windows.Forms.TextBox Communications3TextBox;
        private System.Windows.Forms.Button Communications3Button;
        private System.Windows.Forms.TextBox CommunicationsType3TextBox;
        private System.Windows.Forms.GroupBox InternalInfoGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OKButton;
        private System.Data.SqlClient.SqlCommand ProfileIndividualsqlCommand;
        private System.Windows.Forms.MaskedTextBox DateOfBirthMaskedTextBox;
        private System.Data.SqlClient.SqlCommand CommunicationSqlCommand;
    }
}