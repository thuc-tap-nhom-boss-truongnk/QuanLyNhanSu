using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFQLNV
{
    public partial class Frm_nhanvien : Form
    {
        ServiceManageStaff.Service1Client obj = new ServiceManageStaff.Service1Client();
        public Frm_nhanvien()
        {
            InitializeComponent();
            ShowNhanVien();
        }

        void ShowNhanVien()
        {
            DataSet ds = new DataSet();
            ds = obj.ShowNhanVien();
            DGV_nhanvien.DataSource = ds.Tables[0];

            DataSet dspb = new DataSet();
            dspb = obj.ShowPhongBan();
            cbb_phongban.DataSource = dspb.Tables[0];
            cbb_phongban.DisplayMember = dspb.Tables[0].Columns[1].ToString();
            cbb_phongban.ValueMember = dspb.Tables[0].Columns[0].ToString();
            DGV_nhanvien.Columns["id2"].Visible = false;

            DataSet dscv = new DataSet();
            dscv = obj.ShowChucVu();
            cbb_chucvu.DataSource = dscv.Tables[0];
            cbb_chucvu.DisplayMember = dscv.Tables[0].Columns[1].ToString();
            cbb_chucvu.ValueMember = dscv.Tables[0].Columns[0].ToString();
            DGV_nhanvien.Columns["id1"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.NhanVien nv = new ServiceManageStaff.NhanVien();
            nv.NVname = txt_name.Text;
            nv.NVdob = DateTime.Parse(DTP_dob.Text);
            if(rad_nam.Checked==true)
            {
                nv.NVgender = "Nam";
            }
            if (rad_nu.Checked == true)
            {
                nv.NVgender = "Nữ";
            }

            nv.NVphone = txt_phone.Text;
            nv.NVaddress = txt_address.Text;
            nv.NVcmt = txt_cmt.Text;
            nv.NVlevel = txt_level.Text;
            nv.NVidcv = int.Parse(cbb_chucvu.SelectedValue.ToString());
            nv.NVidpb = int.Parse(cbb_phongban.SelectedValue.ToString());
            obj.AddNhanVien(nv);
            ShowNhanVien();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.NhanVien nv = new ServiceManageStaff.NhanVien();
            nv.NVid = (int)DGV_nhanvien.CurrentRow.Cells["id"].Value;
            nv.NVname = txt_name.Text;
            nv.NVdob = DateTime.Parse(DTP_dob.Text);
            if (rad_nam.Checked == true)
            {
                nv.NVgender = "Nam";
            }
            if (rad_nu.Checked == true)
            {
                nv.NVgender = "Nữ";
            }
           
            nv.NVphone = txt_phone.Text;
            nv.NVaddress = txt_address.Text;
            nv.NVcmt = txt_cmt.Text;
            nv.NVlevel = txt_level.Text;
            nv.NVidcv = int.Parse(cbb_chucvu.SelectedValue.ToString());
            nv.NVidpb = int.Parse(cbb_phongban.SelectedValue.ToString());
            obj.UpdateNhanVien(nv);
            ShowNhanVien();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.NhanVien nv = new ServiceManageStaff.NhanVien();
            nv.NVid = (int)DGV_nhanvien.CurrentRow.Cells["id"].Value;
            obj.DeleteNhanVien(nv);
            ShowNhanVien();
        }

        private void DGV_nhanvien_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modify.Enabled = true;
            btn_delete.Enabled = true;
            if(e.RowIndex >= 0 && e.ColumnIndex >=0)
            {
                txt_name.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["name"].Value);
                DTP_dob.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["birth"].Value);
                txt_phone.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["phone"].Value);
                txt_address.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["address"].Value);
                txt_cmt.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["cmt"].Value);
                txt_level.Text = Convert.ToString(DGV_nhanvien.CurrentRow.Cells["level"].Value);
                if ((Convert.ToString(DGV_nhanvien.CurrentRow.Cells["gender"].Value))=="Nam")
                {
                    rad_nam.Checked = true;
                }
                if ((Convert.ToString(DGV_nhanvien.CurrentRow.Cells["gender"].Value))=="Nữ")
                {
                    rad_nu.Checked = true;
                }
               
               cbb_chucvu.SelectedValue = Convert.ToInt32(DGV_nhanvien.CurrentRow.Cells["id1"].Value);
               cbb_phongban.SelectedValue = Convert.ToInt32(DGV_nhanvien.CurrentRow.Cells["id2"].Value);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
