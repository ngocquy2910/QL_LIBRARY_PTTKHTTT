using Microsoft.Reporting.WebForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_LIBRARY_PTTKHTTT
{
    class DBQL_ThuVien
    {

        public static SqlConnection GetConnection()
        {
            string sql = @"Data Source=LAPTOP-C9IT8VA3\SQLEXPRESS;Initial Catalog=db_library;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("MySql connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static string getID(string username, string pass, Label lb1)
        {
            string vaitro = "";
            try
            {
                string sql = ("SELECT * FROM  nguoidung WHERE TenNguoiDung ='" + username + "' and MatKhau ='" + pass + "'");
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        vaitro = dr["VaiTro"].ToString();
                        lb1.Text = dr["NguoiDungID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return vaitro;

        }

        public static void ThemNhanVien(NguoiDung nd)
        {
            string sql = "INSERT INTO nguoidung VALUES (@MatKhau,@TenNguoiDung,@VaiTro) ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nd.TenNhanVien;
            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = nd.MatKhau;
            cmd.Parameters.Add("@VaiTro", SqlDbType.Int).Value = nd.VaiTro;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Them That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        public static void DeleteNguoiDung(string id)
        {
            string sql = "DELETE FROM nguoidung WHERE NguoiDungID = @TenID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenID", SqlDbType.NVarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Delete fail!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }

        public static void CapNhatNhanVien(NguoiDung nd, string id)
        {
            string sql = "UPDATE nguoidung SET TenNguoiDung = @TenNguoiDung, MatKhau = @MatKhau, VaiTro = @VaiTro Where NguoiDungID = @id";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = nd.TenNhanVien;
            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = nd.MatKhau;
            cmd.Parameters.Add("@VaiTro", SqlDbType.Int).Value = nd.VaiTro;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap Nhat thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cap Nhat That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();
        }
        public static void HienThiDB(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter DTA = new SqlDataAdapter(cmd);
            dgv.DataSource = dt;
            DTA.Fill(dt);
            con.Close();
        }

        public static void LayVaiTro(string query, string id, string ten, ComboBox cbb)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter DTA = new SqlDataAdapter(cmd);
            DTA.Fill(dt);
            if (DTA != null)
            {
                cbb.ValueMember = id;
                cbb.DisplayMember = ten;
                cbb.DataSource = dt;
            }
        }

        // DB QL_Sách.-----------------------------------------------------------
        public static void ThemMoiSach(Sach book)
        {
            string sql = "INSERT INTO sach VALUES (@TenSach, @TacGia, @NgoNgu, @loaiSach, @NXB, @GiaTien, @SoLuong, @NgayCapNhat, @SoLuongCon) ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NgoNgu", SqlDbType.Int).Value = book.NgonNguID;
            cmd.Parameters.Add("@NXB", SqlDbType.Int).Value = book.NXB;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = book.TenSach;
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = book.TaGia;
            cmd.Parameters.Add("@NgayCapNhat", SqlDbType.NVarChar).Value = book.NgayNhap;
            cmd.Parameters.Add("@GiaTien", SqlDbType.NVarChar).Value = book.GaiTien;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = book.SoLuong;
            cmd.Parameters.Add("@LoaiSach", SqlDbType.Int).Value = book.LoaiSachID;
            cmd.Parameters.Add("@SoLuongCon", SqlDbType.Int).Value = book.SoLuongCon;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Them That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        public static void XoaSach(string id)
        {
            string sql = "DELETE FROM sach WHERE SachID = @TenID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenID", SqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Delete fail!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }

        public static void CapNhatSach(Sach book, string id)
        {
            string sql = string.Format("UPDATE sach SET TenSach = @TenSach, NgonNgu = @NgonNgu, NXB" +
                " = @NXB, TacGia = @TacGia, NgayCapNhat = @NgayNhap, GiaTien = @GiaTien" +
                ", SoLuong = @SoLuong, LoaiSach = @LoaiSach Where SachID = @id");
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@NgonNgu", SqlDbType.Int).Value = book.NgonNguID;
            cmd.Parameters.Add("@NXB", SqlDbType.Int).Value = book.NXB;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = book.TenSach;
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = book.TaGia;
            cmd.Parameters.Add("@NgayNhap", SqlDbType.NVarChar).Value = book.NgayNhap;
            cmd.Parameters.Add("@GiaTien", SqlDbType.NVarChar).Value = book.GaiTien;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = book.SoLuong;
            cmd.Parameters.Add("@LoaiSach", SqlDbType.Int).Value = book.LoaiSachID;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap Nhat thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cap Nhat That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();
        }

        // Tìm kiếm sách 
        public static void TimKiemSach(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter DTA = new SqlDataAdapter(cmd);
            dgv.DataSource = dt;

            try
            {

                DTA.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không tìm thấy sách: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();

        }


        // Phiếu mượn tạm thời 

        public static void TaoPhieuTamThoi(PhieuMuonTamThoi PMTT)
        {
            string sql = "INSERT INTO phieumuonxn VALUES (@SachID, @DocGiaID, @NgayMuon, @NgayHentra, @SoLuong, @TinhTrang) ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SachID", SqlDbType.Int).Value = PMTT.sachid;
            cmd.Parameters.Add("@DocGiaID", SqlDbType.Int).Value = PMTT.docgiaid;
            cmd.Parameters.Add("@NgayMuon", SqlDbType.NVarChar).Value = PMTT.ngaymuon;
            cmd.Parameters.Add("@NgayHentra", SqlDbType.NVarChar).Value = PMTT.ngayhentra;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = PMTT.soluongmuon;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = PMTT.tinhtrang;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tao phieu muon thanh cong, vui long cho thu thu xac nhan.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Them That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        public static void XoaPhieuTamThoi(int id)
        {
            string sql = "DELETE FROM phieumuonxn WHERE PhieuMuonXNID = @TenID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenID", SqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Delete fail!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }

        public static void CapNhatSoLuongSach(int SID, int SLHT)
        {
            string sql = "UPDATE sach SET SoLuongCon = @SLC WHERE SachID = @SID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;


            //---------------------------------
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SID", SqlDbType.Int).Value = SID;
            cmd.Parameters.Add("@SLC", SqlDbType.Int).Value = SLHT;


            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Dong Y cho muon that bai" + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();
        }


        public static void CapNhatPhieu(PhieuMuonTamThoi PMTT, int id)
        {
            string sql = "UPDATE phieumuonxn  SET  TinhTrang = @TinhTrangPM" +
                "         WHERE PhieuMuonXNID = @id";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TinhTrangPM", SqlDbType.NVarChar).Value = PMTT.tinhtrang;

            //---------------------------------
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Dong Y cho muon that bai" + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();
        }
        // Thêm mới độc giả

        public static void ThemMoiTaiKhoan(DocGia TKDG)
        {
            string sql = "INSERT INTO docgia VALUES (@TenDocGia, @DiaChi, @SoDienThoai, @ChungMinhNhanDan)";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TenDocGia", SqlDbType.NVarChar).Value = TKDG.TenDocGia;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = TKDG.DiaChi;
            cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = TKDG.SDT;
            cmd.Parameters.Add("@ChungMinhNhanDan", SqlDbType.NVarChar).Value = TKDG.CMND;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới tài khoản thành công", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Đăng ký tài khoản thất bại: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }

        }

        //Check và lầy thông tin độc giả 

        public static string CHECKDG(string username, string cmnd, Label lb1, Label lb2)
        {
            string DocGia = "";
            try
            {
                string sql = ("SELECT * FROM  docgia WHERE TenDocGia = N'" + username + "' AND ChungMinhThu = N'" + cmnd + "'");
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DocGia = dr["DocGiaID"].ToString();
                        lb1.Text = dr["DienThoai"].ToString();
                        lb2.Text = dr["DiaChi"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return DocGia;

        }

        // Thay đổi thông tin độc giả
        public static void ThayDoiThongTinDG(DocGia DG, int ID)
        {
            string sql = "UPDATE docgia set TenDocGia = @TDG, DiaChi = @DC, DienThoai = @SDT, ChungMinhThu = @CMT " +
                         " WHERE DocGiaID = @ID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@TDG", SqlDbType.NVarChar).Value = DG.TenDocGia;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = DG.DiaChi;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = DG.SDT;
            cmd.Parameters.Add("@CMT", SqlDbType.NVarChar).Value = DG.CMND;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay doi thong tin ca nhan thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thay doi thong tin ca nhan that bai: " + ex.Message + "Thong bao" + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
        }
        public static void XoaTaiKhoan(string id)
        {
            string sql = "DELETE FROM docgia WHERE DocGiaID = @DocGiaID";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DocGiaID", SqlDbType.NVarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Delete fail!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            con.Close();
        }
        //Cập nhật thông tin độc giả
        public static void CapNhatTaiKhoan(TaiKhoanDocGia a, string id)
        {

            string sql = "UPDATE docgia SET TenDocGia = @TenDocGia, DiaChi = @DiaChi, DienThoai" +
                    " = @DienThoai, ChungMinhThu = @ChungMinhThu Where DocGiaID = @id";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@TenDocGia", SqlDbType.Int).Value = a.TenDocGia;
            cmd.Parameters.Add("@DiaChi", SqlDbType.Int).Value = a.DiaChi;
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = a.SoDienThoai;
            cmd.Parameters.Add("@ChungMinhThu", SqlDbType.NVarChar).Value = a.CMND;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap Nhat thanh cong.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cap Nhat That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            con.Close();

        }
        //Tạo phiếu mượn

        public static void TaoPhieuMuon(PhieuMuonTamThoi PMTT)
        {
            string sql = "INSERT INTO phieumuon VALUES (@DocGiaID, @SachID, @NgayMuon, @NgayHentra, @SoLuongMuon) ";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SachID", SqlDbType.Int).Value = PMTT.sachid;
            cmd.Parameters.Add("@DocGiaID", SqlDbType.Int).Value = PMTT.docgiaid;
            cmd.Parameters.Add("@NgayMuon", SqlDbType.NVarChar).Value = PMTT.ngaymuon;
            cmd.Parameters.Add("@NgayHentra", SqlDbType.NVarChar).Value = PMTT.ngayhentra;
            cmd.Parameters.Add("@SoLuongMuon", SqlDbType.Int).Value = PMTT.soluongmuon;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tao phieu muon thanh cong, vui long cho thu thu xac nhan.", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Them That bai: " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }
        //Biểu đồ 
        public static void BieuDoLuotXem(string query, Chart chr, string X, string Y)
        {
          
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            adt.Fill(dt);
            
            chr.DataSource = dt;
            chr.Series["Số lượng"].XValueMember = X;
            chr.Series["Số lượng"].YValueMembers = Y;
            chr.Titles.Add("Biểu đồ lượt mượn sách");
            chr.Series[0].ChartType = SeriesChartType.Column;
            
            con.Close();

        }
        // Thêm NXB LS NN
        public static void THemMoi_UpDateNSBLSNN(string query, string Ten, string tb)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = Ten;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(tb , "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Hanh dong that bai " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }


        public static void Xoa_NXBLSNN(string query,  string tb)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(tb, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Hanh dong that bai " + ex.Message + "Thong Bao" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
        }

        // Tạo report

        public static void ReportBaocao(string query, ReportViewer rp )
        {
            
        }

    }




   
   

}
