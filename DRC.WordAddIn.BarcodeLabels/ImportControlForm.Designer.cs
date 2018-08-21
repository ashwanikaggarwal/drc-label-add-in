namespace DRC.WordAddIn.BarcodeLabels
{
	partial class ImportControlForm
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
			this.ControlTable = new System.Windows.Forms.TableLayoutPanel();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SerialNumLabel = new System.Windows.Forms.Label();
			this.BarcodeLabel = new System.Windows.Forms.Label();
			this.NameCBox = new System.Windows.Forms.ComboBox();
			this.SerialNumCBox = new System.Windows.Forms.ComboBox();
			this.BarcodeCBox = new System.Windows.Forms.ComboBox();
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.VerticalTable = new System.Windows.Forms.TableLayoutPanel();
			this.TableViewer = new System.Windows.Forms.DataGridView();
			this.ControlTable.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.VerticalTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TableViewer)).BeginInit();
			this.SuspendLayout();
			// 
			// ControlTable
			// 
			this.ControlTable.AutoSize = true;
			this.ControlTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ControlTable.ColumnCount = 3;
			this.ControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ControlTable.Controls.Add(this.NameLabel, 0, 0);
			this.ControlTable.Controls.Add(this.SerialNumLabel, 1, 0);
			this.ControlTable.Controls.Add(this.BarcodeLabel, 2, 0);
			this.ControlTable.Controls.Add(this.NameCBox, 0, 1);
			this.ControlTable.Controls.Add(this.SerialNumCBox, 1, 1);
			this.ControlTable.Controls.Add(this.BarcodeCBox, 2, 1);
			this.ControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlTable.Location = new System.Drawing.Point(3, 3);
			this.ControlTable.Name = "ControlTable";
			this.ControlTable.RowCount = 2;
			this.ControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ControlTable.Size = new System.Drawing.Size(414, 54);
			this.ControlTable.TabIndex = 0;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NameLabel.Location = new System.Drawing.Point(3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(132, 27);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Item Name Field";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SerialNumLabel
			// 
			this.SerialNumLabel.AutoSize = true;
			this.SerialNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SerialNumLabel.Location = new System.Drawing.Point(141, 0);
			this.SerialNumLabel.Name = "SerialNumLabel";
			this.SerialNumLabel.Size = new System.Drawing.Size(132, 27);
			this.SerialNumLabel.TabIndex = 1;
			this.SerialNumLabel.Text = "Serial Number Field";
			this.SerialNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BarcodeLabel
			// 
			this.BarcodeLabel.AutoSize = true;
			this.BarcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BarcodeLabel.Location = new System.Drawing.Point(279, 0);
			this.BarcodeLabel.Name = "BarcodeLabel";
			this.BarcodeLabel.Size = new System.Drawing.Size(132, 27);
			this.BarcodeLabel.TabIndex = 2;
			this.BarcodeLabel.Text = "Barcode Field";
			this.BarcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NameCBox
			// 
			this.NameCBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NameCBox.FormattingEnabled = true;
			this.NameCBox.Location = new System.Drawing.Point(3, 30);
			this.NameCBox.Name = "NameCBox";
			this.NameCBox.Size = new System.Drawing.Size(132, 21);
			this.NameCBox.TabIndex = 3;
			this.NameCBox.Text = "<name>";
			// 
			// SerialNumCBox
			// 
			this.SerialNumCBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SerialNumCBox.FormattingEnabled = true;
			this.SerialNumCBox.Location = new System.Drawing.Point(141, 30);
			this.SerialNumCBox.Name = "SerialNumCBox";
			this.SerialNumCBox.Size = new System.Drawing.Size(132, 21);
			this.SerialNumCBox.TabIndex = 4;
			this.SerialNumCBox.Text = "<serial number>";
			// 
			// BarcodeCBox
			// 
			this.BarcodeCBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BarcodeCBox.FormattingEnabled = true;
			this.BarcodeCBox.Location = new System.Drawing.Point(279, 30);
			this.BarcodeCBox.Name = "BarcodeCBox";
			this.BarcodeCBox.Size = new System.Drawing.Size(132, 21);
			this.BarcodeCBox.TabIndex = 5;
			this.BarcodeCBox.Text = "<barcode>";
			// 
			// AcceptButton
			// 
			this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AcceptButton.AutoSize = true;
			this.AcceptButton.Location = new System.Drawing.Point(254, 3);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(76, 23);
			this.AcceptButton.TabIndex = 0;
			this.AcceptButton.Text = "Finish Import";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.AutoSize = true;
			this.CancelButton.Location = new System.Drawing.Point(336, 3);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 0;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.Controls.Add(this.CancelButton);
			this.ButtonPanel.Controls.Add(this.AcceptButton);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonPanel.Location = new System.Drawing.Point(3, 63);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(414, 29);
			this.ButtonPanel.TabIndex = 1;
			// 
			// VerticalTable
			// 
			this.VerticalTable.AutoSize = true;
			this.VerticalTable.ColumnCount = 1;
			this.VerticalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.VerticalTable.Controls.Add(this.ControlTable, 0, 0);
			this.VerticalTable.Controls.Add(this.ButtonPanel, 0, 1);
			this.VerticalTable.Controls.Add(this.TableViewer, 0, 2);
			this.VerticalTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VerticalTable.Location = new System.Drawing.Point(0, 0);
			this.VerticalTable.Name = "VerticalTable";
			this.VerticalTable.RowCount = 3;
			this.VerticalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.VerticalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.VerticalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.VerticalTable.Size = new System.Drawing.Size(418, 140);
			this.VerticalTable.TabIndex = 2;
			// 
			// TableViewer
			// 
			this.TableViewer.AllowUserToAddRows = false;
			this.TableViewer.AllowUserToDeleteRows = false;
			this.TableViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.TableViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.TableViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableViewer.Location = new System.Drawing.Point(3, 98);
			this.TableViewer.Name = "TableViewer";
			this.TableViewer.ReadOnly = true;
			this.TableViewer.Size = new System.Drawing.Size(414, 150);
			this.TableViewer.TabIndex = 2;
			// 
			// ImportControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(418, 140);
			this.Controls.Add(this.VerticalTable);
			this.Name = "ImportControlForm";
			this.Text = "Select Import Fields";
			this.Load += new System.EventHandler(this.ImportControlForm_Load);
			this.ControlTable.ResumeLayout(false);
			this.ControlTable.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.VerticalTable.ResumeLayout(false);
			this.VerticalTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TableViewer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel ControlTable;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label SerialNumLabel;
		private System.Windows.Forms.Label BarcodeLabel;
		private System.Windows.Forms.ComboBox NameCBox;
		private System.Windows.Forms.ComboBox SerialNumCBox;
		private System.Windows.Forms.ComboBox BarcodeCBox;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button AcceptButton;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.TableLayoutPanel VerticalTable;
		private System.Windows.Forms.DataGridView TableViewer;
	}
}