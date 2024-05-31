namespace QLquancafe
{
    partial class UC_dm
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
            this.dtgv_dm = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ma_dm = new System.Windows.Forms.TextBox();
            this.tb_ten_dm = new System.Windows.Forms.TextBox();
            this.bt_them_nl = new System.Windows.Forms.Button();
            this.bt_sua_nl = new System.Windows.Forms.Button();
            this.bt_xoa_nl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dm)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_dm
            // 
            this.dtgv_dm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_dm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv_dm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_dm.Location = new System.Drawing.Point(0, 100);
            this.dtgv_dm.Name = "dtgv_dm";
            this.dtgv_dm.RowHeadersWidth = 51;
            this.dtgv_dm.RowTemplate.Height = 24;
            this.dtgv_dm.Size = new System.Drawing.Size(773, 366);
            this.dtgv_dm.TabIndex = 3;
            this.dtgv_dm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nl_CellClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tb_ma_dm, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_ten_dm, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.bt_them_nl, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.bt_sua_nl, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.bt_xoa_nl, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(773, 100);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 50);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã danh mục";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 50);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tên danh mục";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ma_dm
            // 
            this.tb_ma_dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ma_dm.Location = new System.Drawing.Point(196, 3);
            this.tb_ma_dm.Name = "tb_ma_dm";
            this.tb_ma_dm.Size = new System.Drawing.Size(264, 22);
            this.tb_ma_dm.TabIndex = 3;
            // 
            // tb_ten_dm
            // 
            this.tb_ten_dm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ten_dm.Location = new System.Drawing.Point(196, 53);
            this.tb_ten_dm.Name = "tb_ten_dm";
            this.tb_ten_dm.Size = new System.Drawing.Size(264, 22);
            this.tb_ten_dm.TabIndex = 4;
            // 
            // bt_them_nl
            // 
            this.bt_them_nl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them_nl.Location = new System.Drawing.Point(620, 3);
            this.bt_them_nl.Name = "bt_them_nl";
            this.bt_them_nl.Size = new System.Drawing.Size(150, 27);
            this.bt_them_nl.TabIndex = 8;
            this.bt_them_nl.Text = "Thêm";
            this.bt_them_nl.UseVisualStyleBackColor = true;
            this.bt_them_nl.Click += new System.EventHandler(this.bt_them_nl_Click);
            // 
            // bt_sua_nl
            // 
            this.bt_sua_nl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua_nl.Location = new System.Drawing.Point(620, 53);
            this.bt_sua_nl.Name = "bt_sua_nl";
            this.bt_sua_nl.Size = new System.Drawing.Size(150, 27);
            this.bt_sua_nl.TabIndex = 9;
            this.bt_sua_nl.Text = "Sửa";
            this.bt_sua_nl.UseVisualStyleBackColor = true;
            this.bt_sua_nl.Click += new System.EventHandler(this.bt_sua_nl_Click);
            // 
            // bt_xoa_nl
            // 
            this.bt_xoa_nl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa_nl.Location = new System.Drawing.Point(466, 3);
            this.bt_xoa_nl.Name = "bt_xoa_nl";
            this.bt_xoa_nl.Size = new System.Drawing.Size(148, 28);
            this.bt_xoa_nl.TabIndex = 10;
            this.bt_xoa_nl.Text = "Xóa";
            this.bt_xoa_nl.UseVisualStyleBackColor = true;
            this.bt_xoa_nl.Click += new System.EventHandler(this.bt_xoa_nl_Click);
            // 
            // UC_dm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgv_dm);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "UC_dm";
            this.Size = new System.Drawing.Size(773, 466);
            this.Load += new System.EventHandler(this.UC_dm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dm)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_dm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_ma_dm;
        private System.Windows.Forms.TextBox tb_ten_dm;
        private System.Windows.Forms.Button bt_them_nl;
        private System.Windows.Forms.Button bt_sua_nl;
        private System.Windows.Forms.Button bt_xoa_nl;
    }
}
