namespace HotelEDU
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            ExitButton = new Button();
            HelpTabPage = new TabPage();
            tableLayoutPanel13 = new TableLayoutPanel();
            AboutProgramButton = new Button();
            BackOfficeInterfaceTabPage = new TabPage();
            tableLayoutPanel12 = new TableLayoutPanel();
            SetupTabPage = new TabPage();
            tableLayoutPanel11 = new TableLayoutPanel();
            MiscellaneousTabPage = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            CommissionsTabPage = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            ARTabPage = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            RoomsManagmentTabPage = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            RoomHistoryButton = new Button();
            OccupancyGraphButton = new Button();
            HousekeepingButton = new Button();
            OutOfOrderServiceButton = new Button();
            CasheiringTabPage = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            PasserByButton = new Button();
            CashierFunctionsButton = new Button();
            CashierShiftFunctionsButton = new Button();
            BillingButton = new Button();
            FastPostingButton = new Button();
            QuickCheckOutButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            RoomAssigmentButton = new Button();
            MessagesButton = new Button();
            TracesButton = new Button();
            ArrivalsButton = new Button();
            InHouseGuestsButton = new Button();
            AccountsButton = new Button();
            ReservationsTabPage = new TabPage();
            ReservationsLayoutPanel = new TableLayoutPanel();
            ConfirmationButton = new Button();
            FloorPlanButton = new Button();
            CalendarButton = new Button();
            RegistrationCardsButton = new Button();
            RoomPlanButton = new Button();
            UpdateReservationButton = new Button();
            NewReservationButton = new Button();
            ProfilesButton = new Button();
            BlocksButton = new Button();
            MenuControl = new TabControl();
            FrontDeskTabPage = new TabPage();
            ExitTabPage = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip1.SuspendLayout();
            HelpTabPage.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            BackOfficeInterfaceTabPage.SuspendLayout();
            SetupTabPage.SuspendLayout();
            MiscellaneousTabPage.SuspendLayout();
            CommissionsTabPage.SuspendLayout();
            ARTabPage.SuspendLayout();
            RoomsManagmentTabPage.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            CasheiringTabPage.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ReservationsTabPage.SuspendLayout();
            ReservationsLayoutPanel.SuspendLayout();
            MenuControl.SuspendLayout();
            FrontDeskTabPage.SuspendLayout();
            ExitTabPage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1120, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(94, 17);
            toolStripStatusLabel1.Text = "Stariy X Zaguzga";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.Size = new Size(200, 100);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(4, 3);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(544, 106);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HelpTabPage
            // 
            HelpTabPage.Controls.Add(tableLayoutPanel13);
            HelpTabPage.Location = new Point(4, 24);
            HelpTabPage.Margin = new Padding(4, 3, 4, 3);
            HelpTabPage.Name = "HelpTabPage";
            HelpTabPage.Padding = new Padding(4, 3, 4, 3);
            HelpTabPage.Size = new Size(1112, 118);
            HelpTabPage.TabIndex = 9;
            HelpTabPage.Text = "Help";
            HelpTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(AboutProgramButton, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(4, 3);
            tableLayoutPanel13.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(1104, 112);
            tableLayoutPanel13.TabIndex = 18;
            // 
            // AboutProgramButton
            // 
            AboutProgramButton.Dock = DockStyle.Fill;
            AboutProgramButton.FlatAppearance.BorderSize = 0;
            AboutProgramButton.FlatStyle = FlatStyle.Flat;
            AboutProgramButton.Image = (Image)resources.GetObject("AboutProgramButton.Image");
            AboutProgramButton.Location = new Point(4, 3);
            AboutProgramButton.Margin = new Padding(4, 3, 4, 3);
            AboutProgramButton.Name = "AboutProgramButton";
            AboutProgramButton.Size = new Size(544, 106);
            AboutProgramButton.TabIndex = 5;
            AboutProgramButton.Text = "AboutProgram";
            AboutProgramButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AboutProgramButton.UseVisualStyleBackColor = true;
            AboutProgramButton.Click += AboutProgramButton_Click;
            // 
            // BackOfficeInterfaceTabPage
            // 
            BackOfficeInterfaceTabPage.Controls.Add(tableLayoutPanel12);
            BackOfficeInterfaceTabPage.Location = new Point(4, 24);
            BackOfficeInterfaceTabPage.Margin = new Padding(4, 3, 4, 3);
            BackOfficeInterfaceTabPage.Name = "BackOfficeInterfaceTabPage";
            BackOfficeInterfaceTabPage.Padding = new Padding(4, 3, 4, 3);
            BackOfficeInterfaceTabPage.Size = new Size(1112, 118);
            BackOfficeInterfaceTabPage.TabIndex = 8;
            BackOfficeInterfaceTabPage.Text = "Back Office Interface";
            BackOfficeInterfaceTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(4, 3);
            tableLayoutPanel12.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(1104, 112);
            tableLayoutPanel12.TabIndex = 18;
            // 
            // SetupTabPage
            // 
            SetupTabPage.Controls.Add(tableLayoutPanel11);
            SetupTabPage.Location = new Point(4, 24);
            SetupTabPage.Margin = new Padding(4, 3, 4, 3);
            SetupTabPage.Name = "SetupTabPage";
            SetupTabPage.Padding = new Padding(4, 3, 4, 3);
            SetupTabPage.Size = new Size(1112, 118);
            SetupTabPage.TabIndex = 7;
            SetupTabPage.Text = "Setup";
            SetupTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(4, 3);
            tableLayoutPanel11.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(1104, 112);
            tableLayoutPanel11.TabIndex = 18;
            // 
            // MiscellaneousTabPage
            // 
            MiscellaneousTabPage.Controls.Add(tableLayoutPanel9);
            MiscellaneousTabPage.Location = new Point(4, 24);
            MiscellaneousTabPage.Margin = new Padding(4, 3, 4, 3);
            MiscellaneousTabPage.Name = "MiscellaneousTabPage";
            MiscellaneousTabPage.Padding = new Padding(4, 3, 4, 3);
            MiscellaneousTabPage.Size = new Size(1112, 118);
            MiscellaneousTabPage.TabIndex = 6;
            MiscellaneousTabPage.Text = "Miscellaneous";
            MiscellaneousTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(4, 3);
            tableLayoutPanel9.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(1104, 112);
            tableLayoutPanel9.TabIndex = 18;
            // 
            // CommissionsTabPage
            // 
            CommissionsTabPage.Controls.Add(tableLayoutPanel8);
            CommissionsTabPage.Location = new Point(4, 24);
            CommissionsTabPage.Margin = new Padding(4, 3, 4, 3);
            CommissionsTabPage.Name = "CommissionsTabPage";
            CommissionsTabPage.Padding = new Padding(4, 3, 4, 3);
            CommissionsTabPage.Size = new Size(1112, 118);
            CommissionsTabPage.TabIndex = 5;
            CommissionsTabPage.Text = "Commissions";
            CommissionsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(4, 3);
            tableLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(1104, 112);
            tableLayoutPanel8.TabIndex = 18;
            // 
            // ARTabPage
            // 
            ARTabPage.Controls.Add(tableLayoutPanel6);
            ARTabPage.Location = new Point(4, 24);
            ARTabPage.Margin = new Padding(4, 3, 4, 3);
            ARTabPage.Name = "ARTabPage";
            ARTabPage.Padding = new Padding(4, 3, 4, 3);
            ARTabPage.Size = new Size(1112, 118);
            ARTabPage.TabIndex = 4;
            ARTabPage.Text = "AR";
            ARTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 3);
            tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1104, 112);
            tableLayoutPanel6.TabIndex = 18;
            // 
            // RoomsManagmentTabPage
            // 
            RoomsManagmentTabPage.Controls.Add(tableLayoutPanel5);
            RoomsManagmentTabPage.Location = new Point(4, 24);
            RoomsManagmentTabPage.Margin = new Padding(4, 3, 4, 3);
            RoomsManagmentTabPage.Name = "RoomsManagmentTabPage";
            RoomsManagmentTabPage.Padding = new Padding(4, 3, 4, 3);
            RoomsManagmentTabPage.Size = new Size(1112, 118);
            RoomsManagmentTabPage.TabIndex = 3;
            RoomsManagmentTabPage.Text = "Rooms Managment";
            RoomsManagmentTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(RoomHistoryButton, 0, 0);
            tableLayoutPanel5.Controls.Add(OccupancyGraphButton, 0, 0);
            tableLayoutPanel5.Controls.Add(HousekeepingButton, 0, 0);
            tableLayoutPanel5.Controls.Add(OutOfOrderServiceButton, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 3);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1104, 112);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // RoomHistoryButton
            // 
            RoomHistoryButton.Dock = DockStyle.Fill;
            RoomHistoryButton.FlatAppearance.BorderSize = 0;
            RoomHistoryButton.FlatStyle = FlatStyle.Flat;
            RoomHistoryButton.Image = (Image)resources.GetObject("RoomHistoryButton.Image");
            RoomHistoryButton.ImageAlign = ContentAlignment.TopCenter;
            RoomHistoryButton.Location = new Point(556, 3);
            RoomHistoryButton.Margin = new Padding(4, 3, 4, 3);
            RoomHistoryButton.Name = "RoomHistoryButton";
            RoomHistoryButton.Size = new Size(268, 106);
            RoomHistoryButton.TabIndex = 20;
            RoomHistoryButton.Text = "Room History";
            RoomHistoryButton.TextAlign = ContentAlignment.BottomCenter;
            RoomHistoryButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RoomHistoryButton.UseVisualStyleBackColor = true;
            // 
            // OccupancyGraphButton
            // 
            OccupancyGraphButton.Dock = DockStyle.Fill;
            OccupancyGraphButton.FlatAppearance.BorderSize = 0;
            OccupancyGraphButton.FlatStyle = FlatStyle.Flat;
            OccupancyGraphButton.Image = (Image)resources.GetObject("OccupancyGraphButton.Image");
            OccupancyGraphButton.ImageAlign = ContentAlignment.TopCenter;
            OccupancyGraphButton.Location = new Point(832, 3);
            OccupancyGraphButton.Margin = new Padding(4, 3, 4, 3);
            OccupancyGraphButton.Name = "OccupancyGraphButton";
            OccupancyGraphButton.Size = new Size(268, 106);
            OccupancyGraphButton.TabIndex = 19;
            OccupancyGraphButton.Text = "Occupancy Graph";
            OccupancyGraphButton.TextAlign = ContentAlignment.BottomCenter;
            OccupancyGraphButton.TextImageRelation = TextImageRelation.ImageAboveText;
            OccupancyGraphButton.UseVisualStyleBackColor = true;
            // 
            // HousekeepingButton
            // 
            HousekeepingButton.Dock = DockStyle.Fill;
            HousekeepingButton.FlatAppearance.BorderSize = 0;
            HousekeepingButton.FlatStyle = FlatStyle.Flat;
            HousekeepingButton.Image = (Image)resources.GetObject("HousekeepingButton.Image");
            HousekeepingButton.ImageAlign = ContentAlignment.TopCenter;
            HousekeepingButton.Location = new Point(4, 3);
            HousekeepingButton.Margin = new Padding(4, 3, 4, 3);
            HousekeepingButton.Name = "HousekeepingButton";
            HousekeepingButton.Size = new Size(268, 106);
            HousekeepingButton.TabIndex = 18;
            HousekeepingButton.Text = "Housekeeping";
            HousekeepingButton.TextAlign = ContentAlignment.BottomCenter;
            HousekeepingButton.TextImageRelation = TextImageRelation.ImageAboveText;
            HousekeepingButton.UseVisualStyleBackColor = true;
            // 
            // OutOfOrderServiceButton
            // 
            OutOfOrderServiceButton.Dock = DockStyle.Fill;
            OutOfOrderServiceButton.FlatAppearance.BorderSize = 0;
            OutOfOrderServiceButton.FlatStyle = FlatStyle.Flat;
            OutOfOrderServiceButton.Image = (Image)resources.GetObject("OutOfOrderServiceButton.Image");
            OutOfOrderServiceButton.ImageAlign = ContentAlignment.TopCenter;
            OutOfOrderServiceButton.Location = new Point(280, 3);
            OutOfOrderServiceButton.Margin = new Padding(4, 3, 4, 3);
            OutOfOrderServiceButton.Name = "OutOfOrderServiceButton";
            OutOfOrderServiceButton.Size = new Size(268, 106);
            OutOfOrderServiceButton.TabIndex = 17;
            OutOfOrderServiceButton.Text = "Out Of Order/Service";
            OutOfOrderServiceButton.TextAlign = ContentAlignment.BottomCenter;
            OutOfOrderServiceButton.TextImageRelation = TextImageRelation.ImageAboveText;
            OutOfOrderServiceButton.UseVisualStyleBackColor = true;
            // 
            // CasheiringTabPage
            // 
            CasheiringTabPage.Controls.Add(tableLayoutPanel4);
            CasheiringTabPage.Location = new Point(4, 24);
            CasheiringTabPage.Margin = new Padding(4, 3, 4, 3);
            CasheiringTabPage.Name = "CasheiringTabPage";
            CasheiringTabPage.Padding = new Padding(4, 3, 4, 3);
            CasheiringTabPage.Size = new Size(1112, 118);
            CasheiringTabPage.TabIndex = 2;
            CasheiringTabPage.Text = "Casheiring";
            CasheiringTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.Controls.Add(PasserByButton, 0, 0);
            tableLayoutPanel4.Controls.Add(CashierFunctionsButton, 0, 0);
            tableLayoutPanel4.Controls.Add(CashierShiftFunctionsButton, 0, 0);
            tableLayoutPanel4.Controls.Add(BillingButton, 0, 0);
            tableLayoutPanel4.Controls.Add(FastPostingButton, 0, 0);
            tableLayoutPanel4.Controls.Add(QuickCheckOutButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 3);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1104, 112);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // PasserByButton
            // 
            PasserByButton.Dock = DockStyle.Fill;
            PasserByButton.Enabled = false;
            PasserByButton.FlatAppearance.BorderSize = 0;
            PasserByButton.FlatStyle = FlatStyle.Flat;
            PasserByButton.Image = (Image)resources.GetObject("PasserByButton.Image");
            PasserByButton.ImageAlign = ContentAlignment.TopCenter;
            PasserByButton.Location = new Point(553, 3);
            PasserByButton.Margin = new Padding(4, 3, 4, 3);
            PasserByButton.Name = "PasserByButton";
            PasserByButton.Size = new Size(175, 106);
            PasserByButton.TabIndex = 14;
            PasserByButton.Text = "Passer By";
            PasserByButton.TextAlign = ContentAlignment.BottomCenter;
            PasserByButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PasserByButton.UseVisualStyleBackColor = true;
            // 
            // CashierFunctionsButton
            // 
            CashierFunctionsButton.Dock = DockStyle.Fill;
            CashierFunctionsButton.Enabled = false;
            CashierFunctionsButton.FlatAppearance.BorderSize = 0;
            CashierFunctionsButton.FlatStyle = FlatStyle.Flat;
            CashierFunctionsButton.Image = (Image)resources.GetObject("CashierFunctionsButton.Image");
            CashierFunctionsButton.ImageAlign = ContentAlignment.TopCenter;
            CashierFunctionsButton.Location = new Point(736, 3);
            CashierFunctionsButton.Margin = new Padding(4, 3, 4, 3);
            CashierFunctionsButton.Name = "CashierFunctionsButton";
            CashierFunctionsButton.Size = new Size(175, 106);
            CashierFunctionsButton.TabIndex = 13;
            CashierFunctionsButton.Text = "Cashier Functions";
            CashierFunctionsButton.TextAlign = ContentAlignment.BottomCenter;
            CashierFunctionsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CashierFunctionsButton.UseVisualStyleBackColor = true;
            // 
            // CashierShiftFunctionsButton
            // 
            CashierShiftFunctionsButton.Dock = DockStyle.Fill;
            CashierShiftFunctionsButton.Enabled = false;
            CashierShiftFunctionsButton.FlatAppearance.BorderSize = 0;
            CashierShiftFunctionsButton.FlatStyle = FlatStyle.Flat;
            CashierShiftFunctionsButton.Image = (Image)resources.GetObject("CashierShiftFunctionsButton.Image");
            CashierShiftFunctionsButton.ImageAlign = ContentAlignment.TopCenter;
            CashierShiftFunctionsButton.Location = new Point(919, 3);
            CashierShiftFunctionsButton.Margin = new Padding(4, 3, 4, 3);
            CashierShiftFunctionsButton.Name = "CashierShiftFunctionsButton";
            CashierShiftFunctionsButton.Size = new Size(181, 106);
            CashierShiftFunctionsButton.TabIndex = 12;
            CashierShiftFunctionsButton.Text = "Cashier Shift Functions";
            CashierShiftFunctionsButton.TextAlign = ContentAlignment.BottomCenter;
            CashierShiftFunctionsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CashierShiftFunctionsButton.UseVisualStyleBackColor = true;
            // 
            // BillingButton
            // 
            BillingButton.Dock = DockStyle.Fill;
            BillingButton.FlatAppearance.BorderSize = 0;
            BillingButton.FlatStyle = FlatStyle.Flat;
            BillingButton.Image = (Image)resources.GetObject("BillingButton.Image");
            BillingButton.ImageAlign = ContentAlignment.TopCenter;
            BillingButton.Location = new Point(4, 3);
            BillingButton.Margin = new Padding(4, 3, 4, 3);
            BillingButton.Name = "BillingButton";
            BillingButton.Size = new Size(175, 106);
            BillingButton.TabIndex = 11;
            BillingButton.Text = "Billing";
            BillingButton.TextAlign = ContentAlignment.BottomCenter;
            BillingButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BillingButton.UseVisualStyleBackColor = true;
            // 
            // FastPostingButton
            // 
            FastPostingButton.Dock = DockStyle.Fill;
            FastPostingButton.FlatAppearance.BorderSize = 0;
            FastPostingButton.FlatStyle = FlatStyle.Flat;
            FastPostingButton.Image = (Image)resources.GetObject("FastPostingButton.Image");
            FastPostingButton.ImageAlign = ContentAlignment.TopCenter;
            FastPostingButton.Location = new Point(187, 3);
            FastPostingButton.Margin = new Padding(4, 3, 4, 3);
            FastPostingButton.Name = "FastPostingButton";
            FastPostingButton.Size = new Size(175, 106);
            FastPostingButton.TabIndex = 10;
            FastPostingButton.Text = "Fast Posting";
            FastPostingButton.TextAlign = ContentAlignment.BottomCenter;
            FastPostingButton.TextImageRelation = TextImageRelation.ImageAboveText;
            FastPostingButton.UseVisualStyleBackColor = true;
            // 
            // QuickCheckOutButton
            // 
            QuickCheckOutButton.Dock = DockStyle.Fill;
            QuickCheckOutButton.FlatAppearance.BorderSize = 0;
            QuickCheckOutButton.FlatStyle = FlatStyle.Flat;
            QuickCheckOutButton.Image = (Image)resources.GetObject("QuickCheckOutButton.Image");
            QuickCheckOutButton.ImageAlign = ContentAlignment.TopCenter;
            QuickCheckOutButton.Location = new Point(370, 3);
            QuickCheckOutButton.Margin = new Padding(4, 3, 4, 3);
            QuickCheckOutButton.Name = "QuickCheckOutButton";
            QuickCheckOutButton.Size = new Size(175, 106);
            QuickCheckOutButton.TabIndex = 9;
            QuickCheckOutButton.Text = "Quick Check Out";
            QuickCheckOutButton.TextAlign = ContentAlignment.BottomCenter;
            QuickCheckOutButton.TextImageRelation = TextImageRelation.ImageAboveText;
            QuickCheckOutButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.Controls.Add(RoomAssigmentButton, 0, 0);
            tableLayoutPanel2.Controls.Add(MessagesButton, 0, 0);
            tableLayoutPanel2.Controls.Add(TracesButton, 0, 0);
            tableLayoutPanel2.Controls.Add(ArrivalsButton, 0, 0);
            tableLayoutPanel2.Controls.Add(InHouseGuestsButton, 0, 0);
            tableLayoutPanel2.Controls.Add(AccountsButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 3);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1104, 112);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // RoomAssigmentButton
            // 
            RoomAssigmentButton.Dock = DockStyle.Fill;
            RoomAssigmentButton.Enabled = false;
            RoomAssigmentButton.FlatAppearance.BorderSize = 0;
            RoomAssigmentButton.FlatStyle = FlatStyle.Flat;
            RoomAssigmentButton.Image = (Image)resources.GetObject("RoomAssigmentButton.Image");
            RoomAssigmentButton.ImageAlign = ContentAlignment.TopCenter;
            RoomAssigmentButton.Location = new Point(553, 3);
            RoomAssigmentButton.Margin = new Padding(4, 3, 4, 3);
            RoomAssigmentButton.Name = "RoomAssigmentButton";
            RoomAssigmentButton.Size = new Size(175, 106);
            RoomAssigmentButton.TabIndex = 10;
            RoomAssigmentButton.Text = "Room Assigment";
            RoomAssigmentButton.TextAlign = ContentAlignment.BottomCenter;
            RoomAssigmentButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RoomAssigmentButton.UseVisualStyleBackColor = true;
            // 
            // MessagesButton
            // 
            MessagesButton.Dock = DockStyle.Fill;
            MessagesButton.FlatAppearance.BorderSize = 0;
            MessagesButton.FlatStyle = FlatStyle.Flat;
            MessagesButton.Image = (Image)resources.GetObject("MessagesButton.Image");
            MessagesButton.ImageAlign = ContentAlignment.TopCenter;
            MessagesButton.Location = new Point(736, 3);
            MessagesButton.Margin = new Padding(4, 3, 4, 3);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(175, 106);
            MessagesButton.TabIndex = 9;
            MessagesButton.Text = "Messages";
            MessagesButton.TextAlign = ContentAlignment.BottomCenter;
            MessagesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            MessagesButton.UseVisualStyleBackColor = true;
            // 
            // TracesButton
            // 
            TracesButton.Dock = DockStyle.Fill;
            TracesButton.Enabled = false;
            TracesButton.FlatAppearance.BorderSize = 0;
            TracesButton.FlatStyle = FlatStyle.Flat;
            TracesButton.Image = (Image)resources.GetObject("TracesButton.Image");
            TracesButton.ImageAlign = ContentAlignment.TopCenter;
            TracesButton.Location = new Point(919, 3);
            TracesButton.Margin = new Padding(4, 3, 4, 3);
            TracesButton.Name = "TracesButton";
            TracesButton.Size = new Size(181, 106);
            TracesButton.TabIndex = 8;
            TracesButton.Text = "Traces";
            TracesButton.TextAlign = ContentAlignment.BottomCenter;
            TracesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            TracesButton.UseVisualStyleBackColor = true;
            // 
            // ArrivalsButton
            // 
            ArrivalsButton.Dock = DockStyle.Fill;
            ArrivalsButton.FlatAppearance.BorderSize = 0;
            ArrivalsButton.FlatStyle = FlatStyle.Flat;
            ArrivalsButton.Image = (Image)resources.GetObject("ArrivalsButton.Image");
            ArrivalsButton.ImageAlign = ContentAlignment.TopCenter;
            ArrivalsButton.Location = new Point(4, 3);
            ArrivalsButton.Margin = new Padding(4, 3, 4, 3);
            ArrivalsButton.Name = "ArrivalsButton";
            ArrivalsButton.Size = new Size(175, 106);
            ArrivalsButton.TabIndex = 7;
            ArrivalsButton.Text = "Arrivals";
            ArrivalsButton.TextAlign = ContentAlignment.BottomCenter;
            ArrivalsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ArrivalsButton.UseVisualStyleBackColor = true;
            // 
            // InHouseGuestsButton
            // 
            InHouseGuestsButton.Dock = DockStyle.Fill;
            InHouseGuestsButton.FlatAppearance.BorderSize = 0;
            InHouseGuestsButton.FlatStyle = FlatStyle.Flat;
            InHouseGuestsButton.Image = (Image)resources.GetObject("InHouseGuestsButton.Image");
            InHouseGuestsButton.ImageAlign = ContentAlignment.TopCenter;
            InHouseGuestsButton.Location = new Point(187, 3);
            InHouseGuestsButton.Margin = new Padding(4, 3, 4, 3);
            InHouseGuestsButton.Name = "InHouseGuestsButton";
            InHouseGuestsButton.Size = new Size(175, 106);
            InHouseGuestsButton.TabIndex = 6;
            InHouseGuestsButton.Text = "In House Guests";
            InHouseGuestsButton.TextAlign = ContentAlignment.BottomCenter;
            InHouseGuestsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            InHouseGuestsButton.UseVisualStyleBackColor = true;
            // 
            // AccountsButton
            // 
            AccountsButton.Dock = DockStyle.Fill;
            AccountsButton.Enabled = false;
            AccountsButton.FlatAppearance.BorderSize = 0;
            AccountsButton.FlatStyle = FlatStyle.Flat;
            AccountsButton.Image = (Image)resources.GetObject("AccountsButton.Image");
            AccountsButton.ImageAlign = ContentAlignment.TopCenter;
            AccountsButton.Location = new Point(370, 3);
            AccountsButton.Margin = new Padding(4, 3, 4, 3);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Size = new Size(175, 106);
            AccountsButton.TabIndex = 5;
            AccountsButton.Text = "Accounts";
            AccountsButton.TextAlign = ContentAlignment.BottomCenter;
            AccountsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AccountsButton.UseVisualStyleBackColor = true;
            // 
            // ReservationsTabPage
            // 
            ReservationsTabPage.Controls.Add(ReservationsLayoutPanel);
            ReservationsTabPage.Location = new Point(4, 24);
            ReservationsTabPage.Margin = new Padding(4, 3, 4, 3);
            ReservationsTabPage.Name = "ReservationsTabPage";
            ReservationsTabPage.Padding = new Padding(4, 3, 4, 3);
            ReservationsTabPage.Size = new Size(1112, 118);
            ReservationsTabPage.TabIndex = 11;
            ReservationsTabPage.Text = "Reservations";
            ReservationsTabPage.UseVisualStyleBackColor = true;
            // 
            // ReservationsLayoutPanel
            // 
            ReservationsLayoutPanel.ColumnCount = 9;
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            ReservationsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.12F));
            ReservationsLayoutPanel.Controls.Add(ConfirmationButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(FloorPlanButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(CalendarButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(RegistrationCardsButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(RoomPlanButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(UpdateReservationButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(NewReservationButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(ProfilesButton, 0, 0);
            ReservationsLayoutPanel.Controls.Add(BlocksButton, 0, 0);
            ReservationsLayoutPanel.Dock = DockStyle.Fill;
            ReservationsLayoutPanel.Location = new Point(4, 3);
            ReservationsLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            ReservationsLayoutPanel.Name = "ReservationsLayoutPanel";
            ReservationsLayoutPanel.RowCount = 1;
            ReservationsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ReservationsLayoutPanel.Size = new Size(1104, 112);
            ReservationsLayoutPanel.TabIndex = 18;
            // 
            // ConfirmationButton
            // 
            ConfirmationButton.Dock = DockStyle.Fill;
            ConfirmationButton.Enabled = false;
            ConfirmationButton.FlatAppearance.BorderSize = 0;
            ConfirmationButton.FlatStyle = FlatStyle.Flat;
            ConfirmationButton.Image = (Image)resources.GetObject("ConfirmationButton.Image");
            ConfirmationButton.Location = new Point(736, 3);
            ConfirmationButton.Margin = new Padding(4, 3, 4, 3);
            ConfirmationButton.Name = "ConfirmationButton";
            ConfirmationButton.Size = new Size(114, 106);
            ConfirmationButton.TabIndex = 10;
            ConfirmationButton.Text = "Confirmation";
            ConfirmationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ConfirmationButton.UseVisualStyleBackColor = true;
            // 
            // FloorPlanButton
            // 
            FloorPlanButton.Dock = DockStyle.Fill;
            FloorPlanButton.Enabled = false;
            FloorPlanButton.FlatAppearance.BorderSize = 0;
            FloorPlanButton.FlatStyle = FlatStyle.Flat;
            FloorPlanButton.Image = (Image)resources.GetObject("FloorPlanButton.Image");
            FloorPlanButton.Location = new Point(614, 3);
            FloorPlanButton.Margin = new Padding(4, 3, 4, 3);
            FloorPlanButton.Name = "FloorPlanButton";
            FloorPlanButton.Size = new Size(114, 106);
            FloorPlanButton.TabIndex = 9;
            FloorPlanButton.Text = "Floor Plan";
            FloorPlanButton.TextImageRelation = TextImageRelation.ImageAboveText;
            FloorPlanButton.UseVisualStyleBackColor = true;
            // 
            // CalendarButton
            // 
            CalendarButton.Dock = DockStyle.Fill;
            CalendarButton.FlatAppearance.BorderSize = 0;
            CalendarButton.FlatStyle = FlatStyle.Flat;
            CalendarButton.Image = (Image)resources.GetObject("CalendarButton.Image");
            CalendarButton.Location = new Point(980, 3);
            CalendarButton.Margin = new Padding(4, 3, 4, 3);
            CalendarButton.Name = "CalendarButton";
            CalendarButton.Size = new Size(120, 106);
            CalendarButton.TabIndex = 8;
            CalendarButton.Text = "Calendar";
            CalendarButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CalendarButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationCardsButton
            // 
            RegistrationCardsButton.Dock = DockStyle.Fill;
            RegistrationCardsButton.Enabled = false;
            RegistrationCardsButton.FlatAppearance.BorderSize = 0;
            RegistrationCardsButton.FlatStyle = FlatStyle.Flat;
            RegistrationCardsButton.Image = (Image)resources.GetObject("RegistrationCardsButton.Image");
            RegistrationCardsButton.Location = new Point(858, 3);
            RegistrationCardsButton.Margin = new Padding(4, 3, 4, 3);
            RegistrationCardsButton.Name = "RegistrationCardsButton";
            RegistrationCardsButton.Size = new Size(114, 106);
            RegistrationCardsButton.TabIndex = 7;
            RegistrationCardsButton.Text = "Registration Cards";
            RegistrationCardsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RegistrationCardsButton.UseVisualStyleBackColor = true;
            // 
            // RoomPlanButton
            // 
            RoomPlanButton.Dock = DockStyle.Fill;
            RoomPlanButton.FlatAppearance.BorderSize = 0;
            RoomPlanButton.FlatStyle = FlatStyle.Flat;
            RoomPlanButton.Image = (Image)resources.GetObject("RoomPlanButton.Image");
            RoomPlanButton.Location = new Point(492, 3);
            RoomPlanButton.Margin = new Padding(4, 3, 4, 3);
            RoomPlanButton.Name = "RoomPlanButton";
            RoomPlanButton.Size = new Size(114, 106);
            RoomPlanButton.TabIndex = 6;
            RoomPlanButton.Text = "Room Plan";
            RoomPlanButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RoomPlanButton.UseVisualStyleBackColor = true;
            // 
            // UpdateReservationButton
            // 
            UpdateReservationButton.Dock = DockStyle.Fill;
            UpdateReservationButton.FlatAppearance.BorderSize = 0;
            UpdateReservationButton.FlatStyle = FlatStyle.Flat;
            UpdateReservationButton.Image = (Image)resources.GetObject("UpdateReservationButton.Image");
            UpdateReservationButton.Location = new Point(126, 3);
            UpdateReservationButton.Margin = new Padding(4, 3, 4, 3);
            UpdateReservationButton.Name = "UpdateReservationButton";
            UpdateReservationButton.Padding = new Padding(0, 4, 0, 0);
            UpdateReservationButton.Size = new Size(114, 106);
            UpdateReservationButton.TabIndex = 5;
            UpdateReservationButton.Text = "Update Reservation";
            UpdateReservationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            UpdateReservationButton.UseVisualStyleBackColor = true;
            // 
            // NewReservationButton
            // 
            NewReservationButton.Dock = DockStyle.Fill;
            NewReservationButton.FlatAppearance.BorderSize = 0;
            NewReservationButton.FlatStyle = FlatStyle.Flat;
            NewReservationButton.Image = (Image)resources.GetObject("NewReservationButton.Image");
            NewReservationButton.Location = new Point(4, 3);
            NewReservationButton.Margin = new Padding(4, 3, 4, 3);
            NewReservationButton.Name = "NewReservationButton";
            NewReservationButton.Size = new Size(114, 106);
            NewReservationButton.TabIndex = 4;
            NewReservationButton.Text = "New Reservation";
            NewReservationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            NewReservationButton.UseVisualStyleBackColor = true;
            NewReservationButton.Click += NewReservationButton_Click;
            // 
            // ProfilesButton
            // 
            ProfilesButton.Dock = DockStyle.Fill;
            ProfilesButton.FlatAppearance.BorderSize = 0;
            ProfilesButton.FlatStyle = FlatStyle.Flat;
            ProfilesButton.Image = (Image)resources.GetObject("ProfilesButton.Image");
            ProfilesButton.Location = new Point(370, 3);
            ProfilesButton.Margin = new Padding(4, 3, 4, 3);
            ProfilesButton.Name = "ProfilesButton";
            ProfilesButton.Size = new Size(114, 106);
            ProfilesButton.TabIndex = 3;
            ProfilesButton.Text = "Profiles";
            ProfilesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ProfilesButton.UseVisualStyleBackColor = true;
            // 
            // BlocksButton
            // 
            BlocksButton.Dock = DockStyle.Fill;
            BlocksButton.Enabled = false;
            BlocksButton.FlatAppearance.BorderSize = 0;
            BlocksButton.FlatStyle = FlatStyle.Flat;
            BlocksButton.Image = (Image)resources.GetObject("BlocksButton.Image");
            BlocksButton.Location = new Point(248, 3);
            BlocksButton.Margin = new Padding(4, 3, 4, 3);
            BlocksButton.Name = "BlocksButton";
            BlocksButton.Size = new Size(114, 106);
            BlocksButton.TabIndex = 2;
            BlocksButton.Text = "Blocks";
            BlocksButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BlocksButton.UseVisualStyleBackColor = true;
            // 
            // MenuControl
            // 
            MenuControl.Controls.Add(ReservationsTabPage);
            MenuControl.Controls.Add(FrontDeskTabPage);
            MenuControl.Controls.Add(CasheiringTabPage);
            MenuControl.Controls.Add(RoomsManagmentTabPage);
            MenuControl.Controls.Add(ARTabPage);
            MenuControl.Controls.Add(CommissionsTabPage);
            MenuControl.Controls.Add(MiscellaneousTabPage);
            MenuControl.Controls.Add(SetupTabPage);
            MenuControl.Controls.Add(BackOfficeInterfaceTabPage);
            MenuControl.Controls.Add(HelpTabPage);
            MenuControl.Controls.Add(ExitTabPage);
            MenuControl.Dock = DockStyle.Top;
            MenuControl.Location = new Point(0, 0);
            MenuControl.Margin = new Padding(4, 3, 4, 3);
            MenuControl.Name = "MenuControl";
            MenuControl.SelectedIndex = 0;
            MenuControl.Size = new Size(1120, 146);
            MenuControl.SizeMode = TabSizeMode.Fixed;
            MenuControl.TabIndex = 14;
            // 
            // FrontDeskTabPage
            // 
            FrontDeskTabPage.Controls.Add(tableLayoutPanel2);
            FrontDeskTabPage.Location = new Point(4, 24);
            FrontDeskTabPage.Margin = new Padding(4, 3, 4, 3);
            FrontDeskTabPage.Name = "FrontDeskTabPage";
            FrontDeskTabPage.Padding = new Padding(4, 3, 4, 3);
            FrontDeskTabPage.Size = new Size(1112, 118);
            FrontDeskTabPage.TabIndex = 12;
            FrontDeskTabPage.Text = "Front Desk";
            FrontDeskTabPage.UseVisualStyleBackColor = true;
            // 
            // ExitTabPage
            // 
            ExitTabPage.Controls.Add(tableLayoutPanel1);
            ExitTabPage.Location = new Point(4, 24);
            ExitTabPage.Margin = new Padding(4, 3, 4, 3);
            ExitTabPage.Name = "ExitTabPage";
            ExitTabPage.Padding = new Padding(4, 3, 4, 3);
            ExitTabPage.Size = new Size(1112, 118);
            ExitTabPage.TabIndex = 13;
            ExitTabPage.Text = "Exit";
            ExitTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ExitButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 3);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1104, 112);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1120, 749);
            Controls.Add(MenuControl);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1136, 736);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelEDU";
            WindowState = FormWindowState.Maximized;
            SizeChanged += MainForm_SizeChanged;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            HelpTabPage.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            BackOfficeInterfaceTabPage.ResumeLayout(false);
            SetupTabPage.ResumeLayout(false);
            MiscellaneousTabPage.ResumeLayout(false);
            CommissionsTabPage.ResumeLayout(false);
            ARTabPage.ResumeLayout(false);
            RoomsManagmentTabPage.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            CasheiringTabPage.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ReservationsTabPage.ResumeLayout(false);
            ReservationsLayoutPanel.ResumeLayout(false);
            MenuControl.ResumeLayout(false);
            FrontDeskTabPage.ResumeLayout(false);
            ExitTabPage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel10;
        private Button button2;
        private Button ExitButton;
        private TabPage HelpTabPage;
        private TableLayoutPanel tableLayoutPanel13;
        private TabPage BackOfficeInterfaceTabPage;
        private TableLayoutPanel tableLayoutPanel12;
        private TabPage SetupTabPage;
        private TableLayoutPanel tableLayoutPanel11;
        private TabPage MiscellaneousTabPage;
        private TableLayoutPanel tableLayoutPanel9;
        private TabPage CommissionsTabPage;
        private TableLayoutPanel tableLayoutPanel8;
        private TabPage ARTabPage;
        private TableLayoutPanel tableLayoutPanel6;
        private TabPage RoomsManagmentTabPage;
        private TableLayoutPanel tableLayoutPanel5;
        private TabPage CasheiringTabPage;
        private TableLayoutPanel tableLayoutPanel4;
        private Button PasserByButton;
        private Button CashierFunctionsButton;
        private Button CashierShiftFunctionsButton;
        private Button BillingButton;
        private Button FastPostingButton;
        private Button QuickCheckOutButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button RoomAssigmentButton;
        private Button MessagesButton;
        private Button TracesButton;
        private Button ArrivalsButton;
        private Button InHouseGuestsButton;
        private Button AccountsButton;
        private TabPage ReservationsTabPage;
        private TableLayoutPanel ReservationsLayoutPanel;
        private Button ConfirmationButton;
        private Button FloorPlanButton;
        private Button CalendarButton;
        private Button RegistrationCardsButton;
        private Button RoomPlanButton;
        private Button UpdateReservationButton;
        private Button NewReservationButton;
        private Button ProfilesButton;
        private Button BlocksButton;
        private TabControl MenuControl;
        private TabPage FrontDeskTabPage;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button OutOfOrderServiceButton;
        private Button RoomHistoryButton;
        private Button OccupancyGraphButton;
        private Button HousekeepingButton;
        private TabPage ExitTabPage;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AboutProgramButton;
    }
}



