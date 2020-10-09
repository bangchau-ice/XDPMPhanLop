namespace GUI
{
    partial class ListJob
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
            this.btthem = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lbtim = new System.Windows.Forms.Label();
            this.lblocngay = new System.Windows.Forms.Label();
            this.lbngbd = new System.Windows.Forms.Label();
            this.lbngkt = new System.Windows.Forms.Label();
            this.dtngbd = new System.Windows.Forms.DateTimePicker();
            this.dtngkt = new System.Windows.Forms.DateTimePicker();
            this.btloc = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.todoList_DBDataSet3 = new GUI.TodoList_DBDataSet3();
            this.todoListDBDataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoListDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTnd = new System.Windows.Forms.TextBox();
            this.btrf = new System.Windows.Forms.Button();
            this.lblocnv = new System.Windows.Forms.Label();
            this.cbbmnv = new System.Windows.Forms.ComboBox();
            this.todoList_DBDataSet6 = new GUI.TodoList_DBDataSet6();
            this.dBUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUserTableAdapter = new GUI.TodoList_DBDataSet6TableAdapters.DBUserTableAdapter();
            this.dBUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(11, 159);
            this.btthem.Margin = new System.Windows.Forms.Padding(2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(161, 33);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm công việc";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(309, 105);
            this.bttim.Margin = new System.Windows.Forms.Padding(2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(50, 23);
            this.bttim.TabIndex = 2;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(201, 106);
            this.txttim.Margin = new System.Windows.Forms.Padding(2);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(91, 20);
            this.txttim.TabIndex = 3;
            // 
            // lbtim
            // 
            this.lbtim.AutoSize = true;
            this.lbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtim.Location = new System.Drawing.Point(8, 105);
            this.lbtim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtim.Name = "lbtim";
            this.lbtim.Size = new System.Drawing.Size(192, 20);
            this.lbtim.TabIndex = 4;
            this.lbtim.Text = "Tìm theo mã công việc:";
            this.lbtim.Click += new System.EventHandler(this.lbtim_Click);
            // 
            // lblocngay
            // 
            this.lblocngay.AutoSize = true;
            this.lblocngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocngay.Location = new System.Drawing.Point(389, 83);
            this.lblocngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblocngay.Name = "lblocngay";
            this.lblocngay.Size = new System.Drawing.Size(122, 20);
            this.lblocngay.TabIndex = 5;
            this.lblocngay.Text = "Lọc theo ngày";
            this.lblocngay.Click += new System.EventHandler(this.lblocngay_Click);
            // 
            // lbngbd
            // 
            this.lbngbd.AutoSize = true;
            this.lbngbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngbd.Location = new System.Drawing.Point(391, 115);
            this.lbngbd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngbd.Name = "lbngbd";
            this.lbngbd.Size = new System.Drawing.Size(120, 20);
            this.lbngbd.TabIndex = 6;
            this.lbngbd.Text = "Ngày bắt đầu:";
            // 
            // lbngkt
            // 
            this.lbngkt.AutoSize = true;
            this.lbngkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngkt.Location = new System.Drawing.Point(389, 147);
            this.lbngkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbngkt.Name = "lbngkt";
            this.lbngkt.Size = new System.Drawing.Size(124, 20);
            this.lbngkt.TabIndex = 7;
            this.lbngkt.Text = "Ngày kết thúc:";
            // 
            // dtngbd
            // 
            this.dtngbd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngbd.Location = new System.Drawing.Point(581, 107);
            this.dtngbd.Margin = new System.Windows.Forms.Padding(2);
            this.dtngbd.Name = "dtngbd";
            this.dtngbd.Size = new System.Drawing.Size(135, 20);
            this.dtngbd.TabIndex = 8;
            // 
            // dtngkt
            // 
            this.dtngkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngkt.Location = new System.Drawing.Point(581, 140);
            this.dtngkt.Margin = new System.Windows.Forms.Padding(2);
            this.dtngkt.Name = "dtngkt";
            this.dtngkt.Size = new System.Drawing.Size(135, 20);
            this.dtngkt.TabIndex = 9;
            // 
            // btloc
            // 
            this.btloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btloc.Location = new System.Drawing.Point(741, 76);
            this.btloc.Margin = new System.Windows.Forms.Padding(2);
            this.btloc.Name = "btloc";
            this.btloc.Size = new System.Drawing.Size(50, 26);
            this.btloc.TabIndex = 12;
            this.btloc.Text = "Lọc";
            this.btloc.UseVisualStyleBackColor = true;
            this.btloc.Click += new System.EventHandler(this.btloc_Click);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(193, 18);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(411, 46);
            this.lbtitle.TabIndex = 13;
            this.lbtitle.Text = "Danh sách công việc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btXoa,
            this.btSua});
            this.dataGridView1.Location = new System.Drawing.Point(314, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 100);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btXoa
            // 
            this.btXoa.DataPropertyName = "Xóa";
            this.btXoa.HeaderText = "Xóa";
            this.btXoa.Name = "btXoa";
            this.btXoa.Text = "Xóa";
            this.btXoa.UseColumnTextForButtonValue = true;
            // 
            // btSua
            // 
            this.btSua.DataPropertyName = "Sửa";
            this.btSua.HeaderText = "Sửa";
            this.btSua.Name = "btSua";
            this.btSua.Text = "Sửa";
            // 
            // todoList_DBDataSet3
            // 
            this.todoList_DBDataSet3.DataSetName = "TodoList_DBDataSet3";
            this.todoList_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoListDBDataSet31BindingSource
            // 
            this.todoListDBDataSet31BindingSource.DataSource = this.todoList_DBDataSet3;
            this.todoListDBDataSet31BindingSource.Position = 0;
            // 
            // txtTnd
            // 
            this.txtTnd.Location = new System.Drawing.Point(788, 15);
            this.txtTnd.Name = "txtTnd";
            this.txtTnd.Size = new System.Drawing.Size(134, 20);
            this.txtTnd.TabIndex = 19;
            // 
            // btrf
            // 
            this.btrf.Location = new System.Drawing.Point(12, 212);
            this.btrf.Name = "btrf";
            this.btrf.Size = new System.Drawing.Size(160, 29);
            this.btrf.TabIndex = 20;
            this.btrf.Text = "Refresh";
            this.btrf.UseVisualStyleBackColor = true;
            this.btrf.Click += new System.EventHandler(this.btrf_Click);
            // 
            // lblocnv
            // 
            this.lblocnv.AutoSize = true;
            this.lblocnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocnv.Location = new System.Drawing.Point(389, 175);
            this.lblocnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblocnv.Name = "lblocnv";
            this.lblocnv.Size = new System.Drawing.Size(195, 20);
            this.lblocnv.TabIndex = 10;
            this.lblocnv.Text = "Lọc theo mã nhân viên:";
            this.lblocnv.Click += new System.EventHandler(this.lblocnv_Click);
            // 
            // cbbmnv
            // 
            this.cbbmnv.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dBUserBindingSource2, "user_id", true));
            this.cbbmnv.DataSource = this.todoList_DBDataSet6;
            this.cbbmnv.DisplayMember = "DBUser.user_name";
            this.cbbmnv.FormattingEnabled = true;
            this.cbbmnv.Location = new System.Drawing.Point(590, 178);
            this.cbbmnv.Name = "cbbmnv";
            this.cbbmnv.Size = new System.Drawing.Size(125, 21);
            this.cbbmnv.TabIndex = 21;
            this.cbbmnv.ValueMember = "DBUser.user_id";
            // 
            // todoList_DBDataSet6
            // 
            this.todoList_DBDataSet6.DataSetName = "TodoList_DBDataSet6";
            this.todoList_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBUserBindingSource
            // 
            this.dBUserBindingSource.DataMember = "DBUser";
            this.dBUserBindingSource.DataSource = this.todoList_DBDataSet6;
            // 
            // dBUserTableAdapter
            // 
            this.dBUserTableAdapter.ClearBeforeFill = true;
            // 
            // dBUserBindingSource1
            // 
            this.dBUserBindingSource1.DataMember = "DBUser";
            this.dBUserBindingSource1.DataSource = this.todoList_DBDataSet6;
            // 
            // dBUserBindingSource2
            // 
            this.dBUserBindingSource2.DataMember = "DBUser";
            this.dBUserBindingSource2.DataSource = this.todoList_DBDataSet6;
            // 
            // ListJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.cbbmnv);
            this.Controls.Add(this.btrf);
            this.Controls.Add(this.txtTnd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.btloc);
            this.Controls.Add(this.lblocnv);
            this.Controls.Add(this.dtngkt);
            this.Controls.Add(this.dtngbd);
            this.Controls.Add(this.lbngkt);
            this.Controls.Add(this.lbngbd);
            this.Controls.Add(this.lblocngay);
            this.Controls.Add(this.lbtim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btthem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListJob";
            this.Text = "ListJob";
            this.Load += new System.EventHandler(this.ListJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label lbtim;
        private System.Windows.Forms.Label lblocngay;
        private System.Windows.Forms.Label lbngbd;
        private System.Windows.Forms.Label lbngkt;
        private System.Windows.Forms.DateTimePicker dtngbd;
        private System.Windows.Forms.DateTimePicker dtngkt;
        private System.Windows.Forms.Button btloc;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.BindingSource todoListDBDataSet3BindingSource;
        private TodoList_DBDataSet3 todoList_DBDataSet3;
        private System.Windows.Forms.BindingSource todoListDBDataSet31BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btXoa;
        private System.Windows.Forms.DataGridViewButtonColumn btSua;
        private System.Windows.Forms.TextBox txtTnd;
        private System.Windows.Forms.Button btrf;
        private System.Windows.Forms.Label lblocnv;
        private System.Windows.Forms.ComboBox cbbmnv;
        private TodoList_DBDataSet6 todoList_DBDataSet6;
        private System.Windows.Forms.BindingSource dBUserBindingSource;
        private TodoList_DBDataSet6TableAdapters.DBUserTableAdapter dBUserTableAdapter;
        private System.Windows.Forms.BindingSource dBUserBindingSource2;
        private System.Windows.Forms.BindingSource dBUserBindingSource1;
        //private TodoList_DBDataSet3 todoList_DBDataSet31;
    }
}