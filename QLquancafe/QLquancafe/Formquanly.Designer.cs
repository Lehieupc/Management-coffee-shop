namespace QLquancafe
{
    partial class Formquanly
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tk_nv = new System.Windows.Forms.TextBox();
            this.tb_mk_nv = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 263);
            this.dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày sinh";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SDT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tài khoản";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mật khẩu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.99447F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.32044F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.950276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0884F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_xoa, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_sua, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdb_nu, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_them, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdb_nam, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_hoten, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_ngaysinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_sdt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_diachi, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_email, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_tk_nv, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_mk_nv, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 152);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Họ tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_xoa.Location = new System.Drawing.Point(687, 69);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(215, 27);
            this.bt_xoa.TabIndex = 25;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_sua.Location = new System.Drawing.Point(687, 36);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(215, 27);
            this.bt_sua.TabIndex = 26;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb_nu.Location = new System.Drawing.Point(606, 69);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(75, 27);
            this.rdb_nu.TabIndex = 33;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_them
            // 
            this.bt_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_them.Location = new System.Drawing.Point(687, 3);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(215, 27);
            this.bt_them.TabIndex = 24;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Checked = true;
            this.rdb_nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdb_nam.Location = new System.Drawing.Point(606, 36);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(75, 27);
            this.rdb_nam.TabIndex = 32;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_hoten.Location = new System.Drawing.Point(99, 3);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(183, 22);
            this.tb_hoten.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(606, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(99, 36);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(183, 22);
            this.dtp_ngaysinh.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(288, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sdt.Location = new System.Drawing.Point(405, 3);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(195, 22);
            this.tb_sdt.TabIndex = 21;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_diachi.Location = new System.Drawing.Point(405, 36);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(195, 22);
            this.tb_diachi.TabIndex = 22;
            // 
            // tb_email
            // 
            this.tb_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_email.Location = new System.Drawing.Point(405, 69);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(195, 22);
            this.tb_email.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(288, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(288, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 53);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tài khoản";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(288, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 53);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mật khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_tk_nv
            // 
            this.tb_tk_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_tk_nv.Location = new System.Drawing.Point(99, 102);
            this.tb_tk_nv.Name = "tb_tk_nv";
            this.tb_tk_nv.Size = new System.Drawing.Size(183, 22);
            this.tb_tk_nv.TabIndex = 36;
            // 
            // tb_mk_nv
            // 
            this.tb_mk_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_mk_nv.Location = new System.Drawing.Point(405, 102);
            this.tb_mk_nv.Name = "tb_mk_nv";
            this.tb_mk_nv.Size = new System.Drawing.Size(195, 22);
            this.tb_mk_nv.TabIndex = 37;
            // 
            // Formquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formquanly";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tk_nv;
        private System.Windows.Forms.TextBox tb_mk_nv;
        private System.Windows.Forms.Button button1;
    }
}