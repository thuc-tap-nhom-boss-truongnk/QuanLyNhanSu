using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ManageStaffServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //1. nhan vien
        [OperationContract]
        DataSet ShowNhanVien();

        [OperationContract]
        string AddNhanVien(NhanVien nv);

        [OperationContract]
        bool DeleteNhanVien(NhanVien nv);

        [OperationContract]
        void UpdateNhanVien(NhanVien nv);

        //2. phong ban
        [OperationContract]
        DataSet ShowPhongBan();

        [OperationContract]
        string AddPhongBan(PhongBan pb);

        [OperationContract]
        bool DeletePhongBan(PhongBan pb);

        [OperationContract]
        void UpdatePhongBan(PhongBan pb);

        //3. chuc vu
        [OperationContract]
        DataSet ShowChucVu();

        [OperationContract]
        string AddChucVu(ChucVu cv);

        [OperationContract]
        bool DeleteChucVu(ChucVu cv);

        [OperationContract]
        void UpdateChucVu(ChucVu cv);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

    //1. nhan vien
    [DataContract]
    public class NhanVien
    {
        int id;
        string name;
        DateTime dob;
        string gender;
        string phone;
        string address;
        string cmt;
        string level;
        int idcv;
        int idpb;

        [DataMember]
        public int NVid
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string NVname
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public DateTime NVdob
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public string NVgender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        public string NVphone
        {
            get { return phone; }
            set { phone = value; }
        }

        [DataMember]
        public string NVaddress
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public string NVcmt
        {
            get { return cmt; }
            set { cmt = value; }
        }

        [DataMember]
        public string NVlevel
        {
            get { return level; }
            set { level = value; }
        }

        [DataMember]
        public int NVidcv
        {
            get { return idcv; }
            set { idcv = value; }
        }

        [DataMember]
        public int NVidpb
        {
            get { return idpb; }
            set { idpb = value; }
        }
    }

    //2. phong ban
    [DataContract]
    public class PhongBan
    {
        int id;
        string name;

        [DataMember]
        public int PBid
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string PBname
        {
            get { return name; }
            set { name = value; }
        }
    }

    //3. chuc vu
    [DataContract]
    public class ChucVu
    {
        int id;
        string name;

        [DataMember]
        public int CVid
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string CVname
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class thoigian
    {
        int id;
        int days;
        int months;
        int years;

        public int Id { get => id; set => id = value; }
        public int Days { get => days; set => days = value; }
        public int Months { get => months; set => months = value; }
        public int Years { get => years; set => years = value; }
    }

    public class chamcong
    {
        int id;
        int idnv;
        int idtg;
        int tongngay;

        public int Id { get => id; set => id = value; }
        public int Idnv { get => idnv; set => idnv = value; }
        public int Idtg { get => idtg; set => idtg = value; }
        public int Tongngay { get => tongngay; set => tongngay = value; }
    }
}
