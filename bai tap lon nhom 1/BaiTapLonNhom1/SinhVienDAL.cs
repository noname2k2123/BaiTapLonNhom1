using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonNhom1
{
    class SinhVienDAL
    {
        Dataketnoi a;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SinhVienDAL()
        {
            a = new Dataketnoi();

        }
        public DataTable getAllSinhVien()
        {
            string sql = "SELECT *FROM tblSinhVien ";
            SqlConnection con = a.getketnoi();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public bool Insert(tblSinhVien sv)
        {
            string sql = "INSERT INTO tblSinhVien(MaSV, TenSV, Lop, Diachi, Toan, Anh, Van) VALUES(@MaSV, @TenSV, @Lop, @Diachi, @Toan, @Anh, @Van)";
            SqlConnection con = a.getketnoi();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = sv.Lop;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = sv.Diachi;
                cmd.Parameters.Add("@Toan", SqlDbType.Float).Value = sv.Toan;
                cmd.Parameters.Add("@Anh", SqlDbType.Float).Value = sv.Anh;
                cmd.Parameters.Add("@Van", SqlDbType.Float).Value = sv.Van;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool update(tblSinhVien sv)
        {
            string sql = "UPDATE tblSinhVien SET MaSV = @MaSV,TenSV = @TenSV,lop = @Lop, Diachi =@Diachi, Toan = @Toan,Anh = @Anh,Van = @Van WHERE id = @id";
            SqlConnection con = a.getketnoi();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sv.ID;
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = sv.Lop;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = sv.Diachi;
                cmd.Parameters.Add("@Toan", SqlDbType.Float).Value = sv.Toan;
                cmd.Parameters.Add("@Anh", SqlDbType.Float).Value = sv.Anh;
                cmd.Parameters.Add("@Van", SqlDbType.Float).Value = sv.Van;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool delete(tblSinhVien sv)
        {
            string sql = "DELETE FROM tblSinhVien WHERE id = @id";
            SqlConnection con = a.getketnoi();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sv.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }
        public DataTable timkiem(string sv)
        {
            string sql = "SELECT *FROM tblSinhVien WHERE TenSV like N'%" + sv + " %'OR Lop like N'%" + sv + "%'";
            SqlConnection con = a.getketnoi();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
