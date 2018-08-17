namespace DRC.WordAddIn.BarcodeLabels
{
    partial class DataForm
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
            this.ManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AdditionGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueControlTable = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SerialNumLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumTextBox = new System.Windows.Forms.TextBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddBlankButton = new System.Windows.Forms.Button();
            this.BlankNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.ManagementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.AdditionGroupBox.SuspendLayout();
            this.ValueControlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlankNumberPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagementGroupBox
            // 
            this.ManagementGroupBox.Controls.Add(this.BlankNumberPicker);
            this.ManagementGroupBox.Controls.Add(this.DeleteButton);
            this.ManagementGroupBox.Controls.Add(this.AddBlankButton);
            this.ManagementGroupBox.Controls.Add(this.ImportButton);
            this.ManagementGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagementGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ManagementGroupBox.Name = "ManagementGroupBox";
            this.ManagementGroupBox.Size = new System.Drawing.Size(206, 154);
            this.ManagementGroupBox.TabIndex = 3;
            this.ManagementGroupBox.TabStop = false;
            this.ManagementGroupBox.Text = "Item Management";
            // 
            // ImportButton
            // 
            this.ImportButton.AutoSize = true;
            this.ImportButton.Location = new System.Drawing.Point(13, 26);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(138, 30);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Import from CSV";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Location = new System.Drawing.Point(0, 0);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.RowTemplate.Height = 28;
            this.ItemGrid.Size = new System.Drawing.Size(800, 292);
            this.ItemGrid.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Location = new System.Drawing.Point(13, 62);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(177, 30);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete Selected Items";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ItemGrid);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ManagementGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AdditionGroupBox);
            this.splitContainer2.Size = new System.Drawing.Size(800, 154);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 4;
            // 
            // AdditionGroupBox
            // 
            this.AdditionGroupBox.Controls.Add(this.splitContainer3);
            this.AdditionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AdditionGroupBox.Name = "AdditionGroupBox";
            this.AdditionGroupBox.Size = new System.Drawing.Size(590, 154);
            this.AdditionGroupBox.TabIndex = 0;
            this.AdditionGroupBox.TabStop = false;
            this.AdditionGroupBox.Text = "Add Items";
            // 
            // ValueControlTable
            // 
            this.ValueControlTable.ColumnCount = 2;
            this.ValueControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ValueControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ValueControlTable.Controls.Add(this.NameLabel, 0, 0);
            this.ValueControlTable.Controls.Add(this.SerialNumLabel, 0, 1);
            this.ValueControlTable.Controls.Add(this.NameTextBox, 1, 0);
            this.ValueControlTable.Controls.Add(this.SerialNumTextBox, 1, 1);
            this.ValueControlTable.Controls.Add(this.BarcodeLabel, 0, 2);
            this.ValueControlTable.Controls.Add(this.BarcodeTextBox, 1, 2);
            this.ValueControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueControlTable.Location = new System.Drawing.Point(0, 0);
            this.ValueControlTable.Name = "ValueControlTable";
            this.ValueControlTable.RowCount = 3;
            this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ValueControlTable.Size = new System.Drawing.Size(412, 129);
            this.ValueControlTable.TabIndex = 0;
            this.ValueControlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(113, 42);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Item Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialNumLabel
            // 
            this.SerialNumLabel.AutoSize = true;
            this.SerialNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialNumLabel.Location = new System.Drawing.Point(3, 42);
            this.SerialNumLabel.Name = "SerialNumLabel";
            this.SerialNumLabel.Size = new System.Drawing.Size(113, 42);
            this.SerialNumLabel.TabIndex = 1;
            this.SerialNumLabel.Text = "Serial Number:";
            this.SerialNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(122, 8);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(287, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // SerialNumTextBox
            // 
            this.SerialNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNumTextBox.Location = new System.Drawing.Point(122, 50);
            this.SerialNumTextBox.Name = "SerialNumTextBox";
            this.SerialNumTextBox.Size = new System.Drawing.Size(287, 26);
            this.SerialNumTextBox.TabIndex = 3;
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeLabel.Location = new System.Drawing.Point(3, 84);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(113, 45);
            this.BarcodeLabel.TabIndex = 4;
            this.BarcodeLabel.Text = "Barcode:";
            this.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(122, 93);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(287, 26);
            this.BarcodeTextBox.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 22);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ValueControlTable);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.AddButton);
            this.splitContainer3.Size = new System.Drawing.Size(584, 129);
            this.splitContainer3.SplitterDistance = 412;
            this.splitContainer3.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 129);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddBlankButton
            // 
            this.AddBlankButton.AutoSize = true;
            this.AddBlankButton.Location = new System.Drawing.Point(13, 98);
            this.AddBlankButton.Name = "AddBlankButton";
            this.AddBlankButton.Size = new System.Drawing.Size(112, 30);
            this.AddBlankButton.TabIndex = 1;
            this.AddBlankButton.Text = "Insert Blanks";
            this.AddBlankButton.UseVisualStyleBackColor = true;
            // 
            // BlankNumberPicker
            // 
            this.BlankNumberPicker.AutoSize = true;
            this.BlankNumberPicker.Location = new System.Drawing.Point(140, 98);
            this.BlankNumberPicker.Name = "BlankNumberPicker";
            this.BlankNumberPicker.Size = new System.Drawing.Size(60, 26);
            this.BlankNumberPicker.TabIndex = 2;
            this.BlankNumberPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DataForm";
            this.Text = "Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ManagementGroupBox.ResumeLayout(false);
            this.ManagementGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.AdditionGroupBox.ResumeLayout(false);
            this.ValueControlTable.ResumeLayout(false);
            this.ValueControlTable.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlankNumberPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ManagementGroupBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox AdditionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ValueControlTable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SerialNumLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SerialNumTextBox;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.NumericUpDown BlankNumberPicker;
        private System.Windows.Forms.Button AddBlankButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button AddButton;
    }
}