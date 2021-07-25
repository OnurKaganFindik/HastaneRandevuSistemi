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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void tsmiRandevular_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            randevular.ShowDialog();
        }

        private void tsmiDoktorlar_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar();
            doktorlar.ShowDialog();
        }

        private void tsmiHastalar_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.ShowDialog();
        }
    }
}
