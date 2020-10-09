namespace GUI
{
    partial class formsua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttcv = new System.Windows.Forms.TextBox();
            this.dtngbd = new System.Windows.Forms.DateTimePicker();
            this.dtngkt = new System.Windows.Forms.DateTimePicker();
            this.cbbpv = new System.Windows.Forms.ComboBox();
            this.cbbtt = new System.Windows.Forms.ComboBox();
            this.cbbnglc = new System.Windows.Forms.ComboBox();
            this.txtfdk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmcv = new System.Windows.Forms.TextBox();
            this.todoList_DBDataSet5 = new GUI.TodoList_DBDataSet5();
            this.dBUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUserTableAdapter = new GUI.TodoList_DBDataSet5TableAdapters.DBUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phạm vi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Người làm chung:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "File đính kèm:";
            // 
            // txttcv
            // 
            this.txttcv.Location = new System.Drawing.Point(132, 68);
            this.txttcv.Name = "txttcv";
            this.txttcv.Size = new System.Drawing.Size(87, 20);
            this.txttcv.TabIndex = 7;
            // 
            // dtngbd
            // 
            this.dtngbd.Location = new System.Drawing.Point(132, 137);
            this.dtngbd.Name = "dtngbd";
            this.dtngbd.Size = new System.Drawing.Size(137, 20);
            this.dtngbd.TabIndex = 8;
            // 
            // dtngkt
            // 
            this.dtngkt.Location = new System.Drawing.Point(132, 222);
            this.dtngkt.Name = "dtngkt";
            this.dtngkt.Size = new System.Drawing.Size(137, 20);
            this.dtngkt.TabIndex = 9;
            // 
            // cbbpv
            // 
            this.cbbpv.FormattingEnabled = true;
            this.cbbpv.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbpv.Location = new System.Drawing.Point(430, 67);
            this.cbbpv.Name = "cbbpv";
            this.cbbpv.Size = new System.Drawing.Size(110, 21);
            this.cbbpv.TabIndex = 10;
            // 
            // cbbtt
            // 
            this.cbbtt.FormattingEnabled = true;
            this.cbbtt.Items.AddRange(new object[] {
            "Đang hoàn thành",
            "Đã hoàn thành",
            "Trể hẹn"});
            this.cbbtt.Location = new System.Drawing.Point(430, 144);
            this.cbbtt.Name = "cbbtt";
            this.cbbtt.Size = new System.Drawing.Size(110, 21);
            this.cbbtt.TabIndex = 11;
            // 
            // cbbnglc
            // 
            this.cbbnglc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dBUserBindingSource, "user_id", true));
            this.cbbnglc.DataSource = this.dBUserBindingSource;
            this.cbbnglc.DisplayMember = "user_name";
            this.cbbnglc.FormattingEnabled = true;
            this.cbbnglc.Location = new System.Drawing.Point(476, 220);
            this.cbbnglc.Name = "cbbnglc";
            this.cbbnglc.Size = new System.Drawing.Size(110, 21);
            this.cbbnglc.TabIndex = 12;
            this.cbbnglc.ValueMember = "user_id";
            // 
            // txtfdk
            // 
            this.txtfdk.Location = new System.Drawing.Point(476, 304);
            this.txtfdk.Name = "txtfdk";
            this.txtfdk.Size = new System.Drawing.Size(87, 20);
            this.txtfdk.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Mở file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(88, 275);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(173, 60);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "SỬA";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã công việc:";
            // 
            // txtmcv
            // 
            this.txtmcv.Location = new System.Drawing.Point(686, 67);
            this.txtmcv.Name = "txtmcv";
            this.txtmcv.Size = new System.Drawing.Size(87, 20);
            this.txtmcv.TabIndex = 17;
            // 
            // todoList_DBDataSet5
            // 
            this.todoList_DBDataSet5.DataSetName = "TodoList_DBDataSet5";
            this.todoList_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBUserBindingSource
            // 
            this.dBUserBindingSource.DataMember = "DBUser";
            this.dBUserBindingSource.DataSource = this.todoList_DBDataSet5;
            // 
            // dBUserTableAdapter
            // 
            this.dBUserTableAdapter.ClearBeforeFill = true;
            // 
            // formsua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmcv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfdk);
            this.Controls.Add(this.cbbnglc);
            this.Controls.Add(this.cbbtt);
            this.Controls.Add(this.cbbpv);
            this.Controls.Add(this.dtngkt);
            this.Controls.Add(this.dtngbd);
            this.Controls.Add(this.txttcv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formsua";
            this.Text = "SỬA";
            this.Load += new System.EventHandler(this.formsua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttcv;
        private System.Windows.Forms.DateTimePicker dtngbd;
        private System.Windows.Forms.DateTimePicker dtngkt;
        private System.Windows.Forms.ComboBox cbbpv;
        private System.Windows.Forms.ComboBox cbbtt;
        private System.Windows.Forms.ComboBox cbbnglc;
        private System.Windows.Forms.TextBox txtfdk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmcv;
        private TodoList_DBDataSet5 todoList_DBDataSet5;
        private System.Windows.Forms.BindingSource dBUserBindingSource;
        private TodoList_DBDataSet5TableAdapters.DBUserTableAdapter dBUserTableAdapter;
    }
}