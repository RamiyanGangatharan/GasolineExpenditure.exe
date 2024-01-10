namespace GasolineExpenditure
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            supportToolStripMenuItem = new ToolStripMenuItem();
            GasGrid = new DataGridView();
            label1 = new Label();
            AddressRTB = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            PumpNumberRTB = new RichTextBox();
            label4 = new Label();
            LitresRTB = new RichTextBox();
            label5 = new Label();
            LitresPerDollarRTB = new RichTextBox();
            label6 = new Label();
            TaxRTB = new RichTextBox();
            label8 = new Label();
            TotalPointsRTB = new RichTextBox();
            label7 = new Label();
            PointsGainedRTB = new RichTextBox();
            label9 = new Label();
            FirstNameRTB = new RichTextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            TotalPointsLabel = new Label();
            PointsGainedLabel = new Label();
            DateLabel = new Label();
            OctaneLabel = new Label();
            PriceLabel = new Label();
            PumpLabel = new Label();
            FuelLabel = new Label();
            OctaneCombo = new ComboBox();
            GasCompanyCombo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            ResetButton = new Button();
            ExitButton = new Button();
            button5 = new Button();
            button6 = new Button();
            ClearButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            UploadButton = new Button();
            groupBox4 = new GroupBox();
            InvoiceRTB = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            LastNameRTB = new RichTextBox();
            label11 = new Label();
            CopyrightLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GasGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, exportToolStripMenuItem, dataToolStripMenuItem, supportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1358, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(53, 20);
            exportToolStripMenuItem.Text = "Export";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 20);
            dataToolStripMenuItem.Text = "Data";
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(61, 20);
            supportToolStripMenuItem.Text = "Support";
            // 
            // GasGrid
            // 
            GasGrid.AllowUserToAddRows = false;
            GasGrid.AllowUserToDeleteRows = false;
            GasGrid.AllowUserToResizeColumns = false;
            GasGrid.AllowUserToResizeRows = false;
            GasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GasGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GasGrid.Location = new Point(12, 27);
            GasGrid.Name = "GasGrid";
            GasGrid.ReadOnly = true;
            GasGrid.Size = new Size(1334, 200);
            GasGrid.TabIndex = 2;
            GasGrid.SelectionChanged += GasGrid_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 150);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Address";
            // 
            // AddressRTB
            // 
            AddressRTB.Location = new Point(6, 175);
            AddressRTB.Name = "AddressRTB";
            AddressRTB.Size = new Size(280, 28);
            AddressRTB.TabIndex = 4;
            AddressRTB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "Fuel Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Octane";
            // 
            // PumpNumberRTB
            // 
            PumpNumberRTB.Location = new Point(254, 49);
            PumpNumberRTB.Name = "PumpNumberRTB";
            PumpNumberRTB.Size = new Size(67, 28);
            PumpNumberRTB.TabIndex = 11;
            PumpNumberRTB.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 26);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Pump #";
            // 
            // LitresRTB
            // 
            LitresRTB.Location = new Point(327, 49);
            LitresRTB.Name = "LitresRTB";
            LitresRTB.Size = new Size(100, 28);
            LitresRTB.TabIndex = 13;
            LitresRTB.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 26);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 12;
            label5.Text = "[L]";
            // 
            // LitresPerDollarRTB
            // 
            LitresPerDollarRTB.Location = new Point(327, 110);
            LitresPerDollarRTB.Name = "LitresPerDollarRTB";
            LitresPerDollarRTB.Size = new Size(100, 28);
            LitresPerDollarRTB.TabIndex = 15;
            LitresPerDollarRTB.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 87);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "[$/L]";
            // 
            // TaxRTB
            // 
            TaxRTB.Location = new Point(433, 49);
            TaxRTB.Name = "TaxRTB";
            TaxRTB.Size = new Size(82, 28);
            TaxRTB.TabIndex = 19;
            TaxRTB.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 26);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 18;
            label8.Text = "Taxes ";
            // 
            // TotalPointsRTB
            // 
            TotalPointsRTB.Location = new Point(521, 110);
            TotalPointsRTB.Name = "TotalPointsRTB";
            TotalPointsRTB.Size = new Size(134, 28);
            TotalPointsRTB.TabIndex = 21;
            TotalPointsRTB.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(521, 87);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 20;
            label7.Text = "Total PTS";
            // 
            // PointsGainedRTB
            // 
            PointsGainedRTB.Location = new Point(433, 110);
            PointsGainedRTB.Name = "PointsGainedRTB";
            PointsGainedRTB.Size = new Size(82, 28);
            PointsGainedRTB.TabIndex = 23;
            PointsGainedRTB.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(433, 87);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 22;
            label9.Text = "PTS Gain";
            // 
            // FirstNameRTB
            // 
            FirstNameRTB.Location = new Point(292, 175);
            FirstNameRTB.Name = "FirstNameRTB";
            FirstNameRTB.Size = new Size(158, 28);
            FirstNameRTB.TabIndex = 24;
            FirstNameRTB.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(292, 149);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 25;
            label10.Text = "First Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TotalPointsLabel);
            groupBox1.Controls.Add(PointsGainedLabel);
            groupBox1.Controls.Add(DateLabel);
            groupBox1.Controls.Add(OctaneLabel);
            groupBox1.Controls.Add(PriceLabel);
            groupBox1.Controls.Add(PumpLabel);
            groupBox1.Controls.Add(FuelLabel);
            groupBox1.Location = new Point(12, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 231);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Output";
            // 
            // TotalPointsLabel
            // 
            TotalPointsLabel.AutoSize = true;
            TotalPointsLabel.Location = new Point(68, 159);
            TotalPointsLabel.Name = "TotalPointsLabel";
            TotalPointsLabel.Size = new Size(115, 20);
            TotalPointsLabel.TabIndex = 6;
            TotalPointsLabel.Text = "Total Points:";
            // 
            // PointsGainedLabel
            // 
            PointsGainedLabel.AutoSize = true;
            PointsGainedLabel.Location = new Point(53, 137);
            PointsGainedLabel.Name = "PointsGainedLabel";
            PointsGainedLabel.Size = new Size(130, 20);
            PointsGainedLabel.TabIndex = 5;
            PointsGainedLabel.Text = "Points Gained:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(49, 115);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(134, 20);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Purchase Date:";
            // 
            // OctaneLabel
            // 
            OctaneLabel.AutoSize = true;
            OctaneLabel.Location = new Point(109, 93);
            OctaneLabel.Name = "OctaneLabel";
            OctaneLabel.Size = new Size(74, 20);
            OctaneLabel.TabIndex = 3;
            OctaneLabel.Text = "Octane:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(128, 72);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(55, 20);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price:";
            // 
            // PumpLabel
            // 
            PumpLabel.AutoSize = true;
            PumpLabel.Location = new Point(53, 52);
            PumpLabel.Name = "PumpLabel";
            PumpLabel.Size = new Size(130, 20);
            PumpLabel.TabIndex = 1;
            PumpLabel.Text = "Pump Number:";
            // 
            // FuelLabel
            // 
            FuelLabel.AutoSize = true;
            FuelLabel.Location = new Point(52, 32);
            FuelLabel.Name = "FuelLabel";
            FuelLabel.Size = new Size(131, 20);
            FuelLabel.TabIndex = 0;
            FuelLabel.Text = "Fuel Company:";
            // 
            // OctaneCombo
            // 
            OctaneCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            OctaneCombo.FormattingEnabled = true;
            OctaneCombo.Items.AddRange(new object[] { "REGULAR [87]", "PLUS [89]", "PREMIUM [91]", "SUPER CLEAN [94]" });
            OctaneCombo.Location = new Point(6, 111);
            OctaneCombo.Name = "OctaneCombo";
            OctaneCombo.Size = new Size(174, 28);
            OctaneCombo.TabIndex = 28;
            // 
            // GasCompanyCombo
            // 
            GasCompanyCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            GasCompanyCombo.FormattingEnabled = true;
            GasCompanyCombo.Items.AddRange(new object[] { "76", "BP", "CANADIAN TIRE ", "CHEVRON", "CIRCLE K", "CREVIER", "EKO", "ESSO", "EXXON MOBIL", "FLYING J'S", "HARNOIS", "HUSKY", "IRVING", "MOBIL", "PAZ FUELS", "PETRO-CANADA", "SHELL CANADA", "SPEEDWAY", "SUPER SAVE GAS", "ULTRAMAR" });
            GasCompanyCombo.Location = new Point(6, 49);
            GasCompanyCombo.Name = "GasCompanyCombo";
            GasCompanyCombo.Size = new Size(242, 28);
            GasCompanyCombo.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(189, 112);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 27);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.Value = new DateTime(2023, 12, 22, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ResetButton);
            groupBox3.Controls.Add(ExitButton);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(ClearButton);
            groupBox3.Controls.Add(DeleteButton);
            groupBox3.Controls.Add(UpdateButton);
            groupBox3.Controls.Add(UploadButton);
            groupBox3.Location = new Point(1089, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 231);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controls";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(172, 158);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(77, 60);
            ResetButton.TabIndex = 7;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(6, 158);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(77, 60);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(89, 158);
            button5.Name = "button5";
            button5.Size = new Size(77, 60);
            button5.TabIndex = 5;
            button5.Text = "Export";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(170, 28);
            button6.Name = "button6";
            button6.Size = new Size(77, 60);
            button6.TabIndex = 4;
            button6.Text = "Total";
            button6.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(87, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(77, 60);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(170, 92);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(77, 60);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(6, 92);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(160, 60);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UploadButton
            // 
            UploadButton.Location = new Point(6, 26);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(77, 60);
            UploadButton.TabIndex = 0;
            UploadButton.Text = "Upload";
            UploadButton.UseVisualStyleBackColor = true;
            UploadButton.Click += UploadButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(InvoiceRTB);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(TotalPointsRTB);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(LastNameRTB);
            groupBox4.Controls.Add(TaxRTB);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(PointsGainedRTB);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(LitresPerDollarRTB);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(FirstNameRTB);
            groupBox4.Controls.Add(LitresRTB);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Controls.Add(OctaneCombo);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(GasCompanyCombo);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(AddressRTB);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(PumpNumberRTB);
            groupBox4.Location = new Point(422, 238);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(661, 231);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gas Station Information";
            // 
            // InvoiceRTB
            // 
            InvoiceRTB.Location = new Point(521, 49);
            InvoiceRTB.Name = "InvoiceRTB";
            InvoiceRTB.Size = new Size(134, 28);
            InvoiceRTB.TabIndex = 33;
            InvoiceRTB.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(521, 25);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 32;
            label13.Text = "Invoice #";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(456, 152);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 31;
            label12.Text = "Last Name";
            // 
            // LastNameRTB
            // 
            LastNameRTB.Location = new Point(456, 175);
            LastNameRTB.Name = "LastNameRTB";
            LastNameRTB.Size = new Size(199, 28);
            LastNameRTB.TabIndex = 30;
            LastNameRTB.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(189, 89);
            label11.Name = "label11";
            label11.Size = new Size(137, 20);
            label11.TabIndex = 29;
            label11.Text = "Date Purchased";
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Italic);
            CopyrightLabel.Location = new Point(530, 475);
            CopyrightLabel.Margin = new Padding(1, 0, 1, 0);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(259, 15);
            CopyrightLabel.TabIndex = 30;
            CopyrightLabel.Text = "Copyright © Ramiyan Gangatharan -  2023 ";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1358, 500);
            Controls.Add(CopyrightLabel);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(GasGrid);
            Controls.Add(menuStrip1);
            Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Window";
            Text = "Ramiyan's Gasoline Expenditure";
            FormClosed += Window_FormClosed;
            Load += Window_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GasGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem supportToolStripMenuItem;
        private DataGridView GasGrid;
        private Label label1;
        private RichTextBox AddressRTB;
        private Label label2;
        private Label label3;
        private RichTextBox PumpNumberRTB;
        private Label label4;
        private RichTextBox LitresRTB;
        private Label label5;
        private RichTextBox LitresPerDollarRTB;
        private Label label6;
        private RichTextBox TaxRTB;
        private Label label8;
        private RichTextBox TotalPointsRTB;
        private Label label7;
        private RichTextBox PointsGainedRTB;
        private Label label9;
        private RichTextBox FirstNameRTB;
        private Label label10;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button5;
        private Button button6;
        private Button ClearButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button UploadButton;
        private DateTimePicker dateTimePicker1;
        private ComboBox GasCompanyCombo;
        private ComboBox OctaneCombo;
        private GroupBox groupBox4;
        private Label label11;
        private Label label12;
        private RichTextBox LastNameRTB;
        private RichTextBox InvoiceRTB;
        private Label label13;
        private Button ResetButton;
        private Button ExitButton;
        private Label PriceLabel;
        private Label PumpLabel;
        private Label FuelLabel;
        private Label TotalPointsLabel;
        private Label PointsGainedLabel;
        private Label DateLabel;
        private Label OctaneLabel;
        private Label CopyrightLabel;
    }
}
