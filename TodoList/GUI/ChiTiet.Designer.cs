namespace GUI
{
    partial class ChiTiet
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labe6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmcv = new System.Windows.Forms.TextBox();
            this.txttcv = new System.Windows.Forms.TextBox();
            this.txtnbd = new System.Windows.Forms.TextBox();
            this.txtnkt = new System.Windows.Forms.TextBox();
            this.txtpv = new System.Windows.Forms.TextBox();
            this.txtfdk = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.txtnlc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.todoList_DBDataSet4 = new GUI.TodoList_DBDataSet4();
            this.todoListDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(37, 30);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(75, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Mã công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên công việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phạm vi:";
            // 
            // labe6
            // 
            this.labe6.AutoSize = true;
            this.labe6.Location = new System.Drawing.Point(338, 183);
            this.labe6.Name = "labe6";
            this.labe6.Size = new System.Drawing.Size(75, 13);
            this.labe6.TabIndex = 10;
            this.labe6.Text = "File đính kèm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trạng thái:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Người làm chung:";
            // 
            // txtmcv
            // 
            this.txtmcv.Location = new System.Drawing.Point(118, 30);
            this.txtmcv.Name = "txtmcv";
            this.txtmcv.Size = new System.Drawing.Size(104, 20);
            this.txtmcv.TabIndex = 21;
            // 
            // txttcv
            // 
            this.txttcv.Location = new System.Drawing.Point(118, 74);
            this.txttcv.Name = "txttcv";
            this.txttcv.Size = new System.Drawing.Size(104, 20);
            this.txttcv.TabIndex = 22;
            // 
            // txtnbd
            // 
            this.txtnbd.Location = new System.Drawing.Point(118, 129);
            this.txtnbd.Name = "txtnbd";
            this.txtnbd.Size = new System.Drawing.Size(104, 20);
            this.txtnbd.TabIndex = 23;
            // 
            // txtnkt
            // 
            this.txtnkt.Location = new System.Drawing.Point(118, 180);
            this.txtnkt.Name = "txtnkt";
            this.txtnkt.Size = new System.Drawing.Size(104, 20);
            this.txtnkt.TabIndex = 24;
            // 
            // txtpv
            // 
            this.txtpv.Location = new System.Drawing.Point(447, 122);
            this.txtpv.Name = "txtpv";
            this.txtpv.Size = new System.Drawing.Size(104, 20);
            this.txtpv.TabIndex = 25;
            // 
            // txtfdk
            // 
            this.txtfdk.Location = new System.Drawing.Point(447, 183);
            this.txtfdk.Name = "txtfdk";
            this.txtfdk.Size = new System.Drawing.Size(104, 20);
            this.txtfdk.TabIndex = 26;
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(447, 30);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(104, 20);
            this.txttt.TabIndex = 27;
            // 
            // txtnlc
            // 
            this.txtnlc.Location = new System.Drawing.Point(447, 78);
            this.txtnlc.Name = "txtnlc";
            this.txtnlc.Size = new System.Drawing.Size(104, 20);
            this.txtnlc.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 108);
            this.dataGridView1.TabIndex = 34;
            // 
            // todoList_DBDataSet4
            // 
            this.todoList_DBDataSet4.DataSetName = "TodoList_DBDataSet4";
            this.todoList_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todoListDBDataSet4BindingSource
            // 
            this.todoListDBDataSet4BindingSource.DataSource = this.todoList_DBDataSet4;
            this.todoListDBDataSet4BindingSource.Position = 0;
            // 
            // ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnlc);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtfdk);
            this.Controls.Add(this.txtpv);
            this.Controls.Add(this.txtnkt);
            this.Controls.Add(this.txtnbd);
            this.Controls.Add(this.txttcv);
            this.Controls.Add(this.txtmcv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labe6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "ChiTiet";
            this.Text = "ChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoList_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDBDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lbmcv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtcv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbnbd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnkt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbpv;
        private System.Windows.Forms.Label labe6;
        private System.Windows.Forms.Label lbfdk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbtt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbnlc;
        private System.Windows.Forms.Label lbbl;
        private System.Windows.Forms.Label lbnbl;
        private System.Windows.Forms.Label lbngbl;
        private System.Windows.Forms.TextBox txtmcv;
        private System.Windows.Forms.TextBox txttcv;
        private System.Windows.Forms.TextBox txtnbd;
        private System.Windows.Forms.TextBox txtnkt;
        private System.Windows.Forms.TextBox txtpv;
        private System.Windows.Forms.TextBox txtfdk;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.TextBox txtnlc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TodoList_DBDataSet4 todoList_DBDataSet4;
        private System.Windows.Forms.BindingSource todoListDBDataSet4BindingSource;
    }
}