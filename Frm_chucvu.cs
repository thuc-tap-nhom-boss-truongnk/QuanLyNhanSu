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
    public partial class Frm_chucvu : Form
    {
        ServiceManageStaff.Service1Client obj = new ServiceManageStaff.Service1Client();

        public Frm_chucvu()
        {
            InitializeComponent();
             showCV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.ChucVu cv = new ServiceManageStaff.ChucVu();
            cv.CVname = txt_TenCV.Text;
            obj.AddChucVu(cv);
            showCV();
        }

        void showCV()
        {
            DataSet ds = new DataSet();
            ds = obj.ShowChucVu();
            DGV_chucvu.DataSource = ds.Tables[0];

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.ChucVu cv = new ServiceManageStaff.ChucVu();
            cv.CVid = (int)DGV_chucvu.CurrentRow.Cells["maCv"].Value;
            cv.CVname = txt_TenCV.Text;
            obj.UpdateChucVu(cv);
            showCV();
            btn_Sua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.ChucVu cv = new ServiceManageStaff.ChucVu();
            cv.CVid = (int)DGV_chucvu.CurrentRow.Cells["maCv"].Value;
            obj.DeleteChucVu(cv);
            btn_Xoa.Enabled = false;
            showCV();       
        }

        private void DGV_LoaiThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txt_TenCV.Text = Convert.ToString(DGV_chucvu.CurrentRow.Cells["name"].Value);       
            }
        }
    }
    
}
