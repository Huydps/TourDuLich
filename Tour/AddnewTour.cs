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
    public partial class AddnewTour : Form
    {
        QuanLyTour tourController = new QuanLyTour();
        public AddnewTour()
        {
            InitializeComponent();
            loadDoanDL();
            loadLoaiHinh();
            loadGiatour();
        }

        private void AddnewTour_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            TOURDULICH tour = new TOURDULICH();
            tour.MaTour = txtMaTour.Text;
            tour.TenTour = txtTenTour.Text;
            tour.MaDiaDiem = txtDiaDiem.Text;
            tour.MaDOANDL = cbx_doanDL.Text;
            tour.IDGiaTour = cbx_GiaTour.Text;
            tour.MaLoaiHinh = cbx_MaLH.Text;
            tour.DacDiem = txtDacDiem.Text;

            if (tourController.addTour(tour))
            {
                MessageBox.Show("Successfully Added!");
            }
            else MessageBox.Show("Failed to add new tour");
            
        }

        private void loadDoanDL()
        {
            List<DOANDL> doanDL = tourController.getDoanDL();
            cbx_doanDL.DataSource = doanDL;
            cbx_doanDL.DisplayMember = "MaDOANDL";
        }
        private void loadLoaiHinh()
        {
            List<LOAIHINHDULICH> LoaiHinh = tourController.getMaLH();
            cbx_MaLH.DataSource = LoaiHinh;
            cbx_MaLH.DisplayMember = "MaLoaiHinh";
        }
        private void loadGiatour()
        {
            List<GIATOUR> Giatour = tourController.getGiaTour();
            cbx_GiaTour.DataSource = Giatour;
            cbx_GiaTour.DisplayMember = "IDGIATOUR";
        }


    }
}
