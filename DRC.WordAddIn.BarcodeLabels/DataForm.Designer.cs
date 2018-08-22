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
			this.components = new System.ComponentModel.Container();
			this.ManagementGroupBox = new System.Windows.Forms.GroupBox();
			this.ItemControlTable = new System.Windows.Forms.TableLayoutPanel();
			this.ImportButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.BlankSplitContainer = new System.Windows.Forms.SplitContainer();
			this.AddBlanksButton = new System.Windows.Forms.Button();
			this.BlanksUpDown = new System.Windows.Forms.NumericUpDown();
			this.ItemGrid = new System.Windows.Forms.DataGridView();
			this.PrimarySplitContainer = new System.Windows.Forms.SplitContainer();
			this.ControlSplitContainer = new System.Windows.Forms.SplitContainer();
			this.AdditionGroupBox = new System.Windows.Forms.GroupBox();
			this.AdditionSplitContainer = new System.Windows.Forms.SplitContainer();
			this.ValueControlTable = new System.Windows.Forms.TableLayoutPanel();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SerialNumLabel = new System.Windows.Forms.Label();
			this.BarcodeLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.BarcodeTextBox = new System.Windows.Forms.TextBox();
			this.SerialNumTextBox = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ManagementGroupBox.SuspendLayout();
			this.ItemControlTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BlankSplitContainer)).BeginInit();
			this.BlankSplitContainer.Panel1.SuspendLayout();
			this.BlankSplitContainer.Panel2.SuspendLayout();
			this.BlankSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BlanksUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PrimarySplitContainer)).BeginInit();
			this.PrimarySplitContainer.Panel1.SuspendLayout();
			this.PrimarySplitContainer.Panel2.SuspendLayout();
			this.PrimarySplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ControlSplitContainer)).BeginInit();
			this.ControlSplitContainer.Panel1.SuspendLayout();
			this.ControlSplitContainer.Panel2.SuspendLayout();
			this.ControlSplitContainer.SuspendLayout();
			this.AdditionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AdditionSplitContainer)).BeginInit();
			this.AdditionSplitContainer.Panel1.SuspendLayout();
			this.AdditionSplitContainer.Panel2.SuspendLayout();
			this.AdditionSplitContainer.SuspendLayout();
			this.ValueControlTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ManagementGroupBox
			// 
			this.ManagementGroupBox.Controls.Add(this.ItemControlTable);
			this.ManagementGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ManagementGroupBox.Location = new System.Drawing.Point(0, 0);
			this.ManagementGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ManagementGroupBox.Name = "ManagementGroupBox";
			this.ManagementGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ManagementGroupBox.Size = new System.Drawing.Size(164, 98);
			this.ManagementGroupBox.TabIndex = 3;
			this.ManagementGroupBox.TabStop = false;
			this.ManagementGroupBox.Text = "Item Management";
			// 
			// ItemControlTable
			// 
			this.ItemControlTable.ColumnCount = 1;
			this.ItemControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ItemControlTable.Controls.Add(this.ImportButton, 0, 0);
			this.ItemControlTable.Controls.Add(this.DeleteButton, 0, 1);
			this.ItemControlTable.Controls.Add(this.BlankSplitContainer, 0, 2);
			this.ItemControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemControlTable.Location = new System.Drawing.Point(2, 15);
			this.ItemControlTable.Name = "ItemControlTable";
			this.ItemControlTable.RowCount = 3;
			this.ItemControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ItemControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ItemControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ItemControlTable.Size = new System.Drawing.Size(160, 81);
			this.ItemControlTable.TabIndex = 3;
			// 
			// ImportButton
			// 
			this.ImportButton.AutoSize = true;
			this.ImportButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ImportButton.Location = new System.Drawing.Point(2, 2);
			this.ImportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ImportButton.Name = "ImportButton";
			this.ImportButton.Size = new System.Drawing.Size(156, 23);
			this.ImportButton.TabIndex = 0;
			this.ImportButton.Text = "Import from CSV";
			this.ImportButton.UseVisualStyleBackColor = true;
			this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.AutoSize = true;
			this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DeleteButton.Location = new System.Drawing.Point(2, 29);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(156, 23);
			this.DeleteButton.TabIndex = 1;
			this.DeleteButton.Text = "Delete Selected Items";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// BlankSplitContainer
			// 
			this.BlankSplitContainer.Location = new System.Drawing.Point(3, 57);
			this.BlankSplitContainer.Name = "BlankSplitContainer";
			// 
			// BlankSplitContainer.Panel1
			// 
			this.BlankSplitContainer.Panel1.Controls.Add(this.AddBlanksButton);
			// 
			// BlankSplitContainer.Panel2
			// 
			this.BlankSplitContainer.Panel2.Controls.Add(this.BlanksUpDown);
			this.BlankSplitContainer.Size = new System.Drawing.Size(150, 20);
			this.BlankSplitContainer.SplitterDistance = 96;
			this.BlankSplitContainer.TabIndex = 2;
			// 
			// AddBlanksButton
			// 
			this.AddBlanksButton.AutoSize = true;
			this.AddBlanksButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddBlanksButton.Location = new System.Drawing.Point(0, 0);
			this.AddBlanksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AddBlanksButton.Name = "AddBlanksButton";
			this.AddBlanksButton.Size = new System.Drawing.Size(96, 20);
			this.AddBlanksButton.TabIndex = 1;
			this.AddBlanksButton.Text = "Insert Blanks";
			this.AddBlanksButton.UseVisualStyleBackColor = true;
			this.AddBlanksButton.Click += new System.EventHandler(this.AddBlanksButton_Click);
			// 
			// BlanksUpDown
			// 
			this.BlanksUpDown.AutoSize = true;
			this.BlanksUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BlanksUpDown.Location = new System.Drawing.Point(0, 0);
			this.BlanksUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BlanksUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.BlanksUpDown.Name = "BlanksUpDown";
			this.BlanksUpDown.Size = new System.Drawing.Size(50, 20);
			this.BlanksUpDown.TabIndex = 2;
			this.BlanksUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ItemGrid
			// 
			this.ItemGrid.AllowUserToAddRows = false;
			this.ItemGrid.AllowUserToDeleteRows = false;
			this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ItemGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ItemGrid.Location = new System.Drawing.Point(0, 0);
			this.ItemGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ItemGrid.Name = "ItemGrid";
			this.ItemGrid.ReadOnly = true;
			this.ItemGrid.RowTemplate.Height = 28;
			this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ItemGrid.Size = new System.Drawing.Size(533, 191);
			this.ItemGrid.TabIndex = 4;
			this.ItemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGrid_CellContentClick);
			this.ItemGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemGrid_Paint);
			// 
			// PrimarySplitContainer
			// 
			this.PrimarySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PrimarySplitContainer.Location = new System.Drawing.Point(0, 0);
			this.PrimarySplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PrimarySplitContainer.Name = "PrimarySplitContainer";
			this.PrimarySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// PrimarySplitContainer.Panel1
			// 
			this.PrimarySplitContainer.Panel1.Controls.Add(this.ControlSplitContainer);
			// 
			// PrimarySplitContainer.Panel2
			// 
			this.PrimarySplitContainer.Panel2.Controls.Add(this.ItemGrid);
			this.PrimarySplitContainer.Size = new System.Drawing.Size(533, 292);
			this.PrimarySplitContainer.SplitterDistance = 98;
			this.PrimarySplitContainer.SplitterWidth = 3;
			this.PrimarySplitContainer.TabIndex = 5;
			// 
			// ControlSplitContainer
			// 
			this.ControlSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.ControlSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ControlSplitContainer.Name = "ControlSplitContainer";
			// 
			// ControlSplitContainer.Panel1
			// 
			this.ControlSplitContainer.Panel1.Controls.Add(this.ManagementGroupBox);
			// 
			// ControlSplitContainer.Panel2
			// 
			this.ControlSplitContainer.Panel2.Controls.Add(this.AdditionGroupBox);
			this.ControlSplitContainer.Size = new System.Drawing.Size(533, 98);
			this.ControlSplitContainer.SplitterDistance = 164;
			this.ControlSplitContainer.SplitterWidth = 3;
			this.ControlSplitContainer.TabIndex = 4;
			// 
			// AdditionGroupBox
			// 
			this.AdditionGroupBox.Controls.Add(this.AdditionSplitContainer);
			this.AdditionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AdditionGroupBox.Location = new System.Drawing.Point(0, 0);
			this.AdditionGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AdditionGroupBox.Name = "AdditionGroupBox";
			this.AdditionGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AdditionGroupBox.Size = new System.Drawing.Size(366, 98);
			this.AdditionGroupBox.TabIndex = 0;
			this.AdditionGroupBox.TabStop = false;
			this.AdditionGroupBox.Text = "Add Items";
			// 
			// AdditionSplitContainer
			// 
			this.AdditionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AdditionSplitContainer.Location = new System.Drawing.Point(2, 15);
			this.AdditionSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AdditionSplitContainer.Name = "AdditionSplitContainer";
			// 
			// AdditionSplitContainer.Panel1
			// 
			this.AdditionSplitContainer.Panel1.Controls.Add(this.ValueControlTable);
			// 
			// AdditionSplitContainer.Panel2
			// 
			this.AdditionSplitContainer.Panel2.Controls.Add(this.AddButton);
			this.AdditionSplitContainer.Size = new System.Drawing.Size(362, 81);
			this.AdditionSplitContainer.SplitterDistance = 279;
			this.AdditionSplitContainer.SplitterWidth = 3;
			this.AdditionSplitContainer.TabIndex = 1;
			// 
			// ValueControlTable
			// 
			this.ValueControlTable.ColumnCount = 2;
			this.ValueControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.20443F));
			this.ValueControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.79557F));
			this.ValueControlTable.Controls.Add(this.NameLabel, 0, 0);
			this.ValueControlTable.Controls.Add(this.SerialNumLabel, 0, 1);
			this.ValueControlTable.Controls.Add(this.BarcodeLabel, 0, 2);
			this.ValueControlTable.Controls.Add(this.NameTextBox, 1, 0);
			this.ValueControlTable.Controls.Add(this.BarcodeTextBox, 1, 2);
			this.ValueControlTable.Controls.Add(this.SerialNumTextBox, 1, 1);
			this.ValueControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ValueControlTable.Location = new System.Drawing.Point(0, 0);
			this.ValueControlTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ValueControlTable.Name = "ValueControlTable";
			this.ValueControlTable.RowCount = 3;
			this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.19838F));
			this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.43725F));
			this.ValueControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.36437F));
			this.ValueControlTable.Size = new System.Drawing.Size(279, 81);
			this.ValueControlTable.TabIndex = 0;
			this.ValueControlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ValueControlTable_Paint);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NameLabel.Location = new System.Drawing.Point(2, 0);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(91, 26);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Item Name:";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SerialNumLabel
			// 
			this.SerialNumLabel.AutoSize = true;
			this.SerialNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SerialNumLabel.Location = new System.Drawing.Point(2, 26);
			this.SerialNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SerialNumLabel.Name = "SerialNumLabel";
			this.SerialNumLabel.Size = new System.Drawing.Size(91, 29);
			this.SerialNumLabel.TabIndex = 1;
			this.SerialNumLabel.Text = "Serial Number:";
			this.SerialNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BarcodeLabel
			// 
			this.BarcodeLabel.AutoSize = true;
			this.BarcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BarcodeLabel.Location = new System.Drawing.Point(2, 55);
			this.BarcodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BarcodeLabel.Name = "BarcodeLabel";
			this.BarcodeLabel.Size = new System.Drawing.Size(91, 26);
			this.BarcodeLabel.TabIndex = 4;
			this.BarcodeLabel.Text = "Barcode:";
			this.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.Location = new System.Drawing.Point(97, 3);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(180, 20);
			this.NameTextBox.TabIndex = 2;
			// 
			// BarcodeTextBox
			// 
			this.BarcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.BarcodeTextBox.Location = new System.Drawing.Point(97, 58);
			this.BarcodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BarcodeTextBox.Name = "BarcodeTextBox";
			this.BarcodeTextBox.Size = new System.Drawing.Size(180, 20);
			this.BarcodeTextBox.TabIndex = 5;
			// 
			// SerialNumTextBox
			// 
			this.SerialNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SerialNumTextBox.Location = new System.Drawing.Point(97, 30);
			this.SerialNumTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SerialNumTextBox.Name = "SerialNumTextBox";
			this.SerialNumTextBox.Size = new System.Drawing.Size(180, 20);
			this.SerialNumTextBox.TabIndex = 3;
			// 
			// AddButton
			// 
			this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddButton.Location = new System.Drawing.Point(0, 0);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(80, 81);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add Item";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// itemBindingSource
			// 
			this.itemBindingSource.AllowNew = false;
			this.itemBindingSource.DataSource = typeof(DRC.WordAddIn.BarcodeLabels.Item);
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.PrimarySplitContainer);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DataForm";
			this.Text = "Data Manager";
			this.Load += new System.EventHandler(this.DataForm_Load);
			this.ManagementGroupBox.ResumeLayout(false);
			this.ItemControlTable.ResumeLayout(false);
			this.ItemControlTable.PerformLayout();
			this.BlankSplitContainer.Panel1.ResumeLayout(false);
			this.BlankSplitContainer.Panel1.PerformLayout();
			this.BlankSplitContainer.Panel2.ResumeLayout(false);
			this.BlankSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BlankSplitContainer)).EndInit();
			this.BlankSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BlanksUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
			this.PrimarySplitContainer.Panel1.ResumeLayout(false);
			this.PrimarySplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PrimarySplitContainer)).EndInit();
			this.PrimarySplitContainer.ResumeLayout(false);
			this.ControlSplitContainer.Panel1.ResumeLayout(false);
			this.ControlSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ControlSplitContainer)).EndInit();
			this.ControlSplitContainer.ResumeLayout(false);
			this.AdditionGroupBox.ResumeLayout(false);
			this.AdditionSplitContainer.Panel1.ResumeLayout(false);
			this.AdditionSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AdditionSplitContainer)).EndInit();
			this.AdditionSplitContainer.ResumeLayout(false);
			this.ValueControlTable.ResumeLayout(false);
			this.ValueControlTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ManagementGroupBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.SplitContainer PrimarySplitContainer;
        private System.Windows.Forms.SplitContainer ControlSplitContainer;
        private System.Windows.Forms.GroupBox AdditionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ValueControlTable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SerialNumLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SerialNumTextBox;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.NumericUpDown BlanksUpDown;
        private System.Windows.Forms.Button AddBlanksButton;
        private System.Windows.Forms.SplitContainer AdditionSplitContainer;
        private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TableLayoutPanel ItemControlTable;
		private System.Windows.Forms.SplitContainer BlankSplitContainer;
		private System.Windows.Forms.BindingSource itemBindingSource;
	}
}