namespace HotelEDU
{
    partial class PackagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesForm));
            this.PackagesDataGridView = new System.Windows.Forms.DataGridView();
            this.PackagesDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDetailsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PackagesDataGridView
            // 
            this.PackagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackagesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PackagesDataGridView.Name = "PackagesDataGridView";
            this.PackagesDataGridView.Size = new System.Drawing.Size(565, 184);
            this.PackagesDataGridView.TabIndex = 0;
            // 
            // PackagesDetailsDataGridView
            // 
            this.PackagesDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackagesDetailsDataGridView.Location = new System.Drawing.Point(12, 202);
            this.PackagesDetailsDataGridView.Name = "PackagesDetailsDataGridView";
            this.PackagesDetailsDataGridView.Size = new System.Drawing.Size(565, 150);
            this.PackagesDetailsDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(583, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 340);
            this.panel1.TabIndex = 2;
            // 
            // NewButton
            // 
            this.NewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewButton.Location = new System.Drawing.Point(0, 225);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(85, 23);
            this.NewButton.TabIndex = 4;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditButton.Location = new System.Drawing.Point(0, 248);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(0, 271);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.Location = new System.Drawing.Point(0, 294);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(85, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 317);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PackagesDetailsDataGridView);
            this.Controls.Add(this.PackagesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packages";
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDetailsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PackagesDataGridView;
        private System.Windows.Forms.DataGridView PackagesDetailsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CloseButton;
    }
}