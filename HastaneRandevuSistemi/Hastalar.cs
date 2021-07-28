using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Enum;
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
    public partial class Hastalar : Form
    {
        private BindingList<Patient> _patients = new BindingList<Patient>();
        private int rowIndex = 0;
        private AnaForm _form;
        public Hastalar(List<Patient> patients, AnaForm form)
        {
            _form = form;
            foreach (var patient in patients)
            {
                _patients.Add(patient);
            }
            InitializeComponent();
            dgvHastalar.DataSource = _patients.ToList();
            _patients.ListChanged += _patients_ListChanged;
        }
        private void _patients_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvHastalar.DataSource = _patients.ToList();
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            Patient patient = _patients.FirstOrDefault(x => x.Id == Convert.ToInt32(dgvHastalar.Rows[rowIndex].Cells[1].Value));
            _patients.Remove(patient);
        }
        private void Hastalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.ListeyiGuncelle(_patients.ToArray());

        }
        private void Duzenle_Click(object sender, EventArgs e)
        {
            Patient patient = _patients.FirstOrDefault(x => x.Id == Convert.ToInt32(dgvHastalar.Rows[rowIndex].Cells[1].Value));
            tbxAd.Text = patient.Name;
            cbxCinsiyet.SelectedItem = patient.Gender;


            btnEkle.Text = "Düzenle";
            btnEkle.Tag = patient.Id;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Hasta Ekle")
            {
                Patient patient = new Patient
                {
                    Id = _patients.Count <= 0 ? 1 : _patients.Last().Id + 1,
                    Name = tbxAd.Text,
                    Gender = (Gender)cbxCinsiyet.SelectedIndex
                };

                _patients.Add(patient);
            }
            else if (btnEkle.Text == "Düzenle")
            {
                Patient patient = _patients.FirstOrDefault(x => x.Id == Convert.ToInt32(dgvHastalar.Rows[rowIndex].Cells[1].Value));
                patient.Name = tbxAd.Text;
                patient.Gender = (Gender)cbxCinsiyet.SelectedIndex;

                dgvHastalar.DataSource = _patients.ToList();
                dgvHastalar.Rows[rowIndex].Selected = true;

                btnEkle.Text = "Hasta Ekle";
                tbxAd.Text = "";
                cbxCinsiyet.SelectedIndex = 0;
            }
        }

        private void dgvHastalar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.AddRange(new MenuItem[] { new MenuItem("Sil"), new MenuItem("Düzenle") });

                rowIndex = dgvHastalar.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dgvHastalar.Rows[rowIndex].Selected = true;
                    menu.Show(dgvHastalar, new Point(e.X, e.Y));
                }

                menu.MenuItems[0].Click += Sil_Click;
                menu.MenuItems[1].Click += Duzenle_Click;
            }
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {

        }
    }
}
