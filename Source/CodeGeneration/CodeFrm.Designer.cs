namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class CodeFrm
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.texteditorcontrol = new LTP.TextEditor.TextEditorControl();
            this.SuspendLayout();
            //
            // texteditorcontrol
            //
            this.texteditorcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texteditorcontrol.Location = new System.Drawing.Point(0, 0);
            this.texteditorcontrol.Name = "txtContent";
            this.texteditorcontrol.Size = new System.Drawing.Size(0x170, 0x178);
            this.texteditorcontrol.TabIndex = 0;
            this.texteditorcontrol.Text = "";
            this.texteditorcontrol.IsIconBarVisible = false;
            this.texteditorcontrol.ShowInvalidLines = false;
            this.texteditorcontrol.ShowSpaces = false;
            this.texteditorcontrol.ShowTabs = false;
            this.texteditorcontrol.ShowEOLMarkers = false;
            this.texteditorcontrol.ShowVRuler = false;
            this.texteditorcontrol.Language = LTP.TextEditor.TextEditorControlBase.Languages.CSHARP;
            this.texteditorcontrol.Encoding = System.Text.Encoding.Default;
            this.texteditorcontrol.Font = new System.Drawing.Font("������", 9f);
            // 
            // CodeFrm
            // 
            this.AllowEndUserDocking = false;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.texteditorcontrol);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Name = "CodeFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private LTP.TextEditor.TextEditorControl texteditorcontrol;
    }
}
