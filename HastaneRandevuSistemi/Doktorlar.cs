using HastaneRandevuSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class Doktorlar : Form
    {
        private List<Doctor> _doctors;
        public Doktorlar(List<Doctor> doctors)
        {
            _doctors = doctors;
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            dgvDoktorlar.DataSource = _doctors.ToList();
            cbxBolum.SelectedIndex = 0;
            cbxUzmanlik.SelectedIndex = 0;

        }

        private void tbxAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
