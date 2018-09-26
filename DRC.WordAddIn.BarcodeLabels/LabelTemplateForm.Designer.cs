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
            this.TemplateGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.TemplateListBox = new System.Windows.Forms.ListBox();
            this.FormTable.SuspendLayout();
            this.TemplateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTable
            // 
            this.FormTable.AutoSize = true;
            this.FormTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormTable.ColumnCount = 1;
            this.FormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormTable.Controls.Add(this.HeaderLabel, 0, 0);
            this.FormTable.Controls.Add(this.TemplateGroupBox, 0, 1);
            this.FormTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTable.Location = new System.Drawing.Point(0, 0);
            this.FormTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FormTable.Name = "FormTable";
            this.FormTable.RowCount = 2;
            this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FormTable.Size = new System.Drawing.Size(550, 376);
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
            this.HeaderLabel.Size = new System.Drawing.Size(542, 56);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Select a label template to use and print.\r\n";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TemplateGroupBox
            // 
            this.TemplateGroupBox.Controls.Add(this.ExitButton);
            this.TemplateGroupBox.Controls.Add(this.OKButton);
            this.TemplateGroupBox.Controls.Add(this.TemplateListBox);
            this.TemplateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplateGroupBox.Location = new System.Drawing.Point(3, 59);
            this.TemplateGroupBox.Name = "TemplateGroupBox";
            this.TemplateGroupBox.Size = new System.Drawing.Size(544, 314);
            this.TemplateGroupBox.TabIndex = 3;
            this.TemplateGroupBox.TabStop = false;
            this.TemplateGroupBox.Text = "Label Templates";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(460, 270);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.AutoSize = true;
            this.OKButton.Location = new System.Drawing.Point(379, 270);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 30);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TemplateListBox
            // 
            this.TemplateListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TemplateListBox.FormattingEnabled = true;
            this.TemplateListBox.ItemHeight = 20;
            this.TemplateListBox.Location = new System.Drawing.Point(9, 25);
            this.TemplateListBox.Name = "TemplateListBox";
            this.TemplateListBox.Size = new System.Drawing.Size(352, 264);
            this.TemplateListBox.TabIndex = 0;
            this.TemplateListBox.DoubleClick += new System.EventHandler(this.TemplateListBox_DoubleClick);
            // 
            // LabelTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.Controls.Add(this.FormTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LabelTemplateForm";
            this.Text = "Label Selection";
            this.FormTable.ResumeLayout(false);
            this.FormTable.PerformLayout();
            this.TemplateGroupBox.ResumeLayout(false);
            this.TemplateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel FormTable;
		private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.GroupBox TemplateGroupBox;
        private System.Windows.Forms.ListBox TemplateListBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ExitButton;
    }
}