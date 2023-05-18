using System.Drawing;
using System.Windows.Forms;

namespace HotelEDU
{
    partial class RateQueryDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateQueryDetailsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.NegotiatedCheckBox = new System.Windows.Forms.CheckBox();
            this.DayUseCheckBox = new System.Windows.Forms.CheckBox();
            this.RateCodeTextBox = new System.Windows.Forms.TextBox();
            this.RateCodeLabel = new System.Windows.Forms.Label();
            this.BestAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.AverageRateRadioButton = new System.Windows.Forms.RadioButton();
            this.TotalRatesRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNightRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SellMsgLabel = new System.Windows.Forms.Label();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SellMsgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.RateQueryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RateInfoButton = new System.Windows.Forms.Button();
            this.ScopeButton = new System.Windows.Forms.Button();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.LongInfoButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstElementButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextElementButton = new System.Windows.Forms.Button();
            this.LastElementButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RateQueryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 395);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(792, 163);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 1F);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(308, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.ClosedCheckBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.NegotiatedCheckBox, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.DayUseCheckBox, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.RateCodeTextBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.RateCodeLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.BestAvailableCheckBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.AverageRateRadioButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.TotalRatesRadioButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.FirstNightRadioButton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.61346F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.61345F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.61345F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.61345F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.54618F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 149);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // ClosedCheckBox
            // 
            this.ClosedCheckBox.AutoSize = true;
            this.ClosedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClosedCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ClosedCheckBox.Location = new System.Drawing.Point(4, 33);
            this.ClosedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClosedCheckBox.Name = "ClosedCheckBox";
            this.ClosedCheckBox.Size = new System.Drawing.Size(91, 24);
            this.ClosedCheckBox.TabIndex = 0;
            this.ClosedCheckBox.Text = "Closed";
            this.ClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // NegotiatedCheckBox
            // 
            this.NegotiatedCheckBox.AutoSize = true;
            this.NegotiatedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegotiatedCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.NegotiatedCheckBox.Location = new System.Drawing.Point(4, 63);
            this.NegotiatedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NegotiatedCheckBox.Name = "NegotiatedCheckBox";
            this.NegotiatedCheckBox.Size = new System.Drawing.Size(91, 24);
            this.NegotiatedCheckBox.TabIndex = 1;
            this.NegotiatedCheckBox.Text = "Negotiated";
            this.NegotiatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DayUseCheckBox
            // 
            this.DayUseCheckBox.AutoSize = true;
            this.DayUseCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayUseCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DayUseCheckBox.Location = new System.Drawing.Point(4, 93);
            this.DayUseCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DayUseCheckBox.Name = "DayUseCheckBox";
            this.DayUseCheckBox.Size = new System.Drawing.Size(91, 24);
            this.DayUseCheckBox.TabIndex = 2;
            this.DayUseCheckBox.Text = "Day Use";
            this.DayUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // RateCodeTextBox
            // 
            this.RateCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RateCodeTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RateCodeTextBox.Location = new System.Drawing.Point(103, 123);
            this.RateCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RateCodeTextBox.Name = "RateCodeTextBox";
            this.RateCodeTextBox.Size = new System.Drawing.Size(92, 21);
            this.RateCodeTextBox.TabIndex = 3;
            // 
            // RateCodeLabel
            // 
            this.RateCodeLabel.AutoSize = true;
            this.RateCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RateCodeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RateCodeLabel.Location = new System.Drawing.Point(4, 120);
            this.RateCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RateCodeLabel.Name = "RateCodeLabel";
            this.RateCodeLabel.Size = new System.Drawing.Size(91, 29);
            this.RateCodeLabel.TabIndex = 4;
            this.RateCodeLabel.Text = "Rate Code";
            this.RateCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BestAvailableCheckBox
            // 
            this.BestAvailableCheckBox.AutoSize = true;
            this.BestAvailableCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestAvailableCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BestAvailableCheckBox.Location = new System.Drawing.Point(103, 33);
            this.BestAvailableCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BestAvailableCheckBox.Name = "BestAvailableCheckBox";
            this.BestAvailableCheckBox.Size = new System.Drawing.Size(92, 24);
            this.BestAvailableCheckBox.TabIndex = 5;
            this.BestAvailableCheckBox.Text = "Best Available";
            this.BestAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // AverageRateRadioButton
            // 
            this.AverageRateRadioButton.AutoSize = true;
            this.AverageRateRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AverageRateRadioButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AverageRateRadioButton.Location = new System.Drawing.Point(4, 3);
            this.AverageRateRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AverageRateRadioButton.Name = "AverageRateRadioButton";
            this.AverageRateRadioButton.Size = new System.Drawing.Size(91, 24);
            this.AverageRateRadioButton.TabIndex = 6;
            this.AverageRateRadioButton.TabStop = true;
            this.AverageRateRadioButton.Text = "Average Rate";
            this.AverageRateRadioButton.UseVisualStyleBackColor = true;
            // 
            // TotalRatesRadioButton
            // 
            this.TotalRatesRadioButton.AutoSize = true;
            this.TotalRatesRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalRatesRadioButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TotalRatesRadioButton.Location = new System.Drawing.Point(103, 3);
            this.TotalRatesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotalRatesRadioButton.Name = "TotalRatesRadioButton";
            this.TotalRatesRadioButton.Size = new System.Drawing.Size(92, 24);
            this.TotalRatesRadioButton.TabIndex = 7;
            this.TotalRatesRadioButton.TabStop = true;
            this.TotalRatesRadioButton.Text = "Total Rates";
            this.TotalRatesRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNightRadioButton
            // 
            this.FirstNightRadioButton.AutoSize = true;
            this.FirstNightRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNightRadioButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FirstNightRadioButton.Location = new System.Drawing.Point(203, 3);
            this.FirstNightRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstNightRadioButton.Name = "FirstNightRadioButton";
            this.FirstNightRadioButton.Size = new System.Drawing.Size(93, 24);
            this.FirstNightRadioButton.TabIndex = 8;
            this.FirstNightRadioButton.TabStop = true;
            this.FirstNightRadioButton.Text = "First Night";
            this.FirstNightRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 1F);
            this.groupBox3.Location = new System.Drawing.Point(320, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(468, 157);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.InfoLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.SellMsgLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.EventsLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.InfoRichTextBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.SellMsgRichTextBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(460, 149);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.InfoLabel.Location = new System.Drawing.Point(4, 0);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(222, 61);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Info";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SellMsgLabel
            // 
            this.SellMsgLabel.AutoSize = true;
            this.SellMsgLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellMsgLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.SellMsgLabel.Location = new System.Drawing.Point(4, 61);
            this.SellMsgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellMsgLabel.Name = "SellMsgLabel";
            this.SellMsgLabel.Size = new System.Drawing.Size(222, 61);
            this.SellMsgLabel.TabIndex = 1;
            this.SellMsgLabel.Text = "Sell Msg";
            this.SellMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.EventsLabel.Location = new System.Drawing.Point(4, 122);
            this.EventsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(222, 27);
            this.EventsLabel.TabIndex = 2;
            this.EventsLabel.Text = "Events";
            this.EventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoRichTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.InfoRichTextBox.Location = new System.Drawing.Point(234, 3);
            this.InfoRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.Size = new System.Drawing.Size(222, 55);
            this.InfoRichTextBox.TabIndex = 3;
            this.InfoRichTextBox.Text = "";
            // 
            // SellMsgRichTextBox
            // 
            this.SellMsgRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellMsgRichTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.SellMsgRichTextBox.Location = new System.Drawing.Point(234, 64);
            this.SellMsgRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SellMsgRichTextBox.Name = "SellMsgRichTextBox";
            this.SellMsgRichTextBox.Size = new System.Drawing.Size(222, 55);
            this.SellMsgRichTextBox.TabIndex = 4;
            this.SellMsgRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(234, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 21);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button11.Location = new System.Drawing.Point(192, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 21);
            this.button11.TabIndex = 0;
            this.button11.Text = "...";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // RateQueryLabel
            // 
            this.RateQueryLabel.AutoSize = true;
            this.RateQueryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RateQueryLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RateQueryLabel.ForeColor = System.Drawing.Color.Red;
            this.RateQueryLabel.Location = new System.Drawing.Point(4, 0);
            this.RateQueryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RateQueryLabel.Name = "RateQueryLabel";
            this.RateQueryLabel.Size = new System.Drawing.Size(792, 56);
            this.RateQueryLabel.TabIndex = 0;
            this.RateQueryLabel.Text = "RateQueryLabel";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 59);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 294);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.OKButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 1F);
            this.groupBox1.Location = new System.Drawing.Point(693, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(95, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RateInfoButton);
            this.panel2.Controls.Add(this.ScopeButton);
            this.panel2.Controls.Add(this.AnalyzeButton);
            this.panel2.Controls.Add(this.LongInfoButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 235);
            this.panel2.TabIndex = 6;
            // 
            // RateInfoButton
            // 
            this.RateInfoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RateInfoButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RateInfoButton.Location = new System.Drawing.Point(0, 143);
            this.RateInfoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RateInfoButton.Name = "RateInfoButton";
            this.RateInfoButton.Size = new System.Drawing.Size(87, 23);
            this.RateInfoButton.TabIndex = 5;
            this.RateInfoButton.Text = "Rate Info";
            this.RateInfoButton.UseVisualStyleBackColor = true;
            // 
            // ScopeButton
            // 
            this.ScopeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScopeButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ScopeButton.Location = new System.Drawing.Point(0, 166);
            this.ScopeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 6);
            this.ScopeButton.Name = "ScopeButton";
            this.ScopeButton.Size = new System.Drawing.Size(87, 23);
            this.ScopeButton.TabIndex = 2;
            this.ScopeButton.Text = "Scope";
            this.ScopeButton.UseVisualStyleBackColor = true;
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AnalyzeButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AnalyzeButton.Location = new System.Drawing.Point(0, 189);
            this.AnalyzeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(87, 23);
            this.AnalyzeButton.TabIndex = 4;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            // 
            // LongInfoButton
            // 
            this.LongInfoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LongInfoButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LongInfoButton.Location = new System.Drawing.Point(0, 212);
            this.LongInfoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LongInfoButton.Name = "LongInfoButton";
            this.LongInfoButton.Size = new System.Drawing.Size(87, 23);
            this.LongInfoButton.TabIndex = 3;
            this.LongInfoButton.Text = "Long Info";
            this.LongInfoButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.OKButton.Location = new System.Drawing.Point(4, 239);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CloseButton.Location = new System.Drawing.Point(4, 262);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(681, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.4F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.6F));
            this.tableLayoutPanel3.Controls.Add(this.FirstElementButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PreviousButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.NextElementButton, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.LastElementButton, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.AmountLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 359);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 30);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // FirstElementButton
            // 
            this.FirstElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstElementButton.Font = new System.Drawing.Font("Tahoma", 7F);
            this.FirstElementButton.Location = new System.Drawing.Point(122, 3);
            this.FirstElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstElementButton.Name = "FirstElementButton";
            this.FirstElementButton.Size = new System.Drawing.Size(31, 24);
            this.FirstElementButton.TabIndex = 0;
            this.FirstElementButton.Text = "<<";
            this.FirstElementButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousButton.Font = new System.Drawing.Font("Tahoma", 7F);
            this.PreviousButton.Location = new System.Drawing.Point(161, 3);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(31, 24);
            this.PreviousButton.TabIndex = 1;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextElementButton
            // 
            this.NextElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextElementButton.Font = new System.Drawing.Font("Tahoma", 7F);
            this.NextElementButton.Location = new System.Drawing.Point(615, 3);
            this.NextElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextElementButton.Name = "NextElementButton";
            this.NextElementButton.Size = new System.Drawing.Size(31, 24);
            this.NextElementButton.TabIndex = 2;
            this.NextElementButton.Text = ">";
            this.NextElementButton.UseVisualStyleBackColor = true;
            // 
            // LastElementButton
            // 
            this.LastElementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastElementButton.Font = new System.Drawing.Font("Tahoma", 7F);
            this.LastElementButton.Location = new System.Drawing.Point(654, 3);
            this.LastElementButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastElementButton.Name = "LastElementButton";
            this.LastElementButton.Size = new System.Drawing.Size(31, 24);
            this.LastElementButton.TabIndex = 3;
            this.LastElementButton.Text = ">>";
            this.LastElementButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AmountLabel.ForeColor = System.Drawing.Color.Red;
            this.AmountLabel.Location = new System.Drawing.Point(4, 0);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(110, 30);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "000,000,00";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RateQueryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RateQueryDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Query Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label RateQueryLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox ClosedCheckBox;
        private CheckBox NegotiatedCheckBox;
        private CheckBox DayUseCheckBox;
        private TextBox RateCodeTextBox;
        private Label RateCodeLabel;
        private CheckBox BestAvailableCheckBox;
        private RadioButton AverageRateRadioButton;
        private RadioButton TotalRatesRadioButton;
        private RadioButton FirstNightRadioButton;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label InfoLabel;
        private Label SellMsgLabel;
        private Label EventsLabel;
        private RichTextBox InfoRichTextBox;
        private RichTextBox SellMsgRichTextBox;
        private Panel panel1;
        private TextBox textBox1;
        private Button button11;
        private Button RateInfoButton;
        private Button AnalyzeButton;
        private Button LongInfoButton;
        private Button ScopeButton;
        private Button OKButton;
        private Button CloseButton;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button FirstElementButton;
        private Button PreviousButton;
        private Button NextElementButton;
        private Button LastElementButton;
        private Label AmountLabel;
    }
}