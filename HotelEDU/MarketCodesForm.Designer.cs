namespace HotelEDU
{
    partial class MarketCodesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketCodesForm));
            this.MarketGroupLabel = new System.Windows.Forms.Label();
            this.MarketGroupTextBox = new System.Windows.Forms.TextBox();
            this.MarketCodeLabel = new System.Windows.Forms.Label();
            this.MarketCodeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarketGroupLabel
            // 
            this.MarketGroupLabel.AutoSize = true;
            this.MarketGroupLabel.Location = new System.Drawing.Point(12, 15);
            this.MarketGroupLabel.Name = "MarketGroupLabel";
            this.MarketGroupLabel.Size = new System.Drawing.Size(72, 13);
            this.MarketGroupLabel.TabIndex = 0;
            this.MarketGroupLabel.Text = "Market Group";
            // 
            // MarketGroupTextBox
            // 
            this.MarketGroupTextBox.Location = new System.Drawing.Point(90, 12);
            this.MarketGroupTextBox.Name = "MarketGroupTextBox";
            this.MarketGroupTextBox.Size = new System.Drawing.Size(150, 20);
            this.MarketGroupTextBox.TabIndex = 1;
            // 
            // MarketCodeLabel
            // 
            this.MarketCodeLabel.AutoSize = true;
            this.MarketCodeLabel.Location = new System.Drawing.Point(246, 15);
            this.MarketCodeLabel.Name = "MarketCodeLabel";
            this.MarketCodeLabel.Size = new System.Drawing.Size(68, 13);
            this.MarketCodeLabel.TabIndex = 2;
            this.MarketCodeLabel.Text = "Market Code";
            // 
            // MarketCodeTextBox
            // 
            this.MarketCodeTextBox.Location = new System.Drawing.Point(320, 12);
            this.MarketCodeTextBox.Name = "MarketCodeTextBox";
            this.MarketCodeTextBox.Size = new System.Drawing.Size(150, 20);
            this.MarketCodeTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(155, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(176, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(294, 238);
            this.dataGridView2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Location = new System.Drawing.Point(476, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 264);
            this.panel1.TabIndex = 6;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.Location = new System.Drawing.Point(0, 218);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(85, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(0, 241);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchButton.Location = new System.Drawing.Point(0, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // MarketCodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MarketCodeTextBox);
            this.Controls.Add(this.MarketCodeLabel);
            this.Controls.Add(this.MarketGroupTextBox);
            this.Controls.Add(this.MarketGroupLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarketCodesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Codes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MarketGroupLabel;
        private System.Windows.Forms.TextBox MarketGroupTextBox;
        private System.Windows.Forms.Label MarketCodeLabel;
        private System.Windows.Forms.TextBox MarketCodeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SearchButton;
    }
}