namespace GUI
{
    partial class UserJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.todoList_DBDataSet2 = new GUI.TodoList_DBDataSet2();
            this.dBJobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBJobTableAdapter = new GUI.TodoList_DBDataSet2TableAdapters.DBJobTableAdapter();
            this.dBJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.dBJobBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(301, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(377, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // todoList_DBDataSet2
            // 
            this.todoList_DBDataSet2.DataSetName = "TodoList_DBDataSet2";
            this.todoList_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBJobBindingSource1
            // 
            this.dBJobBindingSource1.DataMember = "DBJob";
            this.dBJobBindingSource1.DataSource = this.todoList_DBDataSet2;
            // 
            // dBJobTableAdapter
            // 
            this.dBJobTableAdapter.ClearBeforeFill = true;
            // 
            // dBJobBindingSource
            // 
            this.dBJobBindingSource.DataMember = "DBJob";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "job_title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên công việc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "job_starday";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày bắt đầu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "job_endday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày kết thúc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // UserJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserJob";
            this.Text = "UserJob";
            this.Load += new System.EventHandler(this.UserJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobstardayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobenddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dBJobBindingSource;
        private TodoList_DBDataSet2 todoList_DBDataSet2;
        private System.Windows.Forms.BindingSource dBJobBindingSource1;
        private TodoList_DBDataSet2TableAdapters.DBJobTableAdapter dBJobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private TodoList_DBDataSet2 todoList_DBDataSet2;
    }
}