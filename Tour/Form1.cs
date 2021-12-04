using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Controllers;

namespace Tour
{
    public partial class Form1 : Form
    {
        QuanLyTour tourController = new QuanLyTour();
        public Form1()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnModify.Enabled = false;
            btnDetail.Enabled = false;
            btnXoaDoanDL.Enabled = false;
            btnSuaDoanDL.Enabled = false;
            this.dtgvTour.Columns["colChiTiet"].Visible = false;
        }
        
        TOURDULICH tour = new TOURDULICH();
        

        private void btnView_Click(object sender, EventArgs e)
        {
            dtgvTour.DataSource =tourController.LoadTour() ;
            
        }

        private void dtgvTour_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgvTour.Rows[ index];
            txtMaTour.Text = selectedRow.Cells[0].Value.ToString();
            txtTenTour.Text = selectedRow.Cells[1].Value.ToString();
            txtDacDiem.Text = selectedRow.Cells[2].Value.ToString();
            txtGiaTour.Text = selectedRow.Cells[3].Value.ToString();
            txtMaDoan.Text = selectedRow.Cells[4].Value.ToString();
            txtLoaiHinh.Text = selectedRow.Cells[5].Value.ToString();
            txtDiaDiem.Text = selectedRow.Cells[6].Value.ToString();
            btnDelete.Enabled = true;
            btnModify.Enabled = true;
            txtMaTour.Enabled = false;
            btnDetail.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            AddnewTour child = new AddnewTour();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.Show();
            dtgvTour.DataSource = tourController.LoadTour();
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
             dtgvTour.DataSource =tourController.LoadTour() ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Tour này ?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                tourController.deleteTour(txtMaTour.Text);
            MessageBox.Show("Xóa thành công");
           dtgvTour.DataSource = tourController.LoadTour();

        }
       
        private void btnModify_Click(object sender, EventArgs e)
        {
            if(dtgvTour.CurrentRow.Index != -1)
            {
                // TOURDULICH.EditData(txtMaTour.Text, txtTenTour.Text, txtDacDiem.Text, txtGiaTour.Text, txtMaDoan.Text, txtLoaiHinh.Text, txtDiaDiem.Text);
                dtgvTour.DataSource = tourController.LoadTour();

            }
            
            
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailForm detail = new DetailForm(txtMaTour.Text);
            detail.Show();
        }

        private void btnLoadDoanDL_Click(object sender, EventArgs e)
        {
            dtgvDoanDL.DataSource = DOANDL.LoadDataDoanDL();
        }

        private void dtgvDoanDL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgvDoanDL.Rows[index];
            txtMaDoanDL.Text = selectedRow.Cells[0].Value.ToString();
            txtNgayKhoiHanh.Text = selectedRow.Cells[1].Value.ToString();
            txtNgayKetThuc.Text = selectedRow.Cells[2].Value.ToString();
            txtMaKH.Text = selectedRow.Cells[3].Value.ToString();
            txtMaNv.Text = selectedRow.Cells[4].Value.ToString();
            txtMaTourDoanDL.Text = selectedRow.Cells[5].Value.ToString();
            btnXoaDoanDL.Enabled = true;
            btnSuaDoanDL.Enabled = true;
        }
    }
}
