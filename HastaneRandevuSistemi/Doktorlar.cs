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
        private BindingList<Doctor> _doctors = new BindingList<Doctor>();
        private AnaForm _form;
        int rowIndex = 0;
        public Doktorlar(List<Doctor> doctors, AnaForm form)
        {
            _form = form;
            foreach (var doctor in doctors)
            {
                _doctors.Add(doctor);
            }
            InitializeComponent();
            dgvDoktorlar.DataSource = _doctors.ToList();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            dgvDoktorlar.DataSource = _doctors.ToList();
            cbxBolum.SelectedIndex = 0;
            cbxUzmanlik.SelectedIndex = 0;
            _doctors.ListChanged += _doctors_ListChanged;

        }

        private void _doctors_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvDoktorlar.DataSource = _doctors.ToList();


        }

        private void tbxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Kayıt Et")
            {
                Doctor doctor = new Doctor
                {
                    Id = _doctors.Count <= 0 ? 1 : _doctors.Last().Id + 1,
                    Name = tbxAd.Text,
                    Title = tbxUnvan.Text.Trim() + " ",
                    DepartmentId = cbxBolum.SelectedIndex,
                    Profession = cbxUzmanlik.SelectedItem.ToString(),
                };
                _doctors.Add(doctor);
            }
            else if (btnEkle.Text == "Düzenle")
            {
                Doctor doctor = _doctors.FirstOrDefault(x => x.Id == Convert.ToInt32(btnEkle.Tag));
                doctor.Name = tbxAd.Text;
                doctor.Title = tbxUnvan.Text.Trim() + " ";
                doctor.DepartmentId = cbxBolum.SelectedIndex;
                doctor.Profession = cbxUzmanlik.SelectedItem.ToString();

                dgvDoktorlar.DataSource = _doctors.ToList();

                btnEkle.Text = "Kayıt Et";
                tbxAd.Text = "";
                tbxUnvan.Text = "";
                cbxBolum.SelectedIndex = 0;
                cbxUzmanlik.SelectedIndex = 0;
            }
        }

        private void dgvDoktorlar_CellMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.AddRange(new MenuItem[] { new MenuItem("Sil"), new MenuItem("Düzenle") });

                rowIndex = dgvDoktorlar.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dgvDoktorlar.Rows[rowIndex].Selected = true;
                    menu.Show(dgvDoktorlar, new Point(e.X, e.Y));
                }

                menu.MenuItems[0].Click += Sil_Click;
                menu.MenuItems[1].Click += Duzenle_Click;
            }
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDoktorlar.Rows[rowIndex].Cells[3].Value);
            Doctor doctor = _doctors.FirstOrDefault(x => x.Id == id);
            _doctors.Remove(doctor);
        }

        private void Duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDoktorlar.Rows[rowIndex].Cells[3].Value);
            Doctor doctor = _doctors.FirstOrDefault(x => x.Id == id);

            tbxAd.Text = doctor.Name;
            tbxUnvan.Text = doctor.Title;
            cbxBolum.SelectedIndex = doctor.DepartmentId;
            cbxUzmanlik.SelectedItem = doctor.Profession;

            btnEkle.Text = "Düzenle";
            btnEkle.Tag = doctor.Id;
        }

        private void Doktorlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.ListeyiGuncelle(_doctors.ToArray());

        }
    }
}
