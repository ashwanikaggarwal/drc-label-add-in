namespace DRC.WordAddIn.BarcodeLabels
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.CreateLabelsButton = this.Factory.CreateRibbonButton();
            this.ViewDataButton = this.Factory.CreateRibbonButton();
            this.ImportDataButton = this.Factory.CreateRibbonButton();
            this.AddInGroup = this.Factory.CreateRibbonGroup();
            this.StatusButton = this.Factory.CreateRibbonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.AddInGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.AddInGroup);
            this.tab1.Label = "Labels";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.CreateLabelsButton);
            this.group1.Label = "Labels";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.ViewDataButton);
            this.group2.Items.Add(this.ImportDataButton);
            this.group2.Label = "Data";
            this.group2.Name = "group2";
            // 
            // CreateLabelsButton
            // 
            this.CreateLabelsButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.CreateLabelsButton.Label = "Create Labels";
            this.CreateLabelsButton.Name = "CreateLabelsButton";
            this.CreateLabelsButton.ShowImage = true;
            this.CreateLabelsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateLabelsButton_Click);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ViewDataButton.Label = "View Data";
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.ShowImage = true;
            this.ViewDataButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ViewLabelsButton_Click);
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ImportDataButton.Label = "Import Data";
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.ShowImage = true;
            this.ImportDataButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ImportDataButton_Click);
            // 
            // AddInGroup
            // 
            this.AddInGroup.Items.Add(this.StatusButton);
            this.AddInGroup.Label = "Add-In";
            this.AddInGroup.Name = "AddInGroup";
            // 
            // StatusButton
            // 
            this.StatusButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.StatusButton.Label = "Status";
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.ShowImage = true;
            this.StatusButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.StatusButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.AddInGroup.ResumeLayout(false);
            this.AddInGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateLabelsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ViewDataButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportDataButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AddInGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton StatusButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
