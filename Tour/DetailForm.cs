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

namespace Tour
{
    public partial class DetailForm : Form
    {
        string MaTour;
        public DetailForm(string Matour)
        {
            InitializeComponent();
            this.MaTour = Matour;
           dtgvChiTiet.DataSource = CHITIET.LoadDataChiTiet(MaTour);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        //  dtgvChiTiet.DataSource =CHITIET.LoadDataChiTiet(MaTour);
        }

        
    }
}
