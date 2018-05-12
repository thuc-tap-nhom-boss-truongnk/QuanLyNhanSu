using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFQLNV { 
    public partial class Frm_PhongBan : Form
    {
        ServiceManageStaff.Service1Client obj = new ServiceManageStaff.Service1Client();

        public Frm_PhongBan()
        {
            InitializeComponent();
        showPB();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.PhongBan pb = new ServiceManageStaff.PhongBan();
            pb.PBname = txt_TenPB.Text;
            obj.AddPhongBan(pb);
            showPB();
        }

        void showPB()
        {
            DataSet ds = new DataSet();
            ds = obj.ShowPhongBan();
            DGV_PhongBan.DataSource = ds.Tables[0];

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.PhongBan pb = new ServiceManageStaff.PhongBan();
            pb.PBid = (int)DGV_PhongBan.CurrentRow.Cells["id"].Value;
            pb.PBname = txt_TenPB.Text;
            obj.UpdatePhongBan(pb);
            showPB();
            btn_Sua.Enabled = false;
        }
  
        private void Frm_LoaiThietBi_Load(object sender, EventArgs e)
        {
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            ServiceManageStaff.PhongBan pb = new ServiceManageStaff.PhongBan();
            pb.PBid = (int)DGV_PhongBan.CurrentRow.Cells["id"].Value;
            obj.DeletePhongBan(pb);
            btn_Xoa.Enabled = false;
            showPB();
                       
        }

        private void DGV_LoaiThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                txt_TenPB.Text = Convert.ToString(DGV_PhongBan.CurrentRow.Cells["name"].Value);

               
            }
        }
    }
    
}
