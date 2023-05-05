using System.Drawing;
using System.Windows.Forms;

namespace HotelEDU
{
    partial class ProfileSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSearchForm));
            this.ProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.ProfileDetailLabel = new System.Windows.Forms.Label();
            this.FutureDataGridView = new System.Windows.Forms.DataGridView();
            this.FutureGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NegRatesCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowInavtiveCheckBox = new System.Windows.Forms.CheckBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MemTypeLabel = new System.Windows.Forms.Label();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CommunicationLabel = new System.Windows.Forms.Label();
            this.MemTypeButton = new System.Windows.Forms.Button();
            this.PassportTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityButton = new System.Windows.Forms.Button();
            this.MemTypeTextBox = new System.Windows.Forms.TextBox();
            this.ViewByComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ViewByLabel = new System.Windows.Forms.Label();
            this.CommunicationTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FutureDataGridView)).BeginInit();
            this.FutureGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilesDataGridView
            // 
            this.ProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilesDataGridView.Location = new System.Drawing.Point(2, 124);
            this.ProfilesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilesDataGridView.Name = "ProfilesDataGridView";
            this.ProfilesDataGridView.RowHeadersWidth = 51;
            this.ProfilesDataGridView.RowTemplate.Height = 29;
            this.ProfilesDataGridView.Size = new System.Drawing.Size(600, 118);
            this.ProfilesDataGridView.TabIndex = 27;
            // 
            // ProfileDetailLabel
            // 
            this.ProfileDetailLabel.AutoSize = true;
            this.ProfileDetailLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.ProfileDetailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileDetailLabel.Location = new System.Drawing.Point(2, 244);
            this.ProfileDetailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProfileDetailLabel.Name = "ProfileDetailLabel";
            this.ProfileDetailLabel.Size = new System.Drawing.Size(600, 41);
            this.ProfileDetailLabel.TabIndex = 28;
            this.ProfileDetailLabel.Text = "ProfileDetail";
            // 
            // FutureDataGridView
            // 
            this.FutureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FutureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureDataGridView.Location = new System.Drawing.Point(2, 15);
            this.FutureDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FutureDataGridView.Name = "FutureDataGridView";
            this.FutureDataGridView.RowHeadersWidth = 51;
            this.FutureDataGridView.RowTemplate.Height = 29;
            this.FutureDataGridView.Size = new System.Drawing.Size(596, 103);
            this.FutureDataGridView.TabIndex = 29;
            // 
            // FutureGroupBox
            // 
            this.FutureGroupBox.Controls.Add(this.FutureDataGridView);
            this.FutureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureGroupBox.Location = new System.Drawing.Point(2, 287);
            this.FutureGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.FutureGroupBox.Name = "FutureGroupBox";
            this.FutureGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.FutureGroupBox.Size = new System.Drawing.Size(600, 120);
            this.FutureGroupBox.TabIndex = 36;
            this.FutureGroupBox.TabStop = false;
            this.FutureGroupBox.Text = "Future";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReservationButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(604, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 403);
            this.panel1.TabIndex = 39;
            // 
            // ReservationButton
            // 
            this.ReservationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReservationButton.Location = new System.Drawing.Point(0, 288);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(100, 23);
            this.ReservationButton.TabIndex = 6;
            this.ReservationButton.Text = "Resv.";
            this.ReservationButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.Location = new System.Drawing.Point(0, 311);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewButton.Location = new System.Drawing.Point(0, 334);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(100, 23);
            this.NewButton.TabIndex = 4;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditButton.Location = new System.Drawing.Point(0, 357);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 380);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearButton.Location = new System.Drawing.Point(0, 23);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.Location = new System.Drawing.Point(0, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // NegRatesCheckBox
            // 
            this.NegRatesCheckBox.AutoSize = true;
            this.NegRatesCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegRatesCheckBox.Location = new System.Drawing.Point(143, 94);
            this.NegRatesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.NegRatesCheckBox.Name = "NegRatesCheckBox";
            this.NegRatesCheckBox.Size = new System.Drawing.Size(137, 22);
            this.NegRatesCheckBox.TabIndex = 24;
            this.NegRatesCheckBox.Text = "Neg. Rates";
            this.NegRatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowInavtiveCheckBox
            // 
            this.ShowInavtiveCheckBox.AutoSize = true;
            this.ShowInavtiveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowInavtiveCheckBox.Location = new System.Drawing.Point(143, 71);
            this.ShowInavtiveCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowInavtiveCheckBox.Name = "ShowInavtiveCheckBox";
            this.ShowInavtiveCheckBox.Size = new System.Drawing.Size(137, 19);
            this.ShowInavtiveCheckBox.TabIndex = 25;
            this.ShowInavtiveCheckBox.Text = "Show Inavtive";
            this.ShowInavtiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(2, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MemTypeLabel
            // 
            this.MemTypeLabel.AutoSize = true;
            this.MemTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemTypeLabel.Location = new System.Drawing.Point(284, 23);
            this.MemTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemTypeLabel.Name = "MemTypeLabel";
            this.MemTypeLabel.Size = new System.Drawing.Size(137, 23);
            this.MemTypeLabel.TabIndex = 3;
            this.MemTypeLabel.Text = "Mem. Type";
            this.MemTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassportLabel.Location = new System.Drawing.Point(284, 92);
            this.PassportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(137, 26);
            this.PassportLabel.TabIndex = 7;
            this.PassportLabel.Text = "Passport";
            this.PassportLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityLabel.Location = new System.Drawing.Point(284, 0);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(137, 23);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CommunicationLabel
            // 
            this.CommunicationLabel.AutoSize = true;
            this.CommunicationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommunicationLabel.Location = new System.Drawing.Point(284, 69);
            this.CommunicationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommunicationLabel.Name = "CommunicationLabel";
            this.CommunicationLabel.Size = new System.Drawing.Size(137, 23);
            this.CommunicationLabel.TabIndex = 9;
            this.CommunicationLabel.Text = "Communication";
            this.CommunicationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MemTypeButton
            // 
            this.MemTypeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemTypeButton.Location = new System.Drawing.Point(566, 25);
            this.MemTypeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MemTypeButton.Name = "MemTypeButton";
            this.MemTypeButton.Size = new System.Drawing.Size(32, 19);
            this.MemTypeButton.TabIndex = 21;
            this.MemTypeButton.Text = " ";
            this.MemTypeButton.UseVisualStyleBackColor = true;
            // 
            // PassportTextBox
            // 
            this.PassportTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassportTextBox.Location = new System.Drawing.Point(425, 94);
            this.PassportTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassportTextBox.Name = "PassportTextBox";
            this.PassportTextBox.Size = new System.Drawing.Size(137, 20);
            this.PassportTextBox.TabIndex = 18;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CityTextBox.Location = new System.Drawing.Point(425, 2);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(137, 20);
            this.CityTextBox.TabIndex = 15;
            // 
            // CityButton
            // 
            this.CityButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CityButton.Location = new System.Drawing.Point(566, 2);
            this.CityButton.Margin = new System.Windows.Forms.Padding(2);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(32, 19);
            this.CityButton.TabIndex = 22;
            this.CityButton.Text = " ";
            this.CityButton.UseVisualStyleBackColor = true;
            // 
            // MemTypeTextBox
            // 
            this.MemTypeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemTypeTextBox.Location = new System.Drawing.Point(425, 25);
            this.MemTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemTypeTextBox.Name = "MemTypeTextBox";
            this.MemTypeTextBox.Size = new System.Drawing.Size(137, 20);
            this.MemTypeTextBox.TabIndex = 13;
            // 
            // ViewByComboBox
            // 
            this.ViewByComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewByComboBox.FormattingEnabled = true;
            this.ViewByComboBox.Location = new System.Drawing.Point(143, 48);
            this.ViewByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ViewByComboBox.Name = "ViewByComboBox";
            this.ViewByComboBox.Size = new System.Drawing.Size(137, 21);
            this.ViewByComboBox.TabIndex = 23;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNameTextBox.Location = new System.Drawing.Point(143, 25);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.FirstNameTextBox.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameLabel.Location = new System.Drawing.Point(2, 23);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(137, 23);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextBox.Location = new System.Drawing.Point(143, 2);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(137, 20);
            this.NameTextBox.TabIndex = 10;
            // 
            // ViewByLabel
            // 
            this.ViewByLabel.AutoSize = true;
            this.ViewByLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewByLabel.Location = new System.Drawing.Point(2, 46);
            this.ViewByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViewByLabel.Name = "ViewByLabel";
            this.ViewByLabel.Size = new System.Drawing.Size(137, 23);
            this.ViewByLabel.TabIndex = 2;
            this.ViewByLabel.Text = "View By";
            this.ViewByLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CommunicationTextBox
            // 
            this.CommunicationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommunicationTextBox.Location = new System.Drawing.Point(425, 71);
            this.CommunicationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommunicationTextBox.Name = "CommunicationTextBox";
            this.CommunicationTextBox.Size = new System.Drawing.Size(137, 20);
            this.CommunicationTextBox.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Controls.Add(this.CommunicationTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ViewByLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewByComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MemTypeTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CityButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CityTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PassportTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.MemTypeButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.CommunicationLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.CityLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PassportLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.MemTypeLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowInavtiveCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NegRatesCheckBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 118);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProfilesDataGridView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ProfileDetailLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.FutureGroupBox, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.98501F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.98501F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.04498F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.98501F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(604, 409);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 409);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // ProfileSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 409);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Profile Search";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FutureDataGridView)).EndInit();
            this.FutureGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView ProfilesDataGridView;
        private Label ProfileDetailLabel;
        private DataGridView FutureDataGridView;
        private Button SearchButton;
        private Button ClearButton;
        private Button CloseButton;
        private GroupBox FutureGroupBox;
        private Panel panel1;
        private CheckBox NegRatesCheckBox;
        private CheckBox ShowInavtiveCheckBox;
        private Label NameLabel;
        private Label MemTypeLabel;
        private Label PassportLabel;
        private Label CityLabel;
        private Label CommunicationLabel;
        private Button MemTypeButton;
        private TextBox PassportTextBox;
        private TextBox CityTextBox;
        private Button CityButton;
        private TextBox MemTypeTextBox;
        private ComboBox ViewByComboBox;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
        private TextBox NameTextBox;
        private Label ViewByLabel;
        private TextBox CommunicationTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button NewButton;
        private Button EditButton;
        private Button ReservationButton;
        private Button OKButton;
    }
}