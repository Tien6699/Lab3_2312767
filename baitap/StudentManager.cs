using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public class StudentManager
    {
        private List<Student> danhSachSinhVien;
        private DocFile fileHandler;
        private string filePath;

        public List<Student> DanhSachSinhVien { get => danhSachSinhVien; }

        public StudentManager(string path)
        {
            filePath = path;
            fileHandler = new DocFile(filePath);
            danhSachSinhVien = fileHandler.ReadStudentsFromFile();
        }

        // a. Thêm và cập nhật thông tin sinh viên (có lưu vào file)
        public bool ThemSinhVien(Student sv)
        {
            try
            {
                // Kiểm tra trùng MSSV
                if (danhSachSinhVien.Any(s => s.MSSV == sv.MSSV))
                {
                    MessageBox.Show($"MSSV {sv.MSSV} đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                danhSachSinhVien.Add(sv);
                return LuuFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CapNhatSinhVien(Student sv)
        {
            try
            {
                // Tìm sinh viên theo MSSV
                Student svCanCapNhat = danhSachSinhVien.FirstOrDefault(s => s.MSSV == sv.MSSV);
                if (svCanCapNhat != null)
                {
                    // Cập nhật thông tin
                    svCanCapNhat.HoTenLot = sv.HoTenLot;
                    svCanCapNhat.Ten = sv.Ten;
                    svCanCapNhat.Lop = sv.Lop;
                    svCanCapNhat.NgaySinh = sv.NgaySinh;
                    svCanCapNhat.CCCD = sv.CCCD;
                    svCanCapNhat.SDT = sv.SDT;
                    svCanCapNhat.DiaChi = sv.DiaChi;
                    svCanCapNhat.GioiTinh = sv.GioiTinh;
                    svCanCapNhat.MonHoc = sv.MonHoc;

                    return LuuFile();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sinh viên với MSSV: {sv.MSSV}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ThemHoacCapNhatSinhVien(Student sv)
        {
            // Nếu MSSV đã tồn tại thì cập nhật, ngược lại thì thêm mới
            if (danhSachSinhVien.Any(s => s.MSSV == sv.MSSV))
            {
                return CapNhatSinhVien(sv);
            }
            else
            {
                return ThemSinhVien(sv);
            }
        }

        // b. Tìm kiếm sinh viên theo Tên, Lớp, MSSV
        public List<Student> TimKiemSinhVien(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return danhSachSinhVien;

            string tuKhoa = keyword.ToLower().Trim();

            return danhSachSinhVien.Where(s =>
                s.MSSV.ToLower().Contains(tuKhoa) ||
                s.Ten.ToLower().Contains(tuKhoa) ||
                s.HoTenLot.ToLower().Contains(tuKhoa) ||
                s.Lop.ToLower().Contains(tuKhoa) ||
                (s.HoTenLot + " " + s.Ten).ToLower().Contains(tuKhoa) ||
                s.CCCD.Contains(tuKhoa) ||
                s.SDT.Contains(tuKhoa))
                .ToList();
        }

        public List<Student> TimKiemTheoMSSV(string mssv)
        {
            return danhSachSinhVien.Where(s => s.MSSV.ToLower().Contains(mssv.ToLower())).ToList();
        }

        public List<Student> TimKiemTheoTen(string ten)
        {
            return danhSachSinhVien.Where(s => s.Ten.ToLower().Contains(ten.ToLower())).ToList();
        }

        public List<Student> TimKiemTheoLop(string lop)
        {
            return danhSachSinhVien.Where(s => s.Lop.ToLower().Contains(lop.ToLower())).ToList();
        }

        // c. Xóa một hay nhiều sinh viên (có lưu vào file)
        public bool XoaSinhVien(string mssv)
        {
            try
            {
                Student svCanXoa = danhSachSinhVien.FirstOrDefault(s => s.MSSV == mssv);
                if (svCanXoa != null)
                {
                    if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {svCanXoa.Ten} (MSSV: {mssv})?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        danhSachSinhVien.Remove(svCanXoa);
                        return LuuFile();
                    }
                    return false;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sinh viên với MSSV: {mssv}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaNhieuSinhVien(List<string> danhSachMSSV)
        {
            try
            {
                if (danhSachMSSV == null || danhSachMSSV.Count == 0)
                    return false;

                int soLuongXoa = 0;
                foreach (string mssv in danhSachMSSV)
                {
                    Student svCanXoa = danhSachSinhVien.FirstOrDefault(s => s.MSSV == mssv);
                    if (svCanXoa != null)
                    {
                        danhSachSinhVien.Remove(svCanXoa);
                        soLuongXoa++;
                    }
                }

                if (soLuongXoa > 0)
                {
                    MessageBox.Show($"Đã xóa {soLuongXoa} sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return LuuFile();
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhiều sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaTatCaSinhVien()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa TẤT CẢ sinh viên?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    danhSachSinhVien.Clear();
                    return LuuFile();
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa tất cả sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Các phương thức hỗ trợ
        public Student LaySinhVienTheoMSSV(string mssv)
        {
            return danhSachSinhVien.FirstOrDefault(s => s.MSSV == mssv);
        }

        public List<Student> LayTatCaSinhVien()
        {
            return danhSachSinhVien;
        }

        public int TongSoSinhVien()
        {
            return danhSachSinhVien.Count;
        }

        public List<string> LayDanhSachLop()
        {
            return danhSachSinhVien.Select(s => s.Lop).Distinct().ToList();
        }

        private bool LuuFile()
        {
            return fileHandler.WriteStudentsToFile(danhSachSinhVien);
        }

        public void HienThiDanhSach(ListView listView)
        {
            fileHandler.DisplayStudentsToListView(danhSachSinhVien, listView);
        }

        public void HienThiDanhSachTimKiem(List<Student> danhSach, ListView listView)
        {
            fileHandler.DisplayStudentsToListView(danhSach, listView);
        }

        public List<Student> TimKiemNhieuTieuChi(string mssv, string hoTenLot, string ten, string lop)
        {
            var ketQua = danhSachSinhVien;

            if (!string.IsNullOrEmpty(mssv))
                ketQua = ketQua.Where(s => s.MSSV.ToLower().Contains(mssv.ToLower())).ToList();

            if (!string.IsNullOrEmpty(hoTenLot))
                ketQua = ketQua.Where(s => s.HoTenLot.ToLower().Contains(hoTenLot.ToLower())).ToList();

            if (!string.IsNullOrEmpty(ten))
                ketQua = ketQua.Where(s => s.Ten.ToLower().Contains(ten.ToLower())).ToList();

            if (!string.IsNullOrEmpty(lop))
                ketQua = ketQua.Where(s => s.Lop.ToLower().Contains(lop.ToLower())).ToList();

            return ketQua;
        }


    }
}
