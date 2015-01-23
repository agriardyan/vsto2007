namespace Notaris2007
{
    partial class RibbonNotaris : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonNotaris()
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
            this.Notaris = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.aktaDefaultButton = this.Factory.CreateRibbonSplitButton();
            this.aktaKendaraanButton = this.Factory.CreateRibbonButton();
            this.aktaTanahButton = this.Factory.CreateRibbonButton();
            this.Notaris.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // Notaris
            // 
            this.Notaris.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Notaris.Groups.Add(this.group1);
            this.Notaris.Groups.Add(this.group2);
            this.Notaris.Label = "Notaris";
            this.Notaris.Name = "Notaris";
            // 
            // group1
            // 
            this.group1.Label = "About";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.aktaDefaultButton);
            this.group2.Label = "Document";
            this.group2.Name = "group2";
            // 
            // aktaDefaultButton
            // 
            this.aktaDefaultButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.aktaDefaultButton.Items.Add(this.aktaKendaraanButton);
            this.aktaDefaultButton.Items.Add(this.aktaTanahButton);
            this.aktaDefaultButton.Label = "Buat Dokumen";
            this.aktaDefaultButton.Name = "aktaDefaultButton";
            this.aktaDefaultButton.OfficeImageId = "FilePrepareMenu";
            // 
            // aktaKendaraanButton
            // 
            this.aktaKendaraanButton.Label = "Akta Kendaraan";
            this.aktaKendaraanButton.Name = "aktaKendaraanButton";
            this.aktaKendaraanButton.ShowImage = true;
            this.aktaKendaraanButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.aktaKendaraanButton_Click);
            // 
            // aktaTanahButton
            // 
            this.aktaTanahButton.Label = "Akta Tanah";
            this.aktaTanahButton.Name = "aktaTanahButton";
            this.aktaTanahButton.ShowImage = true;
            // 
            // RibbonNotaris
            // 
            this.Name = "RibbonNotaris";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.Notaris);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonNotaris_Load);
            this.Notaris.ResumeLayout(false);
            this.Notaris.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Notaris;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton aktaDefaultButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton aktaKendaraanButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton aktaTanahButton;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonNotaris RibbonNotaris
        {
            get { return this.GetRibbon<RibbonNotaris>(); }
        }
    }
}
