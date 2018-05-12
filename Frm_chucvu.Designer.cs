namespace WFQLNV
{
    partial class Frm_chucvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_chucvu = new System.Windows.Forms.DataGridView();
            this.Gpb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.maCv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chucvu)).BeginInit();
            this.Gpb_ThongTin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_chucvu);
            this.groupBox4.Location = new System.Drawing.Point(12, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 220);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Chức Vụ";
            // 
            // DGV_chucvu
            // 
            this.DGV_chucvu.AllowUserToAddRows = false;
            this.DGV_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_chucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCv,
            this.name});
            this.DGV_chucvu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_chucvu.Location = new System.Drawing.Point(3, 19);
            this.DGV_chucvu.Name = "DGV_chucvu";
            this.DGV_chucvu.Size = new System.Drawing.Size(514, 201);
            this.DGV_chucvu.TabIndex = 0;
            this.DGV_chucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LoaiThietBi_CellClick);
            // 
            // Gpb_ThongTin
            // 
            this.Gpb_ThongTin.Controls.Add(this.txt_TenCV);
            this.Gpb_ThongTin.Controls.Add(this.label1);
            this.Gpb_ThongTin.Location = new System.Drawing.Point(12, 33);
            this.Gpb_ThongTin.Name = "Gpb_ThongTin";
            this.Gpb_ThongTin.Size = new System.Drawing.Size(298, 131);
            this.Gpb_ThongTin.TabIndex = 17;
            this.Gpb_ThongTin.TabStop = false;
            this.Gpb_ThongTin.Text = "Thông Tin";
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Location = new System.Drawing.Point(131, 26);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(151, 23);
            this.txt_TenCV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Chức Vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Location = new System.Drawing.Point(7, 49);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Thoat);
            this.groupBox5.Controls.Add(this.btn_Sua);
            this.groupBox5.Controls.Add(this.btn_Xoa);
            this.groupBox5.Controls.Add(this.btn_Them);
            this.groupBox5.Location = new System.Drawing.Point(314, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 131);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(107, 49);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 23);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(107, 18);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(7, 18);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh Sách Chức Vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(143, 355);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(131, 23);
            this.txt_search.TabIndex = 21;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(305, 355);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // maCv
            // 
            this.maCv.DataPropertyName = "id";
            this.maCv.HeaderText = "Mã Chức Vụ";
            this.maCv.Name = "maCv";
            this.maCv.Width = 120;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Chức Vụ";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // Frm_chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(542, 402);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Gpb_ThongTin);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_chucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Vụ";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chucvu)).EndInit();
            this.Gpb_ThongTin.ResumeLayout(false);
            this.Gpb_ThongTin.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_chucvu;
        private System.Windows.Forms.GroupBox Gpb_ThongTin;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}