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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_ql_menu = new System.Windows.Forms.Button();
            this.bt_ql_nv = new System.Windows.Forms.Button();
            this.bt_dm = new System.Windows.Forms.Button();
            this.bt_tk_dt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_dm1 = new QLquancafe.UC_dm();
            this.uC_thongke1 = new QLquancafe.UC_thongke();
            this.uC_menu1 = new QLquancafe.UC_menu();
            this.uC_nv1 = new QLquancafe.UC_nv();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 505);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.5F));
            this.tableLayoutPanel1.Controls.Add(this.bt_ql_menu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_ql_nv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_dm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_tk_dt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 272);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bt_ql_menu
            // 
            this.bt_ql_menu.BackColor = System.Drawing.Color.White;
            this.bt_ql_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ql_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ql_menu.Location = new System.Drawing.Point(60, 3);
            this.bt_ql_menu.Name = "bt_ql_menu";
            this.bt_ql_menu.Size = new System.Drawing.Size(137, 62);
            this.bt_ql_menu.TabIndex = 0;
            this.bt_ql_menu.Text = "Quản lý menu";
            this.bt_ql_menu.UseVisualStyleBackColor = false;
            this.bt_ql_menu.Click += new System.EventHandler(this.bt_ql_menu_Click);
            // 
            // bt_ql_nv
            // 
            this.bt_ql_nv.BackColor = System.Drawing.Color.White;
            this.bt_ql_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ql_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ql_nv.Location = new System.Drawing.Point(60, 71);
            this.bt_ql_nv.Name = "bt_ql_nv";
            this.bt_ql_nv.Size = new System.Drawing.Size(137, 62);
            this.bt_ql_nv.TabIndex = 1;
            this.bt_ql_nv.Text = "Quản lý nhân viên";
            this.bt_ql_nv.UseVisualStyleBackColor = false;
            this.bt_ql_nv.Click += new System.EventHandler(this.bt_ql_nv_Click);
            // 
            // bt_dm
            // 
            this.bt_dm.BackColor = System.Drawing.Color.White;
            this.bt_dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_dm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dm.Location = new System.Drawing.Point(60, 139);
            this.bt_dm.Name = "bt_dm";
            this.bt_dm.Size = new System.Drawing.Size(137, 62);
            this.bt_dm.TabIndex = 2;
            this.bt_dm.Text = "Quản lý danh mục";
            this.bt_dm.UseVisualStyleBackColor = false;
            this.bt_dm.Click += new System.EventHandler(this.bt_dm_Click);
            // 
            // bt_tk_dt
            // 
            this.bt_tk_dt.BackColor = System.Drawing.Color.White;
            this.bt_tk_dt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_tk_dt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tk_dt.Location = new System.Drawing.Point(60, 207);
            this.bt_tk_dt.Name = "bt_tk_dt";
            this.bt_tk_dt.Size = new System.Drawing.Size(137, 62);
            this.bt_tk_dt.TabIndex = 3;
            this.bt_tk_dt.Text = "Thống kê doanh thu";
            this.bt_tk_dt.UseVisualStyleBackColor = false;
            this.bt_tk_dt.Click += new System.EventHandler(this.bt_tk_dt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::QLquancafe.Properties.Resources.menu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 62);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::QLquancafe.Properties.Resources.nv;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 62);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::QLquancafe.Properties.Resources.danh_muc;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 62);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::QLquancafe.Properties.Resources.thong_ke;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(3, 207);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 62);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::QLquancafe.Properties.Resources.admin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uC_dm1
            // 
            this.uC_dm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_dm1.Location = new System.Drawing.Point(200, 0);
            this.uC_dm1.Name = "uC_dm1";
            this.uC_dm1.Size = new System.Drawing.Size(824, 505);
            this.uC_dm1.TabIndex = 5;
            this.uC_dm1.Visible = false;
            // 
            // uC_thongke1
            // 
            this.uC_thongke1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_thongke1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_thongke1.Location = new System.Drawing.Point(200, 0);
            this.uC_thongke1.Name = "uC_thongke1";
            this.uC_thongke1.Size = new System.Drawing.Size(824, 505);
            this.uC_thongke1.TabIndex = 4;
            this.uC_thongke1.Visible = false;
            // 
            // uC_menu1
            // 
            this.uC_menu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_menu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_menu1.Location = new System.Drawing.Point(200, 0);
            this.uC_menu1.Name = "uC_menu1";
            this.uC_menu1.Size = new System.Drawing.Size(824, 505);
            this.uC_menu1.TabIndex = 3;
            // 
            // uC_nv1
            // 
            this.uC_nv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_nv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_nv1.Location = new System.Drawing.Point(200, 0);
            this.uC_nv1.Name = "uC_nv1";
            this.uC_nv1.Size = new System.Drawing.Size(824, 505);
            this.uC_nv1.TabIndex = 1;
            // 
            // Formquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 505);
            this.Controls.Add(this.uC_dm1);
            this.Controls.Add(this.uC_thongke1);
            this.Controls.Add(this.uC_menu1);
            this.Controls.Add(this.uC_nv1);
            this.Controls.Add(this.panel1);
            this.Name = "Formquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formquanly";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private UC_nv uC_nv1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_ql_menu;
        private System.Windows.Forms.Button bt_ql_nv;
        private System.Windows.Forms.Button bt_dm;
        private System.Windows.Forms.Button bt_tk_dt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private UC_menu uC_menu1;
        private UC_thongke uC_thongke1;
        private UC_dm uC_dm1;
    }
}