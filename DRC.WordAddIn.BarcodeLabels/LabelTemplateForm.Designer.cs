namespace DRC.WordAddIn.BarcodeLabels
{
	partial class LabelTemplateForm
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
			this.FormTable = new System.Windows.Forms.TableLayoutPanel();
			this.HeaderLabel = new System.Windows.Forms.Label();
			this.DirControlPanel = new System.Windows.Forms.Panel();
			this.DirTextBox = new System.Windows.Forms.TextBox();
			this.SelectDirLabel = new System.Windows.Forms.LinkLabel();
			this.TemplateListBox = new System.Windows.Forms.ListBox();
			this.FormTable.SuspendLayout();
			this.DirControlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// FormTable
			// 
			this.FormTable.ColumnCount = 1;
			this.FormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormTable.Controls.Add(this.HeaderLabel, 0, 0);
			this.FormTable.Controls.Add(this.DirControlPanel, 0, 1);
			this.FormTable.Controls.Add(this.TemplateListBox, 0, 2);
			this.FormTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormTable.Location = new System.Drawing.Point(0, 0);
			this.FormTable.Name = "FormTable";
			this.FormTable.RowCount = 3;
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormTable.Size = new System.Drawing.Size(384, 261);
			this.FormTable.TabIndex = 0;
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HeaderLabel.Location = new System.Drawing.Point(3, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Padding = new System.Windows.Forms.Padding(12);
			this.HeaderLabel.Size = new System.Drawing.Size(378, 37);
			this.HeaderLabel.TabIndex = 1;
			this.HeaderLabel.Text = "Select a label template to use and print.\r\n";
			this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DirControlPanel
			// 
			this.DirControlPanel.AutoSize = true;
			this.DirControlPanel.Controls.Add(this.SelectDirLabel);
			this.DirControlPanel.Controls.Add(this.DirTextBox);
			this.DirControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DirControlPanel.Location = new System.Drawing.Point(3, 40);
			this.DirControlPanel.Name = "DirControlPanel";
			this.DirControlPanel.Size = new System.Drawing.Size(378, 26);
			this.DirControlPanel.TabIndex = 2;
			// 
			// DirTextBox
			// 
			this.DirTextBox.Location = new System.Drawing.Point(9, 3);
			this.DirTextBox.Name = "DirTextBox";
			this.DirTextBox.ReadOnly = true;
			this.DirTextBox.Size = new System.Drawing.Size(160, 20);
			this.DirTextBox.TabIndex = 0;
			// 
			// SelectDirLabel
			// 
			this.SelectDirLabel.AutoSize = true;
			this.SelectDirLabel.Location = new System.Drawing.Point(175, 6);
			this.SelectDirLabel.Name = "SelectDirLabel";
			this.SelectDirLabel.Size = new System.Drawing.Size(78, 13);
			this.SelectDirLabel.TabIndex = 1;
			this.SelectDirLabel.TabStop = true;
			this.SelectDirLabel.Text = "Select Folder...";
			this.SelectDirLabel.Click += new System.EventHandler(this.SelectDirLabel_Click);
			// 
			// TemplateListBox
			// 
			this.TemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TemplateListBox.FormattingEnabled = true;
			this.TemplateListBox.Location = new System.Drawing.Point(3, 72);
			this.TemplateListBox.Name = "TemplateListBox";
			this.TemplateListBox.Size = new System.Drawing.Size(378, 186);
			this.TemplateListBox.TabIndex = 3;
			// 
			// LabelTemplateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.FormTable);
			this.Name = "LabelTemplateForm";
			this.Text = "LabelTemplateForm";
			this.FormTable.ResumeLayout(false);
			this.FormTable.PerformLayout();
			this.DirControlPanel.ResumeLayout(false);
			this.DirControlPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel FormTable;
		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Panel DirControlPanel;
		private System.Windows.Forms.LinkLabel SelectDirLabel;
		private System.Windows.Forms.TextBox DirTextBox;
		private System.Windows.Forms.ListBox TemplateListBox;
	}
}