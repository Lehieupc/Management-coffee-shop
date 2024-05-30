namespace QLquancafe
{
    partial class FormDangnhap
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
            this.cb_hien_mk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cb_hien_mk);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_mk);
            this.panel1.Controls.Add(this.tb_tk);
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_dangnhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(311, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 389);
            this.panel1.TabIndex = 7;
            // 
            // cb_hien_mk
            // 
            this.cb_hien_mk.AutoSize = true;
            this.cb_hien_mk.Location = new System.Drawing.Point(70, 303);
            this.cb_hien_mk.Name = "cb_hien_mk";
            this.cb_hien_mk.Size = new System.Drawing.Size(114, 20);
            this.cb_hien_mk.TabIndex = 13;
            this.cb_hien_mk.Text = "Hiện mật khẩu";
            this.cb_hien_mk.UseVisualStyleBackColor = true;
            this.cb_hien_mk.CheckedChanged += new System.EventHandler(this.cb_hien_mk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Member login";
            // 
            // tb_mk
            // 
            this.tb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_mk.Location = new System.Drawing.Point(70, 242);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(220, 30);
            this.tb_mk.TabIndex = 9;
            this.tb_mk.UseSystemPasswordChar = true;
            // 
            // tb_tk
            // 
            this.tb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_tk.Location = new System.Drawing.Point(70, 126);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(220, 30);
            this.tb_tk.TabIndex = 8;
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoat.Location = new System.Drawing.Point(380, 319);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(105, 38);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(70, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.AutoSize = true;
            this.bt_dangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_dangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_dangnhap.Location = new System.Drawing.Point(234, 319);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(122, 38);
            this.bt_dangnhap.TabIndex = 10;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::QLquancafe.Properties.Resources.imagelogin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 389);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangnhap
            // 
            this.AcceptButton = this.bt_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.bt_thoat;
            this.ClientSize = new System.Drawing.Size(824, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_hien_mk;
        private System.Windows.Forms.TextBox tb_mk;
        public System.Windows.Forms.TextBox tb_tk;
    }
}

