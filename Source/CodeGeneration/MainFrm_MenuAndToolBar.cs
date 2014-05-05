using System;
using WeifenLuo.WinFormsUI.Docking;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class MainFrm
    {
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ShowOrHideDataBaseFrm()
        {
            if (DataBaseMenuItem.Checked)
                databasefrm.Show(this.MainDockPanel, DockState.DockLeft);
            else
                databasefrm.Hide();
        }

        private void DataBaseMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseMenuItem.Checked = !DataBaseMenuItem.Checked;
            ShowOrHideDataBaseFrm();
        }

        private void ShowOrHideProjectFrm()
        {
            if (!projectfrm.Visible)
                projectfrm.Show(this.MainDockPanel, DockState.DockRight);
            else if (projectfrm.Visible)
                projectfrm.Hide();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxFrm about = new AboutBoxFrm();
            about.ShowDialog();
        }

        private void 项目资源管理器PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrHideProjectFrm();
        }
    }
}