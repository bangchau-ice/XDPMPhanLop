namespace GUI
{
    partial class AddJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTencv = new System.Windows.Forms.Label();
            this.lbNgbd = new System.Windows.Forms.Label();
            this.lbNgkt = new System.Windows.Forms.Label();
            this.lbNglamchung = new System.Windows.Forms.Label();
            this.lbTepdk = new System.Windows.Forms.Label();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.dtNgbd = new System.Windows.Forms.DateTimePicker();
            this.dtNgkt = new System.Windows.Forms.DateTimePicker();
            this.cbNglc = new System.Windows.Forms.ComboBox();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.txtDinhkem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPhamvi = new System.Windows.Forms.Label();
            this.cbPhamvi = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.todoList_DBDataSet = new GUI.TodoList_DBDataSet();
            this.dBJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBJobTableAdapter = new GUI.TodoList_DBDataSetTableAdapters.DBJobTableAdapter();
            this.todoList_DBDataSet1 = new GUI.TodoList_DBDataSet1();
            this.dBUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUserTableAdapter = new GUI.TodoList_DBDataSet1TableAdapters.DBUserTableAdapter();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobstardayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobenddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobpartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobcircleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobattachmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM CÔNG VIỆC";
            // 
            // lbTencv
            // 
            this.lbTencv.AutoSize = true;
            this.lbTencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTencv.Location = new System.Drawing.Point(139, 119);
            this.lbTencv.Name = "lbTencv";
            this.lbTencv.Size = new System.Drawing.Size(124, 20);
            this.lbTencv.TabIndex = 1;
            this.lbTencv.Text = "Tên công việc:";
            // 
            // lbNgbd
            // 
            this.lbNgbd.AutoSize = true;
            this.lbNgbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgbd.Location = new System.Drawing.Point(139, 171);
            this.lbNgbd.Name = "lbNgbd";
            this.lbNgbd.Size = new System.Drawing.Size(120, 20);
            this.lbNgbd.TabIndex = 2;
            this.lbNgbd.Text = "Ngày bắt đầu:";
            // 
            // lbNgkt
            // 
            this.lbNgkt.AutoSize = true;
            this.lbNgkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgkt.Location = new System.Drawing.Point(139, 223);
            this.lbNgkt.Name = "lbNgkt";
            this.lbNgkt.Size = new System.Drawing.Size(129, 20);
            this.lbNgkt.TabIndex = 3;
            this.lbNgkt.Text = "Ngày kết thúc: ";
            // 
            // lbNglamchung
            // 
            this.lbNglamchung.AutoSize = true;
            this.lbNglamchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNglamchung.Location = new System.Drawing.Point(466, 119);
            this.lbNglamchung.Name = "lbNglamchung";
            this.lbNglamchung.Size = new System.Drawing.Size(147, 20);
            this.lbNglamchung.TabIndex = 4;
            this.lbNglamchung.Text = "Người làm chung:";
            // 
            // lbTepdk
            // 
            this.lbTepdk.AutoSize = true;
            this.lbTepdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTepdk.Location = new System.Drawing.Point(466, 222);
            this.lbTepdk.Name = "lbTepdk";
            this.lbTepdk.Size = new System.Drawing.Size(121, 20);
            this.lbTepdk.TabIndex = 5;
            this.lbTepdk.Text = "Tệp đính kèm:";
            // 
            // txtTencv
            // 
            this.txtTencv.Location = new System.Drawing.Point(264, 121);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(184, 20);
            this.txtTencv.TabIndex = 6;
            // 
            // dtNgbd
            // 
            this.dtNgbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgbd.Location = new System.Drawing.Point(265, 171);
            this.dtNgbd.Name = "dtNgbd";
            this.dtNgbd.Size = new System.Drawing.Size(99, 20);
            this.dtNgbd.TabIndex = 7;
            this.dtNgbd.Value = new System.DateTime(2020, 9, 26, 0, 0, 0, 0);
            // 
            // dtNgkt
            // 
            this.dtNgkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgkt.Location = new System.Drawing.Point(265, 222);
            this.dtNgkt.Name = "dtNgkt";
            this.dtNgkt.Size = new System.Drawing.Size(99, 20);
            this.dtNgkt.TabIndex = 8;
            // 
            // cbNglc
            // 
            this.cbNglc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dBUserBindingSource, "user_id", true));
            this.cbNglc.DataSource = this.dBUserBindingSource;
            this.cbNglc.DisplayMember = "user_name";
            this.cbNglc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNglc.FormattingEnabled = true;
            this.cbNglc.Location = new System.Drawing.Point(619, 121);
            this.cbNglc.Name = "cbNglc";
            this.cbNglc.Size = new System.Drawing.Size(161, 21);
            this.cbNglc.TabIndex = 9;
            this.cbNglc.ValueMember = "user_id";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(620, 222);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(93, 20);
            this.txtfile.TabIndex = 10;
            // 
            // txtDinhkem
            // 
            this.txtDinhkem.Location = new System.Drawing.Point(719, 223);
            this.txtDinhkem.Name = "txtDinhkem";
            this.txtDinhkem.Size = new System.Drawing.Size(61, 24);
            this.txtDinhkem.TabIndex = 11;
            this.txtDinhkem.Text = "Mở File";
            this.txtDinhkem.UseVisualStyleBackColor = true;
            this.txtDinhkem.Click += new System.EventHandler(this.txtDinhkem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPhamvi
            // 
            this.lbPhamvi.AutoSize = true;
            this.lbPhamvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhamvi.Location = new System.Drawing.Point(466, 171);
            this.lbPhamvi.Name = "lbPhamvi";
            this.lbPhamvi.Size = new System.Drawing.Size(76, 20);
            this.lbPhamvi.TabIndex = 13;
            this.lbPhamvi.Text = "Phạm vi:";
            this.lbPhamvi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbPhamvi
            // 
            this.cbPhamvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhamvi.FormattingEnabled = true;
            this.cbPhamvi.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbPhamvi.Location = new System.Drawing.Point(620, 173);
            this.cbPhamvi.Name = "cbPhamvi";
            this.cbPhamvi.Size = new System.Drawing.Size(160, 21);
            this.cbPhamvi.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.jobstardayDataGridViewTextBoxColumn,
            this.jobenddayDataGridViewTextBoxColumn,
            this.jobpartnerDataGridViewTextBoxColumn,
            this.jobcircleDataGridViewTextBoxColumn,
            this.jobattachmentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dBJobBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // todoList_DBDataSet
            // 
            this.todoList_DBDataSet.DataSetName = "TodoList_DBDataSet";
            this.todoList_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBJobBindingSource
            // 
            this.dBJobBindingSource.DataMember = "DBJob";
            this.dBJobBindingSource.DataSource = this.todoList_DBDataSet;
            // 
            // dBJobTableAdapter
            // 
            this.dBJobTableAdapter.ClearBeforeFill = true;
            // 
            // todoList_DBDataSet1
            // 
            this.todoList_DBDataSet1.DataSetName = "TodoList_DBDataSet1";
            this.todoList_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBUserBindingSource
            // 
            this.dBUserBindingSource.DataMember = "DBUser";
            this.dBUserBindingSource.DataSource = this.todoList_DBDataSet1;
            // 
            // dBUserTableAdapter
            // 
            this.dBUserTableAdapter.ClearBeforeFill = true;
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Tên công việc";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // jobstardayDataGridViewTextBoxColumn
            // 
            this.jobstardayDataGridViewTextBoxColumn.DataPropertyName = "job_starday";
            this.jobstardayDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.jobstardayDataGridViewTextBoxColumn.Name = "jobstardayDataGridViewTextBoxColumn";
            // 
            // jobenddayDataGridViewTextBoxColumn
            // 
            this.jobenddayDataGridViewTextBoxColumn.DataPropertyName = "job_endday";
            this.jobenddayDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.jobenddayDataGridViewTextBoxColumn.Name = "jobenddayDataGridViewTextBoxColumn";
            // 
            // jobpartnerDataGridViewTextBoxColumn
            // 
            this.jobpartnerDataGridViewTextBoxColumn.DataPropertyName = "job_partner";
            this.jobpartnerDataGridViewTextBoxColumn.HeaderText = "Người làm chung";
            this.jobpartnerDataGridViewTextBoxColumn.Name = "jobpartnerDataGridViewTextBoxColumn";
            // 
            // jobcircleDataGridViewTextBoxColumn
            // 
            this.jobcircleDataGridViewTextBoxColumn.DataPropertyName = "job_circle";
            this.jobcircleDataGridViewTextBoxColumn.HeaderText = "Phạm vi";
            this.jobcircleDataGridViewTextBoxColumn.Name = "jobcircleDataGridViewTextBoxColumn";
            // 
            // jobattachmentsDataGridViewTextBoxColumn
            // 
            this.jobattachmentsDataGridViewTextBoxColumn.DataPropertyName = "job_attachments";
            this.jobattachmentsDataGridViewTextBoxColumn.HeaderText = "Tệp đính kèm";
            this.jobattachmentsDataGridViewTextBoxColumn.Name = "jobattachmentsDataGridViewTextBoxColumn";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbPhamvi);
            this.Controls.Add(this.lbPhamvi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDinhkem);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.cbNglc);
            this.Controls.Add(this.dtNgkt);
            this.Controls.Add(this.dtNgbd);
            this.Controls.Add(this.txtTencv);
            this.Controls.Add(this.lbTepdk);
            this.Controls.Add(this.lbNglamchung);
            this.Controls.Add(this.lbNgkt);
            this.Controls.Add(this.lbNgbd);
            this.Controls.Add(this.lbTencv);
            this.Controls.Add(this.label1);
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTencv;
        private System.Windows.Forms.Label lbNgbd;
        private System.Windows.Forms.Label lbNgkt;
        private System.Windows.Forms.Label lbNglamchung;
        private System.Windows.Forms.Label lbTepdk;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.DateTimePicker dtNgbd;
        private System.Windows.Forms.DateTimePicker dtNgkt;
        private System.Windows.Forms.ComboBox cbNglc;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Button txtDinhkem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPhamvi;
        private System.Windows.Forms.ComboBox cbPhamvi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TodoList_DBDataSet todoList_DBDataSet;
        private System.Windows.Forms.BindingSource dBJobBindingSource;
        private TodoList_DBDataSetTableAdapters.DBJobTableAdapter dBJobTableAdapter;
        private TodoList_DBDataSet1 todoList_DBDataSet1;
        private System.Windows.Forms.BindingSource dBUserBindingSource;
        private TodoList_DBDataSet1TableAdapters.DBUserTableAdapter dBUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobstardayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobenddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobpartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobcircleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobattachmentsDataGridViewTextBoxColumn;
    }
}