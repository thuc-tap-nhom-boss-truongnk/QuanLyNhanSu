using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ManageStaffServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string strQuery = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Persist Security Info=True;User ID=sa;Password=1234567";

    // 1. nhan vien
        public string AddNhanVien(NhanVien nv)
        {
            string Message;
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into nhanvien(name,birth,gender,phone,address,cmt,level,idcv,idpb) values(@name,@birth,@gender,@phone,@address,@cmt,@level,@idcv,@idpb)", con);
            cmd.Parameters.AddWithValue("@name", nv.NVname);
            cmd.Parameters.AddWithValue("@birth", nv.NVdob);
            cmd.Parameters.AddWithValue("@gender", nv.NVgender);
            cmd.Parameters.AddWithValue("@phone", nv.NVphone);
            cmd.Parameters.AddWithValue("@address", nv.NVaddress);
            cmd.Parameters.AddWithValue("@cmt", nv.NVcmt);
            cmd.Parameters.AddWithValue("@level", nv.NVlevel);
            cmd.Parameters.AddWithValue("@idcv", nv.NVidcv);
            cmd.Parameters.AddWithValue("@idpb", nv.NVidpb);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = nv.NVname + "them thanh cong";
            }
            else
            {
                Message = nv.NVname + "them khong thanh cong";
            }
            con.Close();
            return Message;
        }

        public bool DeleteNhanVien(NhanVien nv)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from nhanvien where id=@id", con);
            cmd.Parameters.AddWithValue("@id", nv.NVid);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataSet ShowNhanVien()
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("select dbo.nhanvien.id, dbo.nhanvien.name, birth, gender,phone,address, cmt,level, dbo.chucvu.id, dbo.chucvu.name, dbo.phongban.id, dbo.phongban.name from dbo.nhanvien, dbo.chucvu,dbo.phongban where chucvu.id=nhanvien.idcv and nhanvien.idpb=phongban.id", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public void UpdateNhanVien(NhanVien nv)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("update  nhanvien set name=@name, birth=@birth, gender=@gender, phone=@phone, address=@address, cmt=@cmt, level=@level, idcv=@idcv, idpb=@idpb where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", nv.NVid);
            cmd.Parameters.AddWithValue("@name", nv.NVname);
            cmd.Parameters.AddWithValue("@birth", nv.NVdob);
            cmd.Parameters.AddWithValue("@gender", nv.NVgender);
            cmd.Parameters.AddWithValue("@phone", nv.NVphone);
            cmd.Parameters.AddWithValue("@address", nv.NVaddress);
            cmd.Parameters.AddWithValue("@cmt", nv.NVcmt);
            cmd.Parameters.AddWithValue("@level", nv.NVlevel);
            cmd.Parameters.AddWithValue("@idcv", nv.NVidcv);
            cmd.Parameters.AddWithValue("@idpb", nv.NVidpb);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // end nhan vien


        // 2. phong ban
        public DataSet ShowPhongBan()
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from phongban", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

       

        public string AddPhongBan(PhongBan pb)
        {
            string Message;
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into phongban(name) values(@name)", con);
            cmd.Parameters.AddWithValue("@name", pb.PBname);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = pb.PBname + "them thanh cong";
            }
            else
            {
                Message =pb.PBname + "them khong thanh cong";
            }
            con.Close();
            return Message;
        }

        public bool DeletePhongBan(PhongBan pb)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from phongban where id=@id", con);
            cmd.Parameters.AddWithValue("@id", pb.PBid);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public void UpdatePhongBan(PhongBan pb)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("update phongban set name=@name where id=@id", con);
            cmd.Parameters.AddWithValue("@id", pb.PBid);
            cmd.Parameters.AddWithValue("@name", pb.PBname);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        // 2. chuc vu
        public DataSet ShowChucVu()
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from chucvu", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public string AddChucVu(ChucVu cv)
        {
            string Message;
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into chucvu (name) values (@name)", con);
            cmd.Parameters.AddWithValue("@name",cv.CVname);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = cv.CVname + "them thanh cong";
            }
            else
            {
                Message = cv.CVname + "them khong thanh cong";
            }
            con.Close();
            return Message;
        }

        public bool DeleteChucVu(ChucVu cv)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from chucvu where id=@id", con);
            cmd.Parameters.AddWithValue("@id",cv.CVid);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public void UpdateChucVu(ChucVu cv)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("update chucvu set name=@name where id=@id", con);
            cmd.Parameters.AddWithValue("@id", cv.CVid);
            cmd.Parameters.AddWithValue("@name", cv.CVname);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet FindChucVu(ChucVu cv)
        {
            SqlConnection con = new SqlConnection(strQuery);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from chucvu where name like N'%@name%'", con);
            cmd.Parameters.AddWithValue("@name", cv.CVname);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
    }
}
