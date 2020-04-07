using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S4_N11_DaoManhQuan.Model;

namespace S4_N11_DaoManhQuan.View
{
    public partial class FormNhanVien : Form
    {
        QuanLyKhoSuaEntities db = new QuanLyKhoSuaEntities();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void HienThi(List<Model.NhanVien> dsNhanVien)
        {
            ListViewNhanVien.Items.Clear();
            foreach (Model.NhanVien nv in dsNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoNV);
                item.SubItems.Add(nv.TenNV);
                item.SubItems.Add(nv.DiaChi);
                item.SubItems.Add(nv.GT);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.Luong.ToString());
                item.SubItems.Add(nv.MaPB);
                ListViewNhanVien.Items.Add(item);
            }
            CbPhongBan.DataSource = db.PhongBans.ToList();
            CbPhongBan.DisplayMember = "TenPB";
            CbPhongBan.ValueMember = "MaPB";
            XoaTT();
        }
        void XoaTT()
        {
            TbTen.Text = "";
            TbHo.Text = "";
            TbDiaChi.Text = "";
            TbMaNV.Text = "";
            TbLuong.Text = "";
            RadNam.Checked = false;
            RadNu.Checked = false;
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            List<Model.NhanVien> dsNhanVien = db.NhanViens.ToList();
            HienThi(dsNhanVien);
        }

        string maNhanVien;
        private void ListViewNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewNhanVien.SelectedItems[0];
                maNhanVien = selectedItem.SubItems[0].Text;
                TbMaNV.Text = maNhanVien;
                TbHo.Text = selectedItem.SubItems[1].Text;
                TbTen.Text = selectedItem.SubItems[2].Text;
                TbDiaChi.Text = selectedItem.SubItems[3].Text;
                if (selectedItem.SubItems[4].Text == "Nam") RadNam.Checked = true;
                else RadNu.Checked = true;
                DTNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[5].Text);
                TbLuong.Text = selectedItem.SubItems[6].Text;
                CbPhongBan.SelectedValue = selectedItem.SubItems[7].Text;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thêm nhân viên không?", "Thông báo:",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Model.NhanVien newNhanVien = new Model.NhanVien()
                    {
                        MaNV = TbMaNV.Text,
                        HoNV = TbHo.Text,
                        TenNV = TbTen.Text,
                        DiaChi = TbDiaChi.Text,
                        GT = GioiTinhNV(PnGioiTinh),
                        NgaySinh = DTNgaySinh.Value,
                        Luong = decimal.Parse(TbLuong.Text),
                        MaPB = CbPhongBan.SelectedValue.ToString()
                    };
                    db.NhanViens.Add(newNhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    FormNhanVien_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại. Chi tiết lỗi: " + ex.Message, "thông báo");
            }
        }
        string GioiTinhNV(Panel pn)
        {
            foreach (RadioButton rad in pn.Controls)
            {
                if (rad.Checked == true)
                    return rad.Text;
            }
            return "";
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin nhân viên không?", "Thông báo:",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Model.NhanVien selectedNhanVien = db.NhanViens.Find(maNhanVien);
                    selectedNhanVien.HoNV = TbHo.Text;
                    selectedNhanVien.TenNV = TbTen.Text;
                    selectedNhanVien.DiaChi = TbDiaChi.Text;
                    selectedNhanVien.GT = GioiTinhNV(PnGioiTinh);
                    selectedNhanVien.NgaySinh = DTNgaySinh.Value;
                    selectedNhanVien.Luong = decimal.Parse(TbLuong.Text);
                    selectedNhanVien.MaPB = CbPhongBan.SelectedValue.ToString();
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    FormNhanVien_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Chi tiết lỗi: " + ex.Message, "thông báo");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên đã chọn không?", "Thông báo:",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Model.NhanVien selectedNhanVien = db.NhanViens.SingleOrDefault(x => x.MaNV == maNhanVien);
                    db.NhanViens.Remove(selectedNhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "thông báo");
                    FormNhanVien_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Chi tiết lỗi: " + ex.Message, "thông báo");
            }
        }

        private void TbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string res = TbTimKiem.Text;
            if (res.Trim() == "")
            {
                List<Model.NhanVien> dsNhanVien = db.NhanViens.ToList();
                HienThi(dsNhanVien);
            }
            else
            {
                List<Model.NhanVien> dsKetQua = db.NhanViens.Where(x => x.TenNV.ToUpper().Contains(res.ToUpper())).ToList();
                HienThi(dsKetQua);
            }
        }

        private void TbTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            TbTimKiem.Text = "";
            FormNhanVien_Load(sender, e);
        }
    }
}
