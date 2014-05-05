namespace ChinaBest.BaseApplication.CodeGeneration
{
    partial class TableDesignFrm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.propertyGridTable = new System.Windows.Forms.PropertyGrid();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnIsNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGridTable);
            this.splitContainer1.Size = new System.Drawing.Size(442, 467);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridTable
            // 
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDataType,
            this.ColumnIsNull});
            this.dataGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.RowTemplate.Height = 23;
            this.dataGridTable.Size = new System.Drawing.Size(442, 164);
            this.dataGridTable.TabIndex = 0;
            // 
            // propertyGridTable
            // 
            this.propertyGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridTable.Location = new System.Drawing.Point(0, 0);
            this.propertyGridTable.Name = "propertyGridTable";
            this.propertyGridTable.Size = new System.Drawing.Size(442, 299);
            this.propertyGridTable.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "列名";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnDataType
            // 
            this.ColumnDataType.HeaderText = "数据类型";
            this.ColumnDataType.Items.AddRange(new object[] {
            "bigint",
            "binary(50)",
            "bit",
            "char(10)",
            "datetime",
            "decimal(18,0)",
            "float",
            "image",
            "int",
            "money",
            "nchar(10)",
            "ntext",
            "numeric(18,0)",
            "nvarchar(50)",
            "nvarchar(MAX)",
            "real",
            "smalldatetime",
            "smallint",
            "smallmoney",
            "text",
            "timestamp",
            "tinyint",
            "uniqueidentifier",
            "varbinary(50)",
            "varbinary(MAX)",
            "varchar(50)",
            "varchar(MAX)",
            "xml",
            "sql_variant"});
            this.ColumnDataType.Name = "ColumnDataType";
            // 
            // ColumnIsNull
            // 
            this.ColumnIsNull.HeaderText = "允许空";
            this.ColumnIsNull.Name = "ColumnIsNull";
            // 
            // TableDesignFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 467);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TableDesignFrm";
            this.Text = "TableDesignFrm";
            this.Load += new System.EventHandler(this.TableDesignFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.PropertyGrid propertyGridTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnDataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsNull;

    }
}