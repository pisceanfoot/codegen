using System;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class TableDesignFrm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TableDesignFrm()
        {
            InitializeComponent();
        }

        private void TableDesignFrm_Load(object sender, EventArgs e)
        {
            ChinaBest.SQLServer.SmoUtilities.SQLColumn column = new ChinaBest.SQLServer.SmoUtilities.SQLColumn();
            this.propertyGridTable.SelectedObject = new ChinaBest.SQLServer.SmoUtilities.Int();
        }
    }
}