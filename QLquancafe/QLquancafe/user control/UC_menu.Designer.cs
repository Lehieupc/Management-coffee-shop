namespace QLquancafe
{
    partial class UC_menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgv_menu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_dongia_mon = new System.Windows.Forms.TextBox();
            this.tb_ma_mon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ten_mon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_danh_muc = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_them_mon = new System.Windows.Forms.Button();
            this.bt_sua_mon = new System.Windows.Forms.Button();
            this.bt_xoa_mon = new System.Windows.Forms.Button();
            this.bt_xem_mon = new System.Windows.Forms.Button();
            this.bt_timkiem_mon = new System.Windows.Forms.Button();
            this.tb_timkiem_mon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_menu)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgv_menu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(766, 395);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 7;
            // 
            // dtgv_menu
            // 
            this.dtgv_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_menu.Location = new System.Drawing.Point(0, 0);
            this.dtgv_menu.Name = "dtgv_menu";
            this.dtgv_menu.RowHeadersWidth = 51;
            this.dtgv_menu.RowTemplate.Height = 24;
            this.dtgv_menu.Size = new System.Drawing.Size(392, 395);
            this.dtgv_menu.TabIndex = 0;
            this.dtgv_menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_menu_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_dongia_mon, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_ma_mon, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_ten_mon, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbb_danh_muc, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 201);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 50);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã món";
            // 
            // tb_dongia_mon
            // 
            this.tb_dongia_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_dongia_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_dongia_mon.Location = new System.Drawing.Point(188, 103);
            this.tb_dongia_mon.Name = "tb_dongia_mon";
            this.tb_dongia_mon.Size = new System.Drawing.Size(179, 26);
            this.tb_dongia_mon.TabIndex = 5;
            // 
            // tb_ma_mon
            // 
            this.tb_ma_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ma_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ma_mon.Location = new System.Drawing.Point(188, 3);
            this.tb_ma_mon.Name = "tb_ma_mon";
            this.tb_ma_mon.Size = new System.Drawing.Size(179, 26);
            this.tb_ma_mon.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(3, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 50);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn giá";
            // 
            // tb_ten_mon
            // 
            this.tb_ten_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ten_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ten_mon.Location = new System.Drawing.Point(188, 53);
            this.tb_ten_mon.Name = "tb_ten_mon";
            this.tb_ten_mon.Size = new System.Drawing.Size(179, 26);
            this.tb_ten_mon.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(3, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 50);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục";
            // 
            // cbb_danh_muc
            // 
            this.cbb_danh_muc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_danh_muc.FormattingEnabled = true;
            this.cbb_danh_muc.Location = new System.Drawing.Point(188, 153);
            this.cbb_danh_muc.Name = "cbb_danh_muc";
            this.cbb_danh_muc.Size = new System.Drawing.Size(179, 24);
            this.cbb_danh_muc.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.bt_them_mon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_sua_mon, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_xoa_mon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_xem_mon, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_timkiem_mon, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_timkiem_mon, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 62);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // bt_them_mon
            // 
            this.bt_them_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_them_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_them_mon.Location = new System.Drawing.Point(3, 3);
            this.bt_them_mon.Name = "bt_them_mon";
            this.bt_them_mon.Size = new System.Drawing.Size(85, 56);
            this.bt_them_mon.TabIndex = 0;
            this.bt_them_mon.Text = "Thêm";
            this.bt_them_mon.UseVisualStyleBackColor = true;
            this.bt_them_mon.Click += new System.EventHandler(this.bt_them_mon_Click);
            // 
            // bt_sua_mon
            // 
            this.bt_sua_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_sua_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_sua_mon.Location = new System.Drawing.Point(94, 3);
            this.bt_sua_mon.Name = "bt_sua_mon";
            this.bt_sua_mon.Size = new System.Drawing.Size(85, 56);
            this.bt_sua_mon.TabIndex = 1;
            this.bt_sua_mon.Text = "Sửa";
            this.bt_sua_mon.UseVisualStyleBackColor = true;
            this.bt_sua_mon.Click += new System.EventHandler(this.bt_sua_mon_Click);
            // 
            // bt_xoa_mon
            // 
            this.bt_xoa_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_xoa_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_xoa_mon.Location = new System.Drawing.Point(185, 3);
            this.bt_xoa_mon.Name = "bt_xoa_mon";
            this.bt_xoa_mon.Size = new System.Drawing.Size(85, 56);
            this.bt_xoa_mon.TabIndex = 2;
            this.bt_xoa_mon.Text = "Xóa";
            this.bt_xoa_mon.UseVisualStyleBackColor = true;
            this.bt_xoa_mon.Click += new System.EventHandler(this.bt_xoa_mon_Click);
            // 
            // bt_xem_mon
            // 
            this.bt_xem_mon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_xem_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_xem_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_xem_mon.Location = new System.Drawing.Point(276, 3);
            this.bt_xem_mon.Name = "bt_xem_mon";
            this.bt_xem_mon.Size = new System.Drawing.Size(85, 56);
            this.bt_xem_mon.TabIndex = 3;
            this.bt_xem_mon.Text = "Xem";
            this.bt_xem_mon.UseVisualStyleBackColor = true;
            // 
            // bt_timkiem_mon
            // 
            this.bt_timkiem_mon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_timkiem_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_timkiem_mon.Location = new System.Drawing.Point(673, 3);
            this.bt_timkiem_mon.Name = "bt_timkiem_mon";
            this.bt_timkiem_mon.Size = new System.Drawing.Size(90, 56);
            this.bt_timkiem_mon.TabIndex = 4;
            this.bt_timkiem_mon.Text = "Tìm kiếm";
            this.bt_timkiem_mon.UseVisualStyleBackColor = true;
            this.bt_timkiem_mon.Click += new System.EventHandler(this.bt_timkiem_mon_Click);
            // 
            // tb_timkiem_mon
            // 
            this.tb_timkiem_mon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_timkiem_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_timkiem_mon.Location = new System.Drawing.Point(367, 33);
            this.tb_timkiem_mon.Name = "tb_timkiem_mon";
            this.tb_timkiem_mon.Size = new System.Drawing.Size(300, 26);
            this.tb_timkiem_mon.TabIndex = 5;
            // 
            // UC_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UC_menu";
            this.Size = new System.Drawing.Size(766, 457);
            this.Load += new System.EventHandler(this.UC_menu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_menu)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgv_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_dongia_mon;
        private System.Windows.Forms.TextBox tb_ma_mon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ten_mon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_them_mon;
        private System.Windows.Forms.Button bt_sua_mon;
        private System.Windows.Forms.Button bt_xoa_mon;
        private System.Windows.Forms.Button bt_xem_mon;
        private System.Windows.Forms.Button bt_timkiem_mon;
        private System.Windows.Forms.TextBox tb_timkiem_mon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_danh_muc;
    }
}
