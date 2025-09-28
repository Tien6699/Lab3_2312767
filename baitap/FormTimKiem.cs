using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class FormTimKiem : Form
    {
        public string MSSV { get; private set; }
        public string HoTenLot { get; private set; }
        public string Ten { get; private set; }
        public string Lop { get; private set; }


        public FormTimKiem()
        {
            InitializeComponent();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            MSSV = mtxtMaSo.Text;
            HoTenLot = txtHoTenLot.Text;
            Ten = txtTen.Text;
            Lop = cboLop.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
