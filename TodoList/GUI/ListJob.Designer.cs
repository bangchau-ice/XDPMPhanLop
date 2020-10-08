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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lbtim = new System.Windows.Forms.Label();
            this.lblocngay = new System.Windows.Forms.Label();
            this.lbngbd = new System.Windows.Forms.Label();
            this.lbngkt = new System.Windows.Forms.Label();
            this.dtngbd = new System.Windows.Forms.DateTimePicker();
            this.dtngkt = new System.Windows.Forms.DateTimePicker();
            this.lblocnv = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.btloc = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.job_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_starday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_endday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_circle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_attachments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmt_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.job_id,
            this.job_title,
            this.job_starday,
            this.job_endday,
            this.job_partner,
            this.job_circle,
            this.job_attachments,
            this.cmt_content,
            this.user_name,
            this.Xóa});
            this.dataGridView1.Location = new System.Drawing.Point(-410, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1553, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(17, 244);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(242, 51);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm công việc";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(464, 161);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 36);
            this.bttim.TabIndex = 2;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(302, 163);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(134, 26);
            this.txttim.TabIndex = 3;
            // 
            // lbtim
            // 
            this.lbtim.AutoSize = true;
            this.lbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtim.Location = new System.Drawing.Point(12, 162);
            this.lbtim.Name = "lbtim";
            this.lbtim.Size = new System.Drawing.Size(283, 29);
            this.lbtim.TabIndex = 4;
            this.lbtim.Text = "Tìm theo mã công việc:";
            this.lbtim.Click += new System.EventHandler(this.lbtim_Click);
            // 
            // lblocngay
            // 
            this.lblocngay.AutoSize = true;
            this.lblocngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocngay.Location = new System.Drawing.Point(583, 128);
            this.lblocngay.Name = "lblocngay";
            this.lblocngay.Size = new System.Drawing.Size(175, 29);
            this.lblocngay.TabIndex = 5;
            this.lblocngay.Text = "Lọc theo ngày";
            this.lblocngay.Click += new System.EventHandler(this.lblocngay_Click);
            // 
            // lbngbd
            // 
            this.lbngbd.AutoSize = true;
            this.lbngbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngbd.Location = new System.Drawing.Point(587, 177);
            this.lbngbd.Name = "lbngbd";
            this.lbngbd.Size = new System.Drawing.Size(173, 29);
            this.lbngbd.TabIndex = 6;
            this.lbngbd.Text = "Ngày bắt đầu:";
            // 
            // lbngkt
            // 
            this.lbngkt.AutoSize = true;
            this.lbngkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngkt.Location = new System.Drawing.Point(583, 226);
            this.lbngkt.Name = "lbngkt";
            this.lbngkt.Size = new System.Drawing.Size(177, 29);
            this.lbngkt.TabIndex = 7;
            this.lbngkt.Text = "Ngày kết thúc:";
            // 
            // dtngbd
            // 
            this.dtngbd.Location = new System.Drawing.Point(871, 165);
            this.dtngbd.Name = "dtngbd";
            this.dtngbd.Size = new System.Drawing.Size(200, 26);
            this.dtngbd.TabIndex = 8;
            // 
            // dtngkt
            // 
            this.dtngkt.Location = new System.Drawing.Point(871, 216);
            this.dtngkt.Name = "dtngkt";
            this.dtngkt.Size = new System.Drawing.Size(200, 26);
            this.dtngkt.TabIndex = 9;
            // 
            // lblocnv
            // 
            this.lblocnv.AutoSize = true;
            this.lblocnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocnv.Location = new System.Drawing.Point(583, 269);
            this.lblocnv.Name = "lblocnv";
            this.lblocnv.Size = new System.Drawing.Size(280, 29);
            this.lblocnv.TabIndex = 10;
            this.lblocnv.Text = "Lọc theo mã nhân viên:";
            this.lblocnv.Click += new System.EventHandler(this.lblocnv_Click);
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(871, 269);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(200, 26);
            this.txtmanv.TabIndex = 11;
            // 
            // btloc
            // 
            this.btloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btloc.Location = new System.Drawing.Point(1111, 117);
            this.btloc.Name = "btloc";
            this.btloc.Size = new System.Drawing.Size(75, 40);
            this.btloc.TabIndex = 12;
            this.btloc.Text = "Lọc";
            this.btloc.UseVisualStyleBackColor = true;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(290, 27);
            this.lbtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(600, 69);
            this.lbtitle.TabIndex = 13;
            this.lbtitle.Text = "Danh sách công việc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xóa công việc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "Đánh dấu hoàn thành";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 54);
            this.button3.TabIndex = 16;
            this.button3.Text = "Thêm người làm chung";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(903, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "Sửa công việc";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // job_id
            // 
            this.job_id.DataPropertyName = "job_id";
            this.job_id.HeaderText = "Mã công việc";
            this.job_id.MinimumWidth = 8;
            this.job_id.Name = "job_id";
            this.job_id.Width = 150;
            // 
            // job_title
            // 
            this.job_title.DataPropertyName = "job_title";
            this.job_title.HeaderText = "Tiêu đề công việc";
            this.job_title.MinimumWidth = 8;
            this.job_title.Name = "job_title";
            this.job_title.Width = 150;
            // 
            // job_starday
            // 
            this.job_starday.DataPropertyName = "job_starday";
            this.job_starday.HeaderText = "Ngày bắt đầu";
            this.job_starday.MinimumWidth = 8;
            this.job_starday.Name = "job_starday";
            this.job_starday.Width = 150;
            // 
            // job_endday
            // 
            this.job_endday.DataPropertyName = "job_endday";
            this.job_endday.HeaderText = "Ngày kết thúc";
            this.job_endday.MinimumWidth = 8;
            this.job_endday.Name = "job_endday";
            this.job_endday.Width = 150;
            // 
            // job_partner
            // 
            this.job_partner.DataPropertyName = "job_partner";
            this.job_partner.HeaderText = "Người làm chung";
            this.job_partner.MinimumWidth = 8;
            this.job_partner.Name = "job_partner";
            this.job_partner.Width = 150;
            // 
            // job_circle
            // 
            this.job_circle.DataPropertyName = "job_circle";
            this.job_circle.HeaderText = "Người làm chung";
            this.job_circle.MinimumWidth = 8;
            this.job_circle.Name = "job_circle";
            this.job_circle.Width = 150;
            // 
            // job_attachments
            // 
            this.job_attachments.DataPropertyName = "job_attachments";
            this.job_attachments.HeaderText = "Tệp đính kèm";
            this.job_attachments.MinimumWidth = 8;
            this.job_attachments.Name = "job_attachments";
            this.job_attachments.Width = 150;
            // 
            // cmt_content
            // 
            this.cmt_content.DataPropertyName = "cmt_content";
            this.cmt_content.HeaderText = "Nội dung bình luận";
            this.cmt_content.MinimumWidth = 8;
            this.cmt_content.Name = "cmt_content";
            this.cmt_content.Width = 150;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Tên nhân viên";
            this.user_name.MinimumWidth = 8;
            this.user_name.Name = "user_name";
            this.user_name.Width = 150;
            // 
            // Xóa
            // 
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.MinimumWidth = 8;
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Width = 60;
            // 
            // ListJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 692);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.btloc);
            this.Controls.Add(this.txtmanv);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListJob";
            this.Text = "ListJob";
            this.Load += new System.EventHandler(this.ListJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblocnv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button btloc;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_starday;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_endday;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_circle;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_attachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmt_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}