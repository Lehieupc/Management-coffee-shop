namespace QLquancafe
{
    partial class Formchung
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
            this.bt_quanly = new System.Windows.Forms.Button();
            this.bt_ttcn = new System.Windows.Forms.Button();
            this.bt_dsbc = new System.Windows.Forms.Button();
            this.bt_mhc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_mhc1 = new QLquancafe.user_control.UC_mhc();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 494);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39267F));
            this.tableLayoutPanel1.Controls.Add(this.bt_quanly, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_ttcn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_dsbc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_mhc, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 244);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bt_quanly
            // 
            this.bt_quanly.AutoSize = true;
            this.bt_quanly.BackColor = System.Drawing.Color.White;
            this.bt_quanly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_quanly.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quanly.Location = new System.Drawing.Point(50, 186);
            this.bt_quanly.Name = "bt_quanly";
            this.bt_quanly.Size = new System.Drawing.Size(138, 55);
            this.bt_quanly.TabIndex = 0;
            this.bt_quanly.Text = "Quản lý";
            this.bt_quanly.UseVisualStyleBackColor = false;
            this.bt_quanly.Click += new System.EventHandler(this.bt_quanly_Click);
            // 
            // bt_ttcn
            // 
            this.bt_ttcn.AutoSize = true;
            this.bt_ttcn.BackColor = System.Drawing.Color.White;
            this.bt_ttcn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ttcn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ttcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ttcn.Location = new System.Drawing.Point(50, 125);
            this.bt_ttcn.Name = "bt_ttcn";
            this.bt_ttcn.Size = new System.Drawing.Size(138, 55);
            this.bt_ttcn.TabIndex = 2;
            this.bt_ttcn.Text = "Thông tin cá nhân";
            this.bt_ttcn.UseVisualStyleBackColor = false;
            this.bt_ttcn.Click += new System.EventHandler(this.bt_ttcn_Click);
            // 
            // bt_dsbc
            // 
            this.bt_dsbc.AutoSize = true;
            this.bt_dsbc.BackColor = System.Drawing.Color.White;
            this.bt_dsbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_dsbc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_dsbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dsbc.Location = new System.Drawing.Point(50, 64);
            this.bt_dsbc.Name = "bt_dsbc";
            this.bt_dsbc.Size = new System.Drawing.Size(138, 55);
            this.bt_dsbc.TabIndex = 3;
            this.bt_dsbc.Text = "DS bán chạy";
            this.bt_dsbc.UseVisualStyleBackColor = false;
            // 
            // bt_mhc
            // 
            this.bt_mhc.AutoSize = true;
            this.bt_mhc.BackColor = System.Drawing.Color.White;
            this.bt_mhc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_mhc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_mhc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mhc.Location = new System.Drawing.Point(50, 3);
            this.bt_mhc.Name = "bt_mhc";
            this.bt_mhc.Size = new System.Drawing.Size(138, 55);
            this.bt_mhc.TabIndex = 1;
            this.bt_mhc.Text = "Màn hình chính";
            this.bt_mhc.UseVisualStyleBackColor = false;
            this.bt_mhc.Click += new System.EventHandler(this.bt_mhc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 112);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 92);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chung";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLquancafe.Properties.Resources.user_chung;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uC_mhc1
            // 
            this.uC_mhc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_mhc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_mhc1.Location = new System.Drawing.Point(191, 0);
            this.uC_mhc1.Name = "uC_mhc1";
            this.uC_mhc1.Size = new System.Drawing.Size(909, 494);
            this.uC_mhc1.TabIndex = 1;
            // 
            // Formchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 494);
            this.Controls.Add(this.uC_mhc1);
            this.Controls.Add(this.panel1);
            this.Name = "Formchung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cafe";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_ttcn;
        private System.Windows.Forms.Button bt_mhc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_dsbc;
        public System.Windows.Forms.Button bt_quanly;
        private user_control.UC_mhc uC_mhc1;
    }
}