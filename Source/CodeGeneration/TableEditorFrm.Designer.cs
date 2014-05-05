namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class TableEditorFrm
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
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIsUnique = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDataType,
            this.ColumnLength,
            this.ColumnPrecision,
            this.ColumnDefault,
            this.ColumnIsNull,
            this.ColumnIsUnique,
            this.ColumnMemo});
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersWidth = 36;
            this.MainDataGridView.RowTemplate.Height = 23;
            this.MainDataGridView.Size = new System.Drawing.Size(792, 573);
            this.MainDataGridView.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "����";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 120;
            // 
            // ColumnDataType
            // 
            this.ColumnDataType.HeaderText = "��������";
            this.ColumnDataType.Name = "ColumnDataType";
            this.ColumnDataType.Width = 150;
            // 
            // ColumnLength
            // 
            this.ColumnLength.HeaderText = "����";
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLength.Width = 80;
            // 
            // ColumnPrecision
            // 
            this.ColumnPrecision.HeaderText = "����";
            this.ColumnPrecision.Name = "ColumnPrecision";
            this.ColumnPrecision.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrecision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPrecision.Width = 80;
            // 
            // ColumnDefault
            // 
            this.ColumnDefault.HeaderText = "Ĭ��ֵ";
            this.ColumnDefault.Name = "ColumnDefault";
            // 
            // ColumnIsNull
            // 
            this.ColumnIsNull.HeaderText = "�Ƿ�Ϊ��";
            this.ColumnIsNull.Name = "ColumnIsNull";
            this.ColumnIsNull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsNull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnIsUnique
            // 
            this.ColumnIsUnique.HeaderText = "�Ƿ�Ψһ";
            this.ColumnIsUnique.Name = "ColumnIsUnique";
            // 
            // ColumnMemo
            // 
            this.ColumnMemo.HeaderText = "��ע";
            this.ColumnMemo.Name = "ColumnMemo";
            this.ColumnMemo.Width = 200;
            // 
            // TableEditorFrm
            // 
            this.AllowEndUserDocking = false;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.MainDataGridView);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Name = "TableEditorFrm";
            this.TabText = "���༭��";
            this.Text = "���༭��";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDefault;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsUnique;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMemo;
    }
}
