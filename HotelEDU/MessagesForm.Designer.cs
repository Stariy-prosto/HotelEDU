namespace HotelEDU
{
    partial class MessagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesForm));
            this.ProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NoneButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilesDataGridView
            // 
            this.ProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfilesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProfilesDataGridView.Name = "ProfilesDataGridView";
            this.ProfilesDataGridView.Size = new System.Drawing.Size(661, 175);
            this.ProfilesDataGridView.TabIndex = 0;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 193);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(661, 118);
            this.MessageTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.NoneButton);
            this.panel1.Controls.Add(this.AllButton);
            this.panel1.Location = new System.Drawing.Point(679, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 299);
            this.panel1.TabIndex = 2;
            // 
            // NewButton
            // 
            this.NewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewButton.Location = new System.Drawing.Point(0, 207);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(85, 23);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditButton.Location = new System.Drawing.Point(0, 230);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(0, 253);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 276);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // NoneButton
            // 
            this.NoneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoneButton.Location = new System.Drawing.Point(0, 23);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(85, 23);
            this.NoneButton.TabIndex = 1;
            this.NoneButton.Text = "None";
            this.NoneButton.UseVisualStyleBackColor = true;
            // 
            // AllButton
            // 
            this.AllButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllButton.Location = new System.Drawing.Point(0, 0);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(85, 23);
            this.AllButton.TabIndex = 0;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ProfilesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProfilesDataGridView;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button NoneButton;
        private System.Windows.Forms.Button AllButton;
    }
}