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
			this.ReadLabelButton = new System.Windows.Forms.Button();
			this.SelectDirLabel = new System.Windows.Forms.LinkLabel();
			this.DirTextBox = new System.Windows.Forms.TextBox();
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
			this.FormTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FormTable.Name = "FormTable";
			this.FormTable.RowCount = 3;
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FormTable.Size = new System.Drawing.Size(576, 402);
			this.FormTable.TabIndex = 0;
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HeaderLabel.Location = new System.Drawing.Point(4, 0);
			this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Padding = new System.Windows.Forms.Padding(18);
			this.HeaderLabel.Size = new System.Drawing.Size(568, 56);
			this.HeaderLabel.TabIndex = 1;
			this.HeaderLabel.Text = "Select a label template to use and print.\r\n";
			this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DirControlPanel
			// 
			this.DirControlPanel.AutoSize = true;
			this.DirControlPanel.Controls.Add(this.ReadLabelButton);
			this.DirControlPanel.Controls.Add(this.SelectDirLabel);
			this.DirControlPanel.Controls.Add(this.DirTextBox);
			this.DirControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DirControlPanel.Location = new System.Drawing.Point(4, 61);
			this.DirControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DirControlPanel.Name = "DirControlPanel";
			this.DirControlPanel.Size = new System.Drawing.Size(568, 38);
			this.DirControlPanel.TabIndex = 2;
			// 
			// ReadLabelButton
			// 
			this.ReadLabelButton.AutoSize = true;
			this.ReadLabelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ReadLabelButton.Location = new System.Drawing.Point(458, 3);
			this.ReadLabelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReadLabelButton.Name = "ReadLabelButton";
			this.ReadLabelButton.Size = new System.Drawing.Size(101, 30);
			this.ReadLabelButton.TabIndex = 2;
			this.ReadLabelButton.Text = "Read Label";
			this.ReadLabelButton.UseVisualStyleBackColor = true;
			this.ReadLabelButton.Click += new System.EventHandler(this.ReadLabelButton_Click);
			// 
			// SelectDirLabel
			// 
			this.SelectDirLabel.AutoSize = true;
			this.SelectDirLabel.Location = new System.Drawing.Point(262, 9);
			this.SelectDirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SelectDirLabel.Name = "SelectDirLabel";
			this.SelectDirLabel.Size = new System.Drawing.Size(115, 20);
			this.SelectDirLabel.TabIndex = 1;
			this.SelectDirLabel.TabStop = true;
			this.SelectDirLabel.Text = "Select Folder...";
			this.SelectDirLabel.Click += new System.EventHandler(this.SelectDirLabel_Click);
			// 
			// DirTextBox
			// 
			this.DirTextBox.Location = new System.Drawing.Point(14, 5);
			this.DirTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DirTextBox.Name = "DirTextBox";
			this.DirTextBox.ReadOnly = true;
			this.DirTextBox.Size = new System.Drawing.Size(238, 26);
			this.DirTextBox.TabIndex = 0;
			// 
			// TemplateListBox
			// 
			this.TemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TemplateListBox.FormattingEnabled = true;
			this.TemplateListBox.ItemHeight = 20;
			this.TemplateListBox.Location = new System.Drawing.Point(4, 109);
			this.TemplateListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TemplateListBox.Name = "TemplateListBox";
			this.TemplateListBox.Size = new System.Drawing.Size(568, 288);
			this.TemplateListBox.TabIndex = 3;
			this.TemplateListBox.DoubleClick += new System.EventHandler(this.TemplateListBox_DoubleClick);
			// 
			// LabelTemplateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 402);
			this.Controls.Add(this.FormTable);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
		private System.Windows.Forms.Button ReadLabelButton;
	}
}