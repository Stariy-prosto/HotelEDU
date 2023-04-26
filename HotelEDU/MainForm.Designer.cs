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
            menuStrip1 = new MenuStrip();
            resercationsToolStripMenuItem = new ToolStripMenuItem();
            frontDeskToolStripMenuItem = new ToolStripMenuItem();
            cashieringToolStripMenuItem = new ToolStripMenuItem();
            roomsManagmentToolStripMenuItem = new ToolStripMenuItem();
            aRToolStripMenuItem = new ToolStripMenuItem();
            commissionsToolStripMenuItem = new ToolStripMenuItem();
            miscellaneousToolStripMenuItem = new ToolStripMenuItem();
            setupToolStripMenuItem = new ToolStripMenuItem();
            backOfficeInterfaceToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 526);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(779, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { resercationsToolStripMenuItem, frontDeskToolStripMenuItem, cashieringToolStripMenuItem, roomsManagmentToolStripMenuItem, aRToolStripMenuItem, commissionsToolStripMenuItem, miscellaneousToolStripMenuItem, setupToolStripMenuItem, backOfficeInterfaceToolStripMenuItem, helpToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(779, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // resercationsToolStripMenuItem
            // 
            resercationsToolStripMenuItem.Name = "resercationsToolStripMenuItem";
            resercationsToolStripMenuItem.Size = new Size(82, 20);
            resercationsToolStripMenuItem.Text = "Reservations";
            // 
            // frontDeskToolStripMenuItem
            // 
            frontDeskToolStripMenuItem.Name = "frontDeskToolStripMenuItem";
            frontDeskToolStripMenuItem.Size = new Size(71, 20);
            frontDeskToolStripMenuItem.Text = "Front Desk";
            // 
            // cashieringToolStripMenuItem
            // 
            cashieringToolStripMenuItem.Name = "cashieringToolStripMenuItem";
            cashieringToolStripMenuItem.Size = new Size(69, 20);
            cashieringToolStripMenuItem.Text = "Cashiering";
            // 
            // roomsManagmentToolStripMenuItem
            // 
            roomsManagmentToolStripMenuItem.Name = "roomsManagmentToolStripMenuItem";
            roomsManagmentToolStripMenuItem.Size = new Size(110, 20);
            roomsManagmentToolStripMenuItem.Text = "Rooms Managment";
            // 
            // aRToolStripMenuItem
            // 
            aRToolStripMenuItem.Name = "aRToolStripMenuItem";
            aRToolStripMenuItem.Size = new Size(33, 20);
            aRToolStripMenuItem.Text = "AR";
            // 
            // commissionsToolStripMenuItem
            // 
            commissionsToolStripMenuItem.Name = "commissionsToolStripMenuItem";
            commissionsToolStripMenuItem.Size = new Size(79, 20);
            commissionsToolStripMenuItem.Text = "Commissions";
            // 
            // miscellaneousToolStripMenuItem
            // 
            miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            miscellaneousToolStripMenuItem.Size = new Size(84, 20);
            miscellaneousToolStripMenuItem.Text = "Miscellaneous";
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(47, 20);
            setupToolStripMenuItem.Text = "Setup";
            // 
            // backOfficeInterfaceToolStripMenuItem
            // 
            backOfficeInterfaceToolStripMenuItem.Name = "backOfficeInterfaceToolStripMenuItem";
            backOfficeInterfaceToolStripMenuItem.Size = new Size(121, 20);
            backOfficeInterfaceToolStripMenuItem.Text = "Back Office Interface";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(40, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(37, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 548);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HotelEDU";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resercationsToolStripMenuItem;
        private ToolStripMenuItem frontDeskToolStripMenuItem;
        private ToolStripMenuItem cashieringToolStripMenuItem;
        private ToolStripMenuItem roomsManagmentToolStripMenuItem;
        private ToolStripMenuItem aRToolStripMenuItem;
        private ToolStripMenuItem commissionsToolStripMenuItem;
        private ToolStripMenuItem miscellaneousToolStripMenuItem;
        private ToolStripMenuItem setupToolStripMenuItem;
        private ToolStripMenuItem backOfficeInterfaceToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}



