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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uC_tt_canhan1 = new QLquancafe.user_control.UC_tt_canhan();
            this.uC_qlban1 = new QLquancafe.user_control.UC_qlban();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 494);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uC_tt_canhan1
            // 
            this.uC_tt_canhan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_tt_canhan1.Location = new System.Drawing.Point(200, 0);
            this.uC_tt_canhan1.Name = "uC_tt_canhan1";
            this.uC_tt_canhan1.Size = new System.Drawing.Size(900, 494);
            this.uC_tt_canhan1.TabIndex = 2;
            // 
            // uC_qlban1
            // 
            this.uC_qlban1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_qlban1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_qlban1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_qlban1.Location = new System.Drawing.Point(200, 0);
            this.uC_qlban1.Name = "uC_qlban1";
            this.uC_qlban1.Size = new System.Drawing.Size(900, 494);
            this.uC_qlban1.TabIndex = 1;
            // 
            // Formchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 494);
            this.Controls.Add(this.uC_tt_canhan1);
            this.Controls.Add(this.uC_qlban1);
            this.Controls.Add(this.panel1);
            this.Name = "Formchung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cafe";
            this.Load += new System.EventHandler(this.Formchung_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private user_control.UC_qlban uC_qlban1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private user_control.UC_tt_canhan uC_tt_canhan1;
    }
}