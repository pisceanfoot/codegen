using ChinaBest.BaseApplication.CGCoreLib;

namespace ChinaBest.BaseApplication.CodeGeneration
{
    public partial class CodeFrm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public CodeFrm()
        {
            InitializeComponent();
        }

        public void SetCode(string file, CodeInfo code)
        {
            this.TabText = file;
            this.texteditorcontrol.Text = code.Code;
        }
    }
}