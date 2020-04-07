using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S4_N11_DaoManhQuan.View;

namespace S4_N11_DaoManhQuan.Controller
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien FNV = new FormNhanVien();
            this.Hide();
            FNV.ShowDialog();
            this.Show();
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien FNV = new FormNhanVien();
            this.Hide();
            FNV.ShowDialog();
            this.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoTonKho baoCao = new FormBaoCaoTonKho();
            this.Hide();
            baoCao.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
