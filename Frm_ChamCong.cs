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
    public partial class Frm_ChamCong : Form
    {
        ServiceManageStaff.Service1Client obj = new ServiceManageStaff.Service1Client();
        public Frm_ChamCong()
        {
            InitializeComponent();
            ShowNhanVien();
            AddThoiGian();
        }
        void ShowNhanVien()
        {
            DataSet ds = new DataSet();
            ds = obj.ShowNhanVienRG();
            dgvNhanVien.DataSource = ds.Tables[0];
        }

        void AddThoiGian()
        {
            ServiceManageStaff.thoigian tg = new ServiceManageStaff.thoigian();
            DateTime date = DateTime.Now;
            tg.Days = date.Day;
            tg.Months = date.Month;
            tg.Years = date.Year;
            obj.addThoiGian(tg);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ChamCong_Load(object sender, EventArgs e)
        {

        }

        private void lbMa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime date = DateTime.Now;
            int days = date.Day;
            int months = date.Month;
            int years = date.Year;
            int id = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["manv"].Value);
                txtNameNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["name"].Value);
                txtBirthNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["birth"].Value);
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["manv"].Value);
            }
            
            if (!obj.checkChamCong(id, days, months, years))
            {
                btnDiemDanh.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            ServiceManageStaff.chamcong cc = new ServiceManageStaff.chamcong();
        }

        private void lbCurrentDate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
