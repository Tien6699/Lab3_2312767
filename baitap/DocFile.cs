using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiTap
{
    public class DocFile
    {
        private string filePath;

        public DocFile(string path)
        {
            filePath = path;
        }

        // Đọc danh sách sinh viên từ file
        public List<Student> ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return students;
                }

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');
                    if (parts.Length >= 10)
                    {
                        Student student = new Student();

                        // Parse dữ liệu từ file
                        student.MSSV = parts[0].Trim();
                        student.HoTenLot = parts[1].Trim();
                        student.Ten = parts[2].Trim();
                        student.Lop = parts[3].Trim();

                        // Parse ngày sinh
                        string ngaySinhStr = parts[4].Trim();
                        string[] dateParts = ngaySinhStr.Split('/');
                        if (dateParts.Length == 3)
                        {
                            int day = int.Parse(dateParts[0]);
                            int month = int.Parse(dateParts[1]);
                            int year = int.Parse(dateParts[2]);
                            student.NgaySinh = new DateTime(year, month, day);
                        }
                        student.CCCD = parts[5].Trim();
                        student.SDT = parts[6].Trim();
                        student.DiaChi = parts[7].Trim();

                        // Parse giới tính (0: Nữ, 1: Nam)
                        student.GioiTinh = parts[8].Trim() == "1";

                        // Parse môn học
                        string[] monHoc = parts[9].Split(';');
                        student.MonHoc = new List<string>();
                        foreach (string mh in monHoc)
                        {
                            if (!string.IsNullOrWhiteSpace(mh))
                                student.MonHoc.Add(mh.Trim());
                        }

                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return students;
        }

        // Ghi danh sách sinh viên vào file
        public bool WriteStudentsToFile(List<Student> students)
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (Student student in students)
                {
                    string line = $"{student.MSSV}|{student.HoTenLot}|{student.Ten}|{student.Lop}|" +
                                 $"{student.NgaySinh:dd/MM/yyyy}|{student.CCCD}|{student.SDT}|{student.DiaChi}|" +
                                 $"{(student.GioiTinh ? "1" : "0")}|{string.Join("; ", student.MonHoc)}";
                    lines.Add(line);
                }

                File.WriteAllLines(filePath, lines);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Hiển thị danh sách sinh viên lên ListView
        public void DisplayStudentsToListView(List<Student> students, ListView listView)
        {
            try
            {
                listView.Items.Clear();
                listView.View = View.Details;

                // Thiết lập columns nếu chưa có
                if (listView.Columns.Count == 0)
                {
                    listView.Columns.Add("MSSV", 100);
                    listView.Columns.Add("Họ tên lót", 150);
                    listView.Columns.Add("Tên", 100);
                    listView.Columns.Add("Lớp", 80);
                    listView.Columns.Add("Ngày sinh", 100);
                    listView.Columns.Add("CCCD", 120);
                    listView.Columns.Add("SĐT", 100);
                    listView.Columns.Add("Địa chỉ", 200);
                    listView.Columns.Add("Giới tính", 80);
                    listView.Columns.Add("Môn học", 200);
                }

                foreach (Student student in students)
                {
                    ListViewItem item = new ListViewItem(student.MSSV);
                    item.SubItems.Add(student.HoTenLot);
                    item.SubItems.Add(student.Ten);
                    item.SubItems.Add(student.Lop);
                    item.SubItems.Add(student.NgaySinh.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(student.CCCD);
                    item.SubItems.Add(student.SDT);
                    item.SubItems.Add(student.DiaChi);
                    item.SubItems.Add(student.GioiTinh ? "Nam" : "Nữ");
                    item.SubItems.Add(string.Join("; ", student.MonHoc));

                    // Lưu đối tượng student vào Tag để sử dụng sau này
                    item.Tag = student;

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị danh sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
