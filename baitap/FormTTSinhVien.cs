using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BaiTap
{
    public partial class FormTTSinhVien : Form
    {
        private StudentManager qlSinhVien;
        private string filePath = "students.txt";

        public FormTTSinhVien()
        {
            InitializeComponent();
            qlSinhVien = new StudentManager(filePath);
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            qlSinhVien.HienThiDanhSach(lvDSSV);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn Thoát chương trình không?", "Xác nhận Thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc muốn reset tất cả thông tin về mặc định?", "Xác nhận Reset", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                mtxtMaSo.Text = "";
                txtHoTenLot.Text = "";
                txtTen.Text = "";
                dtpNgaySinh.Value = DateTime.Now;
                cboLop.SelectedIndex = -1;
                mtxtCCCD.Text = "";
                mtxtSDT.Text = "";
                txtDiaChi.Text = "";
                rdNam.Checked = true;
                HienThiDanhSach();

                for (int i = 0; i < clbMonHoc.Items.Count; i++)
                {
                    clbMonHoc.SetItemChecked(i, false);
                }
                MessageBox.Show("Đã reset form về mặc định!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(mtxtMaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã số sinh viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtMaSo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTenLot.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên lót!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenLot.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sinh viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboLop.Text))
            {
                MessageBox.Show("Vui lòng chọn Lớp!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtxtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtCCCD.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtxtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;

            if (lvDSSV.SelectedItems.Count > 0)
            {
                Student svCu = lvDSSV.SelectedItems[0].Tag as Student;

                // Cập nhật thông tin từ form
                Student svMoi = new Student();
                svMoi.MSSV = svCu.MSSV; // Giữ nguyên MSSV
                svMoi.HoTenLot = txtHoTenLot.Text;
                svMoi.Ten = txtTen.Text;
                svMoi.Lop = cboLop.Text;
                svMoi.NgaySinh = dtpNgaySinh.Value;
                svMoi.CCCD = mtxtCCCD.Text;
                svMoi.SDT = mtxtSDT.Text;
                svMoi.DiaChi = txtDiaChi.Text;
                svMoi.GioiTinh = rdNam.Checked;

                // Lấy môn học từ CheckedListBox
                svMoi.MonHoc = clbMonHoc.CheckedItems.Cast<string>().ToList();

                if (qlSinhVien.CapNhatSinhVien(svMoi))
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSSV.SelectedItems.Count > 0)
            {
                string mssv = lvDSSV.SelectedItems[0].Text;
                if (qlSinhVien.XoaSinhVien(mssv))
                {
                    HienThiDanhSach();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;

            // Lấy thông tin từ controls trên form
            Student sv = new Student();
            sv.MSSV = mtxtMaSo.Text;
            sv.HoTenLot = txtHoTenLot.Text;
            sv.Ten = txtTen.Text;
            sv.Lop = cboLop.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.CCCD = mtxtCCCD.Text;
            sv.SDT = mtxtSDT.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.GioiTinh = rdNam.Checked;

            // Lấy môn học từ CheckedListBox
            sv.MonHoc = clbMonHoc.CheckedItems.Cast<string>().ToList();

            if (qlSinhVien.ThemSinhVien(sv))
            {
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach();
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var frm = new FormTimKiem();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Thực hiện tìm kiếm trong form chính
                var ketQua = qlSinhVien.TimKiemNhieuTieuChi(frm.MSSV, frm.HoTenLot, frm.Ten, frm.Lop);
                qlSinhVien.HienThiDanhSachTimKiem(ketQua, lvDSSV);
            }
        }


        private void thêmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string monMoi = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên môn học mới:", "Thêm môn học", "");
            if (!string.IsNullOrWhiteSpace(monMoi))
            {
                clbMonHoc.Items.Add(monMoi);
            }
        }

        private void xóaMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.SelectedItem != null)
            {
                clbMonHoc.Items.Remove(clbMonHoc.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.");
            }
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSSV.SelectedItems.Count > 0)
            {
                // Lấy sinh viên được chọn từ Tag
                Student selectedStudent = lvDSSV.SelectedItems[0].Tag as Student;

                if (selectedStudent != null)
                {
                    // Hiển thị thông tin lên các controls
                    HienThiThongTinSinhVien(selectedStudent);
                }
            }
        }

        // Phương thức hiển thị thông tin sinh viên lên form
        private void HienThiThongTinSinhVien(Student sv)
        {
            // Hiển thị thông tin cơ bản
            mtxtMaSo.Text = sv.MSSV;
            txtHoTenLot.Text = sv.HoTenLot;
            txtTen.Text = sv.Ten;
            cboLop.Text = sv.Lop;
            dtpNgaySinh.Value = sv.NgaySinh;
            mtxtCCCD.Text = sv.CCCD;
            mtxtSDT.Text = sv.SDT;
            txtDiaChi.Text = sv.DiaChi;

            // Thiết lập giới tính
            rdNam.Checked = sv.GioiTinh;
            rdNu.Checked = !sv.GioiTinh;

            // Hiển thị môn học đã đăng ký lên CheckedListBox
            HienThiMonHocDaDangKy(sv.MonHoc);
        }

        private void HienThiMonHocDaDangKy(List<string> danhSachMonHoc)
        {
            // Bỏ chọn tất cả trước
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }

            // Chọn các môn học mà sinh viên đã đăng ký
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                string monHoc = clbMonHoc.Items[i].ToString();
                if (danhSachMonHoc.Contains(monHoc))
                {
                    clbMonHoc.SetItemChecked(i, true);
                }
            }
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra có sinh viên nào được chọn hay không
            bool coChon = false;
            foreach (ListViewItem item in lvDSSV.Items)
            {
                if (item.Checked)
                {
                    coChon = true;
                    break;
                }
            }

            if (!coChon)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Hỏi người dùng có chắc chắn muốn xóa không
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đã chọn?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvDSSV.Items)
                {
                    if (item.Checked)
                    {
                        qlSinhVien.XoaSinhVien(item.Text);
                    }
                }
                HienThiDanhSach();

                MessageBox.Show("Xóa sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
