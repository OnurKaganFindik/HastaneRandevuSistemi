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
    public partial class AnaForm : Form
    {
        List<Appointment> appointments = new List<Appointment>();
        List<Doctor> doctors = new List<Doctor>();
        List<Patient> patients = new List<Patient>();
        public AnaForm()
        {
            InitializeComponent();
        }


        private void tsmiDoktorlar_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar(doctors);
            doktorlar.ShowDialog();
        }

        private void tsmiHastalar_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar();
            hastalar.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            dgvRandevu.Columns.Add("Id", "Id");
            dgvRandevu.Columns.Add("Description", "Tanım");
            dgvRandevu.Columns.Add("Notes", "Not");
            dgvRandevu.Columns.Add("Profession", "Doktor Uzmanlık");
            dgvRandevu.Columns.Add("DoctorName", "Doktor Adı");
            dgvRandevu.Columns.Add("DoctorTitle", "Doktor Unvanı");
            dgvRandevu.Columns.Add("PatientName", "Hasta Adı");
            dgvRandevu.Columns.Add("PatientGender", "Hasta Cinsiyeti");
            dgvRandevu.Columns.Add("AppointmentDate", "Randevu Tarihi");

            dgvRandevu.Columns[0].Visible = false;

            doctors.AddRange(new Doctor[]
            {
                new Doctor { DepartmentId = 1, Id = 1, Name = "Gul", Profession = "Kardiyoloji", Title = "Dr. "},
                new Doctor { DepartmentId = 2, Id = 2, Name = "Ahmet", Profession = "Kalp-Damar", Title = "Prof. "},
                new Doctor { DepartmentId = 3, Id = 3, Name = "Murat", Profession = "Fizyoloji", Title = "Doc. "}
            });

            cbxDoktor.DisplayMember = "Name";
            cbxHasta.DisplayMember = "Name";

            if (patients.ToList().Count <= 0)
            {
                cbxHasta.Items.Clear();
                cbxHasta.Items.Add("Kayıt bulunamadı");
                cbxHasta.SelectedIndex = 0;
            }
            else
            {
                foreach (var patient in patients)
                {
                    cbxHasta.Items.Add(patient);
                }
            }

            if (doctors.ToList().Count <= 0)
            {
                cbxDoktor.Items.Clear();
                cbxDoktor.Items.Add("Kayıt bulunamadı");
                cbxDoktor.SelectedIndex = 0;
            }
            else
            {
                cbxDoktor.Items.Clear();
                foreach (var doctor in doctors)
                {
                    cbxDoktor.Items.Add(doctor);
                }
                cbxDoktor.SelectedIndex = 0;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbxHasta.Items[0].ToString() == "Kayıt bulunamadı")
            {
                MessageBox.Show("Kayıtlı hasta bulunamadığı için randevu işlemi gerçekleştirilemez.", "Hastane Randevu Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Appointment appointment = new Appointment()
                {
                    Id = appointments.Count <= 0 ? 1 : appointments.Last().Id + 1,
                    AppointmentDate = dtpRandevuTarihi.Value,
                    Description = tbxTanım.Text,
                    Notes = tbxNot.Text,
                    Doctor = (Doctor)cbxDoktor.SelectedItem,
                    Patient = (Patient)cbxHasta.SelectedItem,
                };

                appointment.DoctorId = appointment.Doctor.Id;
                appointment.PatientId = appointment.Patient.Id;

                appointments.Add(appointment);
            }
        }
    }
}
