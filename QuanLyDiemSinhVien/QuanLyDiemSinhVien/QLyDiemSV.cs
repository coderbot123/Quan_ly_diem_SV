using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien
{
    public class QLyDiemSV
    {
        SqlConnection conn;
        public void moKetNoi()
        {
            string sql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLDiemSinhVien;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }

        public void dongKetNoi()
        {
            conn.Close();
        }
        // hàm lấy dữ liệu nhân viên
        public DataTable dssv1()
        {
            moKetNoi();
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv2()
        {
            moKetNoi();
            string query = "select * from Nganh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv3()
        {
            moKetNoi();
            string query = "select * from LopHocPhan";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv4()
        {
            moKetNoi();
            string query = "select * from Lop";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv5()
        {
            moKetNoi();
            string query = "select * from HocPhan";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv6()
        {
            moKetNoi();
            string query = "select * from Diem";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public DataTable dssv7()
        {
            moKetNoi();
            string query = "select * from DangKyHocPhan";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }

        public bool tontaiSinhVien(string masv)
        {
            moKetNoi();
            string query = "select * from SinhVien where MaSV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", masv);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiNganh(string man)
        {
            moKetNoi();
            string query = "select * from Nganh where MaNganh = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", man);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiLopHocPhan(string malhp)
        {
            moKetNoi();
            string query = "select * from LopHocPhan where MaLopHP = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", malhp);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiHocPhan(string man)
        {
            moKetNoi();
            string query = "select * from HocPhan where MaHP = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", man);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiLop(string ma)
        {
            moKetNoi();
            string query = "select * from Lop where MaLop = @malop";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malop", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiDiem(string ma)
        {
            moKetNoi();
            string query = "select * from Diem where MaDiem = @madiem";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madiem", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool tontaiDangKyHocPhan(string ma)
        {
            moKetNoi();
            string query = "select * from DangKyHocPhan where MaDK = @madk";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madk", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public void themSinhVien(string ma, string hoten, string quequan, string gt, DateTime ns,
             string dt, string cdut, string malop, string dc)
        {
            moKetNoi();
            string query = "insert into SinhVien values(@masv, @hoten, @quequan, @gioitinh" +
                ", @ngaysinh, @dienthoai, @cdut, @malop, @dc)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("masv", ma);
            cmd.Parameters.AddWithValue("hoten", hoten);
            cmd.Parameters.AddWithValue("quequan", quequan);
            cmd.Parameters.AddWithValue("gioitinh", gt);
            cmd.Parameters.AddWithValue("ngaysinh", ns);
            cmd.Parameters.AddWithValue("dienthoai", dt);
            cmd.Parameters.AddWithValue("cdut", cdut);
            cmd.Parameters.AddWithValue("malop", malop);
            cmd.Parameters.AddWithValue("dc", dc);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themNganh(string ma, string ten)
        {
            moKetNoi();
            string query = "insert into Nganh values(@man, @tenn)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("man", ma);
            cmd.Parameters.AddWithValue("tenn", ten);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themLopHocPhan(string malhp, string ten, string mahp, string gv, string ss)
        {
            moKetNoi();
            string query = "insert into LopHocPhan values(@ma, @tenlhp, @mahp, @magv, @siso)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", malhp);
            cmd.Parameters.AddWithValue("tenlhp", ten);
            cmd.Parameters.AddWithValue("mahp", mahp);
            cmd.Parameters.AddWithValue("magv", gv);
            cmd.Parameters.AddWithValue("siso", ss);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themLop(string ma, string ten, string manganh, string cvht)
        {
            moKetNoi();
            string query = "insert into Lop values(@malop, @tenlop, @manganh, @cvht)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malop", ma);
            cmd.Parameters.AddWithValue("tenlop", ten);
            cmd.Parameters.AddWithValue("manganh", manganh);
            cmd.Parameters.AddWithValue("cvht", cvht);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themHocPhan(string ma, string ten, string so)
        {
            moKetNoi();
            string query = "insert into HocPhan values(@mahp, @tenhp, @sotc)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahp", ma);
            cmd.Parameters.AddWithValue("tenhp", ten);
            cmd.Parameters.AddWithValue("sotc", so);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themDiem(string ma, string mahp, string masv, string loaidiem, string gtdiem, string ghichu)
        {
            moKetNoi();
            string query = "insert into Diem values(@madiem, @mahp, @masv, @loaidiem,  @gtdiem, @ghichu)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madiem", ma);
            cmd.Parameters.AddWithValue("mahp", mahp);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.Parameters.AddWithValue("loaidiem", loaidiem);
            cmd.Parameters.AddWithValue("gtdiem", gtdiem);
            cmd.Parameters.AddWithValue("ghichu", ghichu);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void themDangKyHocPhan(string ma, string malhp, string masv, string ngaydk)
        {
            moKetNoi();
            string query = "insert into DangKyHocPhan values(@madk, @malhp, @masv, @ngaydk)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madk", ma);
            cmd.Parameters.AddWithValue("malhp", malhp);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.Parameters.AddWithValue("ngaydk", ngaydk);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void xoaSinhVien(string masv)
        {
            moKetNoi();
            string query = "delete SinhVien where MaSV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", masv);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void xoaNganh(string man)
        {
            moKetNoi();
            string query = "delete Nganh where MaNganh = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", man);
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        public void xoaLopHocPhan(string ma)
        {
            moKetNoi();
            string query = "delete LopHocPhan where MaLopHP = @malhp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malhp", ma);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void xoaLop(string ma)
        {
            moKetNoi();
            string query = "delete Lop where MaLop = @malop";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malop", ma);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void xoaHocPhan(string ma)
        {
            moKetNoi();
            string query = "delete HocPhan where MaHP = @mahp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahp", ma);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void xoaDiem(string ma)
        {
            moKetNoi();
            string query = "delete Diem where MaDiem = @madiem";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madiem", ma);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void xoaDangKyHocPhan(string ma)
        {
            moKetNoi();
            string query = "delete DangKyHocPhan where MaDK = @madk";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madk", ma);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaSinhVien(string ma, string hoten, string quequan, string gt, DateTime ns,
             string dt, string cdut, string malop, string dc)
        {
            moKetNoi();
            string query = "update SinhVien set HoTen = @ten, QueQuan = @quequan, GioiTinh = @gt, NgaySinh=@ns" +
                ", SoDT = @dt, CheDoUT = @cdut, MaLop = @malop,  DiaChi = @dc where MaSV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", hoten);
            cmd.Parameters.AddWithValue("quequan", quequan);
            cmd.Parameters.AddWithValue("gt", gt);
            cmd.Parameters.AddWithValue("ns", ns);
            cmd.Parameters.AddWithValue("dt", dt);
            cmd.Parameters.AddWithValue("cdut", cdut);
            cmd.Parameters.AddWithValue("malop", malop);
            cmd.Parameters.AddWithValue("dc", dc);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaNganh(string ma, string ten)
        {
            moKetNoi();
            string query = "update Nganh set TenNganh = @tenn where MaNganh = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("tenn", ten);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaLopHocPhan(string ma, string ten, string mahp, string tengv, string ss)
        {
            moKetNoi();
            string query = "update LopHocPhan set TenLopHP = @tenlhp, MaHP = @mahp, TenGV = @tengv, SiSo = @siso where MaLopHP = @malhp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malhp", ma);
            cmd.Parameters.AddWithValue("tenlhp", ten);
            cmd.Parameters.AddWithValue("mahp", mahp);
            cmd.Parameters.AddWithValue("tengv", tengv);
            cmd.Parameters.AddWithValue("siso", ss);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaLop(string ma, string ten, string manganh, string cvht)
        {
            moKetNoi();
            string query = "update Lop set TenLop = @tenlop, MaNganh = @manganh, CoVanHT = @cvht where MaLop = @malop";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malop", ma);
            cmd.Parameters.AddWithValue("tenlop", ten);
            cmd.Parameters.AddWithValue("manganh", manganh);
            cmd.Parameters.AddWithValue("cvht", cvht);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaHocPhan(string ma, string ten, string sotc)
        {
            moKetNoi();
            string query = "update HocPhan set TenHP = @tenhp, SoTinChi = @sotc where MaHP = @mahp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahp", ma);
            cmd.Parameters.AddWithValue("tenhp", ten);
            cmd.Parameters.AddWithValue("sotc", sotc);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaDiem(string ma, string mahp, string masv, string loaidiem, string gtdiem, string ghichu)
        {
            moKetNoi();
            string query = "update Diem set MaHP = @mahp, MaSV = @masv, LoaiDiem = @loaidiem, GiaTriDiem = @gtdiem" +
                ", GhiChu = @ghichu where MaDiem = @madiem";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madiem", ma);
            cmd.Parameters.AddWithValue("mahp", mahp);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.Parameters.AddWithValue("loaidiem", loaidiem);
            cmd.Parameters.AddWithValue("gtdiem", gtdiem);
            cmd.Parameters.AddWithValue("ghichu", ghichu);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        public void suaDangKyHocPhan(string ma, string malhp, string masv, string ngaydk)
        {
            moKetNoi();
            string query = "update DangKyHocPhan set MaLopHP = @malhp, MaSV = @masv, NgayDK = @ngaydk where MaDK = @madk";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("madk", ma);
            cmd.Parameters.AddWithValue("malhp", malhp);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.Parameters.AddWithValue("ngaydk", ngaydk);
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

        //kiểm tra tồn tại người dùng
        public bool tontaiNguoiDung(string ten, string mk)
        {
            bool kt = false;
            moKetNoi();
            string query = "select * from NguoiDung where tendangnhap=@tendn and matkhau=@matkhau";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("tendn", ten);
            cmd.Parameters.AddWithValue("matkhau", mk);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                kt = true;
            }
            dongKetNoi();
            return kt;
        }
        //tìm kiếm Sinh viên
        public bool timkiemSV(string ma)
        {
            bool kt = false;
            moKetNoi();
            string query = "select * from SinhVien where MaSV=@masv";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("masv", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                kt = true;
            }
            dongKetNoi();
            return kt;
        }

        public DataTable TK(string ma)
        {
            moKetNoi();
            string query = "select * from SinhVien where MaSV=@masv";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("masv", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable bang = new DataTable();
            bang.Load(dr);
            dongKetNoi();
            return bang;
        }
        //tăng sĩ số khi sinh viên đăng ký lớp học phần
        public void tang(string malhp)
        {
            moKetNoi();
            string query2 = "update LopHocPhan set SiSo = SiSo + 1 where LopHocPhan.MaLopHP = @malhp";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("malhp", malhp);
            cmd2.ExecuteNonQuery();
            dongKetNoi();
        }
        //giảm sĩ số khi sinh viên hủy đăng ký lớp học phần
        public void giam(string malhp)
        {
            moKetNoi();
            string query2 = "update LopHocPhan set SiSo = SiSo - 1 where LopHocPhan.MaLopHP = @malhp";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("malhp", malhp);
            cmd2.ExecuteNonQuery();
            dongKetNoi();
        }

        public bool kTra(string malhp, string masv)
        {
            moKetNoi();
            string query = "select * from DangKyHocPhan where MaSV = @ma and MaLopHP = @malhp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("malhp", malhp);
            cmd.Parameters.AddWithValue("ma", masv);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        public bool kTra2(string mahp, string masv, string loaidiem)
        {
            moKetNoi();
            string query = "select * from Diem where MaHP = @mahp and MaSV = @masv and LoaiDiem = @loaidiem";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahp", mahp);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.Parameters.AddWithValue("loaidiem", loaidiem);
            SqlDataReader dr = cmd.ExecuteReader();
            bool kt = false;
            if (dr.HasRows) kt = true;
            dongKetNoi();
            return kt;
        }

        //tự tăng mã đăng ký khi nhấp chuột vào textbox mã đăng ký
        public string Manhanvientutang()
        {
            moKetNoi();
            string sql = "select top 1 MaDK from DangKyHocPhan ORDER BY MaDK DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            var d2 = cmd.ExecuteScalar();
            string ma1 = d2.ToString();                 
            int k;
            k = Convert.ToInt32(ma1);
            k = k + 1;
            string s = "";
            s  = k.ToString();
            dongKetNoi();
            return s;
           
        }

        public string Manhanvientutang2()
        {
            moKetNoi();
            string sql = "select top 1 MaDiem from Diem ORDER BY MaDiem DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            var d2 = cmd.ExecuteScalar();
            string ma1 = d2.ToString();
            int k;
            k = Convert.ToInt32(ma1);
            k = k + 1;
            string s = "";
            s = k.ToString();
            dongKetNoi();
            return s;

        }
      
        
       
    }
}
