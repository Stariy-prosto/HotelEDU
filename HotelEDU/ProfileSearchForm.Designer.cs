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
            ProfilesDataGridView = new DataGridView();
            ProfileDetailLabel = new Label();
            FutureDataGridView = new DataGridView();
            FutureGroupBox = new GroupBox();
            panel1 = new Panel();
            ReservationButton = new Button();
            OKButton = new Button();
            NewButton = new Button();
            EditButton = new Button();
            CloseButton = new Button();
            ClearButton = new Button();
            SearchButton = new Button();
            NegRatesCheckBox = new CheckBox();
            ShowInavtiveCheckBox = new CheckBox();
            NameLabel = new Label();
            MemTypeLabel = new Label();
            PassportLabel = new Label();
            CityLabel = new Label();
            CommunicationLabel = new Label();
            MemTypeButton = new Button();
            PassportTextBox = new TextBox();
            CityTextBox = new TextBox();
            CityButton = new Button();
            MemTypeTextBox = new TextBox();
            ViewByComboBox = new ComboBox();
            FirstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            NameTextBox = new TextBox();
            ViewByLabel = new Label();
            CommunicationTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FutureDataGridView).BeginInit();
            FutureGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ProfilesDataGridView
            // 
            ProfilesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfilesDataGridView.Dock = DockStyle.Fill;
            ProfilesDataGridView.Location = new Point(2, 124);
            ProfilesDataGridView.Margin = new Padding(2);
            ProfilesDataGridView.Name = "ProfilesDataGridView";
            ProfilesDataGridView.RowHeadersWidth = 51;
            ProfilesDataGridView.RowTemplate.Height = 29;
            ProfilesDataGridView.Size = new Size(600, 118);
            ProfilesDataGridView.TabIndex = 27;
            // 
            // ProfileDetailLabel
            // 
            ProfileDetailLabel.AutoSize = true;
            ProfileDetailLabel.Cursor = Cursors.No;
            ProfileDetailLabel.Dock = DockStyle.Fill;
            ProfileDetailLabel.Location = new Point(2, 244);
            ProfileDetailLabel.Margin = new Padding(2, 0, 2, 0);
            ProfileDetailLabel.Name = "ProfileDetailLabel";
            ProfileDetailLabel.Size = new Size(600, 41);
            ProfileDetailLabel.TabIndex = 28;
            ProfileDetailLabel.Text = "ProfileDetail";
            // 
            // FutureDataGridView
            // 
            FutureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FutureDataGridView.Dock = DockStyle.Fill;
            FutureDataGridView.Location = new Point(2, 17);
            FutureDataGridView.Margin = new Padding(2);
            FutureDataGridView.Name = "FutureDataGridView";
            FutureDataGridView.RowHeadersWidth = 51;
            FutureDataGridView.RowTemplate.Height = 29;
            FutureDataGridView.Size = new Size(596, 101);
            FutureDataGridView.TabIndex = 29;
            // 
            // FutureGroupBox
            // 
            FutureGroupBox.Controls.Add(FutureDataGridView);
            FutureGroupBox.Dock = DockStyle.Fill;
            FutureGroupBox.Location = new Point(2, 287);
            FutureGroupBox.Margin = new Padding(2);
            FutureGroupBox.Name = "FutureGroupBox";
            FutureGroupBox.Padding = new Padding(2);
            FutureGroupBox.Size = new Size(600, 120);
            FutureGroupBox.TabIndex = 36;
            FutureGroupBox.TabStop = false;
            FutureGroupBox.Text = "Future";
            // 
            // panel1
            // 
            panel1.Controls.Add(ReservationButton);
            panel1.Controls.Add(OKButton);
            panel1.Controls.Add(NewButton);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(SearchButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(604, 2);
            panel1.Margin = new Padding(0, 2, 0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 403);
            panel1.TabIndex = 39;
            // 
            // ReservationButton
            // 
            ReservationButton.Dock = DockStyle.Bottom;
            ReservationButton.Location = new Point(0, 288);
            ReservationButton.Name = "ReservationButton";
            ReservationButton.Size = new Size(100, 23);
            ReservationButton.TabIndex = 6;
            ReservationButton.Text = "Resv.";
            ReservationButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            OKButton.Dock = DockStyle.Bottom;
            OKButton.Location = new Point(0, 311);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(100, 23);
            OKButton.TabIndex = 5;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Dock = DockStyle.Bottom;
            NewButton.Location = new Point(0, 334);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(100, 23);
            NewButton.TabIndex = 4;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Bottom;
            EditButton.Location = new Point(0, 357);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 23);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Bottom;
            CloseButton.Location = new Point(0, 380);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(100, 23);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Top;
            ClearButton.Location = new Point(0, 23);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(100, 23);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Top;
            SearchButton.Location = new Point(0, 0);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(100, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // NegRatesCheckBox
            // 
            NegRatesCheckBox.AutoSize = true;
            NegRatesCheckBox.Dock = DockStyle.Fill;
            NegRatesCheckBox.Location = new Point(143, 94);
            NegRatesCheckBox.Margin = new Padding(2);
            NegRatesCheckBox.Name = "NegRatesCheckBox";
            NegRatesCheckBox.Size = new Size(137, 22);
            NegRatesCheckBox.TabIndex = 24;
            NegRatesCheckBox.Text = "Neg. Rates";
            NegRatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowInavtiveCheckBox
            // 
            ShowInavtiveCheckBox.AutoSize = true;
            ShowInavtiveCheckBox.Dock = DockStyle.Fill;
            ShowInavtiveCheckBox.Location = new Point(143, 71);
            ShowInavtiveCheckBox.Margin = new Padding(2);
            ShowInavtiveCheckBox.Name = "ShowInavtiveCheckBox";
            ShowInavtiveCheckBox.Size = new Size(137, 19);
            ShowInavtiveCheckBox.TabIndex = 25;
            ShowInavtiveCheckBox.Text = "Show Inavtive";
            ShowInavtiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Location = new Point(2, 0);
            NameLabel.Margin = new Padding(2, 0, 2, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(137, 23);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            NameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // MemTypeLabel
            // 
            MemTypeLabel.AutoSize = true;
            MemTypeLabel.Dock = DockStyle.Fill;
            MemTypeLabel.Location = new Point(284, 23);
            MemTypeLabel.Margin = new Padding(2, 0, 2, 0);
            MemTypeLabel.Name = "MemTypeLabel";
            MemTypeLabel.Size = new Size(137, 23);
            MemTypeLabel.TabIndex = 3;
            MemTypeLabel.Text = "Mem. Type";
            MemTypeLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // PassportLabel
            // 
            PassportLabel.AutoSize = true;
            PassportLabel.Dock = DockStyle.Fill;
            PassportLabel.Location = new Point(284, 92);
            PassportLabel.Margin = new Padding(2, 0, 2, 0);
            PassportLabel.Name = "PassportLabel";
            PassportLabel.Size = new Size(137, 26);
            PassportLabel.TabIndex = 7;
            PassportLabel.Text = "Passport";
            PassportLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Dock = DockStyle.Fill;
            CityLabel.Location = new Point(284, 0);
            CityLabel.Margin = new Padding(2, 0, 2, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(137, 23);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City";
            CityLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CommunicationLabel
            // 
            CommunicationLabel.AutoSize = true;
            CommunicationLabel.Dock = DockStyle.Fill;
            CommunicationLabel.Location = new Point(284, 69);
            CommunicationLabel.Margin = new Padding(2, 0, 2, 0);
            CommunicationLabel.Name = "CommunicationLabel";
            CommunicationLabel.Size = new Size(137, 23);
            CommunicationLabel.TabIndex = 9;
            CommunicationLabel.Text = "Communication";
            CommunicationLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // MemTypeButton
            // 
            MemTypeButton.Dock = DockStyle.Top;
            MemTypeButton.Location = new Point(566, 25);
            MemTypeButton.Margin = new Padding(2);
            MemTypeButton.Name = "MemTypeButton";
            MemTypeButton.Size = new Size(32, 19);
            MemTypeButton.TabIndex = 21;
            MemTypeButton.Text = " ";
            MemTypeButton.UseVisualStyleBackColor = true;
            MemTypeButton.Click += MemTypeButton_Click;
            // 
            // PassportTextBox
            // 
            PassportTextBox.Dock = DockStyle.Top;
            PassportTextBox.Location = new Point(425, 94);
            PassportTextBox.Margin = new Padding(2);
            PassportTextBox.Name = "PassportTextBox";
            PassportTextBox.Size = new Size(137, 22);
            PassportTextBox.TabIndex = 18;
            // 
            // CityTextBox
            // 
            CityTextBox.Dock = DockStyle.Top;
            CityTextBox.Location = new Point(425, 2);
            CityTextBox.Margin = new Padding(2);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(137, 22);
            CityTextBox.TabIndex = 15;
            // 
            // CityButton
            // 
            CityButton.Dock = DockStyle.Top;
            CityButton.Location = new Point(566, 2);
            CityButton.Margin = new Padding(2);
            CityButton.Name = "CityButton";
            CityButton.Size = new Size(32, 19);
            CityButton.TabIndex = 22;
            CityButton.Text = " ";
            CityButton.UseVisualStyleBackColor = true;
            CityButton.Click += CityButton_Click;
            // 
            // MemTypeTextBox
            // 
            MemTypeTextBox.Dock = DockStyle.Top;
            MemTypeTextBox.Location = new Point(425, 25);
            MemTypeTextBox.Margin = new Padding(2);
            MemTypeTextBox.Name = "MemTypeTextBox";
            MemTypeTextBox.Size = new Size(137, 22);
            MemTypeTextBox.TabIndex = 13;
            // 
            // ViewByComboBox
            // 
            ViewByComboBox.Dock = DockStyle.Top;
            ViewByComboBox.FormattingEnabled = true;
            ViewByComboBox.Location = new Point(143, 48);
            ViewByComboBox.Margin = new Padding(2);
            ViewByComboBox.Name = "ViewByComboBox";
            ViewByComboBox.Size = new Size(137, 21);
            ViewByComboBox.TabIndex = 23;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Dock = DockStyle.Top;
            FirstNameTextBox.Location = new Point(143, 25);
            FirstNameTextBox.Margin = new Padding(2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(137, 22);
            FirstNameTextBox.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Dock = DockStyle.Fill;
            FirstNameLabel.Location = new Point(2, 23);
            FirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(137, 23);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // NameTextBox
            // 
            NameTextBox.Dock = DockStyle.Top;
            NameTextBox.Location = new Point(143, 2);
            NameTextBox.Margin = new Padding(2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(137, 22);
            NameTextBox.TabIndex = 10;
            // 
            // ViewByLabel
            // 
            ViewByLabel.AutoSize = true;
            ViewByLabel.Dock = DockStyle.Fill;
            ViewByLabel.Location = new Point(2, 46);
            ViewByLabel.Margin = new Padding(2, 0, 2, 0);
            ViewByLabel.Name = "ViewByLabel";
            ViewByLabel.Size = new Size(137, 23);
            ViewByLabel.TabIndex = 2;
            ViewByLabel.Text = "View By";
            ViewByLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CommunicationTextBox
            // 
            CommunicationTextBox.Dock = DockStyle.Top;
            CommunicationTextBox.Location = new Point(425, 71);
            CommunicationTextBox.Margin = new Padding(2);
            CommunicationTextBox.Name = "CommunicationTextBox";
            CommunicationTextBox.Size = new Size(137, 22);
            CommunicationTextBox.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(CommunicationTextBox, 3, 3);
            tableLayoutPanel1.Controls.Add(ViewByLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(FirstNameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(FirstNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(ViewByComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MemTypeTextBox, 3, 1);
            tableLayoutPanel1.Controls.Add(CityButton, 4, 0);
            tableLayoutPanel1.Controls.Add(CityTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(PassportTextBox, 3, 4);
            tableLayoutPanel1.Controls.Add(MemTypeButton, 4, 1);
            tableLayoutPanel1.Controls.Add(CommunicationLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(CityLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(PassportLabel, 2, 4);
            tableLayoutPanel1.Controls.Add(MemTypeLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(ShowInavtiveCheckBox, 1, 3);
            tableLayoutPanel1.Controls.Add(NegRatesCheckBox, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(600, 118);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(ProfilesDataGridView, 0, 1);
            tableLayoutPanel3.Controls.Add(ProfileDetailLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(FutureGroupBox, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9850063F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9850063F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0449772F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9850063F));
            tableLayoutPanel3.Size = new Size(604, 409);
            tableLayoutPanel3.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(704, 409);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // ProfileSearchForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 409);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Profile Search";
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FutureDataGridView).EndInit();
            FutureGroupBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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