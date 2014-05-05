namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class TableEditorFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
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
            this.ColumnName.HeaderText = "列名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 120;
            // 
            // ColumnDataType
            // 
            this.ColumnDataType.HeaderText = "数据类型";
            this.ColumnDataType.Name = "ColumnDataType";
            this.ColumnDataType.Width = 150;
            // 
            // ColumnLength
            // 
            this.ColumnLength.HeaderText = "长度";
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLength.Width = 80;
            // 
            // ColumnPrecision
            // 
            this.ColumnPrecision.HeaderText = "精度";
            this.ColumnPrecision.Name = "ColumnPrecision";
            this.ColumnPrecision.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrecision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPrecision.Width = 80;
            // 
            // ColumnDefault
            // 
            this.ColumnDefault.HeaderText = "默认值";
            this.ColumnDefault.Name = "ColumnDefault";
            // 
            // ColumnIsNull
            // 
            this.ColumnIsNull.HeaderText = "是否为空";
            this.ColumnIsNull.Name = "ColumnIsNull";
            this.ColumnIsNull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsNull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnIsUnique
            // 
            this.ColumnIsUnique.HeaderText = "是否唯一";
            this.ColumnIsUnique.Name = "ColumnIsUnique";
            // 
            // ColumnMemo
            // 
            this.ColumnMemo.HeaderText = "备注";
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
            this.TabText = "表格编辑器";
            this.Text = "表格编辑器";
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
