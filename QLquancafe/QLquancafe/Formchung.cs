using QLquancafe.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class Formchung : Form
    {
        public Formchung(string id)
        {
            InitializeComponent();
            _id = id;
        }
        public string _id;
        private void Uc_control_hide()
        {
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Hide();
                }
            }
        }
        private void bt_mhc_Click(object sender, EventArgs e)
        {
            Uc_control_hide();
            uC_mhc1.Visible = true;
        }
        private void bt_ttcn_Click(object sender, EventArgs e)
        {
            Formtt_ca_nhan formtt_Ca_Nhan = new Formtt_ca_nhan(_id);
            formtt_Ca_Nhan.ShowDialog();
        }
        private void bt_quanly_Click(object sender, EventArgs e)
        {
            Formquanly formquanly = new Formquanly();
            formquanly.ShowDialog();
        }
    }
}
