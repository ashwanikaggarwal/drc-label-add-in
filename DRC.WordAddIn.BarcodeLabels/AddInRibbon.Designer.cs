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
			this.group1 = this.Factory.CreateRibbonGroup();
			this.AddInGroup = this.Factory.CreateRibbonGroup();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.DataButton = this.Factory.CreateRibbonButton();
			this.CreateLabelsButton = this.Factory.CreateRibbonButton();
			this.UpdateButton = this.Factory.CreateRibbonButton();
			this.StatusButton = this.Factory.CreateRibbonButton();
			this.LabelsTab.SuspendLayout();
			this.DataGroup.SuspendLayout();
			this.group1.SuspendLayout();
			this.AddInGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelsTab
			// 
			this.LabelsTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.LabelsTab.Groups.Add(this.DataGroup);
			this.LabelsTab.Groups.Add(this.group1);
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
			// group1
			// 
			this.group1.Items.Add(this.CreateLabelsButton);
			this.group1.Items.Add(this.UpdateButton);
			this.group1.Label = "Labels";
			this.group1.Name = "group1";
			// 
			// AddInGroup
			// 
			this.AddInGroup.Items.Add(this.StatusButton);
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
			// StatusButton
			// 
			this.StatusButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.StatusButton.Label = "Status";
			this.StatusButton.Name = "StatusButton";
			this.StatusButton.ShowImage = true;
			this.StatusButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.StatusButton_Click);
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
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.AddInGroup.ResumeLayout(false);
			this.AddInGroup.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab LabelsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateLabelsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DataButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DataGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AddInGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton StatusButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton UpdateButton;
	}

	partial class ThisRibbonCollection
    {
        internal AddInRibbon Ribbon1
        {
            get { return this.GetRibbon<AddInRibbon>(); }
        }
    }
}
