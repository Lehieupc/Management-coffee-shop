using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLquancafe
{
    public partial class Formchung : Form
    {
        public Formchung()
        {
            InitializeComponent();
        }

        public bool teep = false;
        private void Formchung_Load(object sender, EventArgs e)
        {
            quảnLýToolStripMenuItem.Visible = teep;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formquanly formquanly = new Formquanly();
            formquanly.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
