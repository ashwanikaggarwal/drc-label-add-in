namespace DRC.WordAddIn.BarcodeLabels
{
    partial class AddInRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AddInRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.LabelsTab = this.Factory.CreateRibbonTab();
			this.DataGroup = this.Factory.CreateRibbonGroup();
			this.LabelsGroup = this.Factory.CreateRibbonGroup();
			this.AddInGroup = this.Factory.CreateRibbonGroup();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.DataButton = this.Factory.CreateRibbonButton();
			this.CreateLabelsButton = this.Factory.CreateRibbonButton();
			this.UpdateButton = this.Factory.CreateRibbonButton();
			this.InsertFieldsButton = this.Factory.CreateRibbonButton();
			this.ExecuteButton = this.Factory.CreateRibbonButton();
			this.StatusButton = this.Factory.CreateRibbonButton();
			this.ToggleButton = this.Factory.CreateRibbonButton();
			this.LabelsTab.SuspendLayout();
			this.DataGroup.SuspendLayout();
			this.LabelsGroup.SuspendLayout();
			this.AddInGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelsTab
			// 
			this.LabelsTab.Groups.Add(this.DataGroup);
			this.LabelsTab.Groups.Add(this.LabelsGroup);
			this.LabelsTab.Groups.Add(this.AddInGroup);
			this.LabelsTab.Label = "Labels";
			this.LabelsTab.Name = "LabelsTab";
			// 
			// DataGroup
			// 
			this.DataGroup.Items.Add(this.DataButton);
			this.DataGroup.Label = "Data";
			this.DataGroup.Name = "DataGroup";
			// 
			// LabelsGroup
			// 
			this.LabelsGroup.Items.Add(this.CreateLabelsButton);
			this.LabelsGroup.Items.Add(this.UpdateButton);
			this.LabelsGroup.Items.Add(this.InsertFieldsButton);
			this.LabelsGroup.Items.Add(this.ExecuteButton);
			this.LabelsGroup.Label = "Labels";
			this.LabelsGroup.Name = "LabelsGroup";
			// 
			// AddInGroup
			// 
			this.AddInGroup.Items.Add(this.StatusButton);
			this.AddInGroup.Items.Add(this.ToggleButton);
			this.AddInGroup.Label = "Add-In";
			this.AddInGroup.Name = "AddInGroup";
			// 
			// DataButton
			// 
			this.DataButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.DataButton.Label = "Manage Data";
			this.DataButton.Name = "DataButton";
			this.DataButton.ShowImage = true;
			this.DataButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DataButton_Click);
			// 
			// CreateLabelsButton
			// 
			this.CreateLabelsButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.CreateLabelsButton.Label = "Create Labels";
			this.CreateLabelsButton.Name = "CreateLabelsButton";
			this.CreateLabelsButton.ShowImage = true;
			this.CreateLabelsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateLabelsButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.UpdateButton.Label = "Update Labels";
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.ShowImage = true;
			this.UpdateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.UpdateButton_Click);
			// 
			// InsertFieldsButton
			// 
			this.InsertFieldsButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.InsertFieldsButton.Label = "Insert Fields";
			this.InsertFieldsButton.Name = "InsertFieldsButton";
			this.InsertFieldsButton.ShowImage = true;
			this.InsertFieldsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InsertFieldsButton_Click);
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.ExecuteButton.Label = "Finish Labels";
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.ShowImage = true;
			this.ExecuteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ExecuteButton_Click);
			// 
			// StatusButton
			// 
			this.StatusButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.StatusButton.Label = "Status";
			this.StatusButton.Name = "StatusButton";
			this.StatusButton.ShowImage = true;
			this.StatusButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.StatusButton_Click);
			// 
			// ToggleButton
			// 
			this.ToggleButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.ToggleButton.Label = "Toggle Field View";
			this.ToggleButton.Name = "ToggleButton";
			this.ToggleButton.ShowImage = true;
			this.ToggleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton_Click);
			// 
			// AddInRibbon
			// 
			this.Name = "AddInRibbon";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.LabelsTab);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AddInRibbon_Load);
			this.LabelsTab.ResumeLayout(false);
			this.LabelsTab.PerformLayout();
			this.DataGroup.ResumeLayout(false);
			this.DataGroup.PerformLayout();
			this.LabelsGroup.ResumeLayout(false);
			this.LabelsGroup.PerformLayout();
			this.AddInGroup.ResumeLayout(false);
			this.AddInGroup.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab LabelsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LabelsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateLabelsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DataButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DataGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AddInGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton StatusButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton UpdateButton;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton InsertFieldsButton;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ExecuteButton;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ToggleButton;
	}

	partial class ThisRibbonCollection
    {
        internal AddInRibbon Ribbon1
        {
            get { return this.GetRibbon<AddInRibbon>(); }
        }
    }
}
