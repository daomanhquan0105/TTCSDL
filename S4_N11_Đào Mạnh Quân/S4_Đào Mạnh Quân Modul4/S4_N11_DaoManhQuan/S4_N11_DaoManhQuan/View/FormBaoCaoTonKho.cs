using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using S4_N11_DaoManhQuan.Model;
using S4_N11_DaoManhQuan.Controller;
using DGVPrinterHelper;

namespace S4_N11_DaoManhQuan.View
{
    public partial class FormBaoCaoTonKho : Form
    {
        QuanLyKhoSuaEntities db = new QuanLyKhoSuaEntities();
        public FormBaoCaoTonKho()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7MQ60DF;Initial Catalog=S4_N11_QuanLyKhoSua;
                                            Integrated Security=True");
        private void FormBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Bao_cao_dau_ra(null, null)";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataBaoCao.DataSource = dt;
            con.Close();
            //DataGridView item = new DataGridView();
            TinhToan();
        }
        int rowCount, columnCount;
        void TinhToan()
        {
            int tongSLdauKy = 0, tongSLNhap = 0, tongSLXuat = 0, tongSLConLai = 0;
            rowCount = DataBaoCao.Rows.Count;
            columnCount = DataBaoCao.Columns.Count;
            for (int i = 0; i < rowCount; ++i)
            {
                DataBaoCao.Rows[i].Cells[0].Value = (i + 1);
                tongSLdauKy += Convert.ToInt32(DataBaoCao.Rows[i].Cells[3].Value);
                tongSLNhap += Convert.ToInt32(DataBaoCao.Rows[i].Cells[4].Value);
                tongSLXuat += Convert.ToInt32(DataBaoCao.Rows[i].Cells[5].Value);
                tongSLConLai += Convert.ToInt32(DataBaoCao.Rows[i].Cells[6].Value);
            }
            LbDauKy.Text = tongSLdauKy.ToString();
            LbSLNhap.Text = tongSLNhap.ToString();
            LbSLXuat.Text = tongSLXuat.ToString();
            LbCuoiKy.Text = tongSLConLai.ToString();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "select * from Bao_cao_dau_ra('"+DTBegin.Value+"','"+DTEnd.Value+"')";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            DataBaoCao.DataSource = dt;
            con.Close();
            TinhToan();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBaoCaoTonKho_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormControl control = new FormControl();
            this.Hide();
            control.ShowDialog();
            this.Show();
        }

        private void documentWriter()
        {

            try
            {
                DGVPrinter printer = new DGVPrinter();
                
                printer.PrintDataGridView(DataBaoCao);
                MessageBox.Show("thành công");
            }
            catch(Exception ex) { MessageBox.Show("" + ex); }

        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            documentWriter();
        }
    }
}
