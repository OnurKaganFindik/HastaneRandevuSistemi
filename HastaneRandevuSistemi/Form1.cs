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
        public void ListeyiGuncelle(object[] liste)
        {
            if (liste.Length > 0)
            {
                Type type = liste[0].GetType();
                if (type == typeof(Patient))
                {
                    patients = liste.Select(x => (Patient)x).ToList();
                    cbxHasta.Items.Clear();
                }
                if (type == typeof(Doctor))
                {
                    doctors = liste.Select(x => (Doctor)x).ToList();
                }
            }
            else
            {
                string type = liste.GetType().Name.Substring(0, liste.GetType().Name.Length - 2);

                if (type == "Patient")
                {
                    cbxHasta.Items.Clear();
                    patients.Clear();
                }
                if (type == "Doctor")
                {
                    cbxDoktor.Items.Clear();
                    doctors.Clear();
                }
            }

            FillComboBoxes();
        }

        private void FillComboBoxes()
        {

            cbxHasta.Items.Clear();
            cbxDoktor.Items.Clear();

            foreach (var patient in patients)
            {
                cbxHasta.Items.Add(patient);
            }

            foreach (var doctor in doctors)
            {
                cbxDoktor.Items.Add(doctor);
            }

            if (cbxHasta.Items.Count > 0)
            {
                cbxHasta.SelectedIndex = 0;
            }

            if (cbxDoktor.Items.Count > 0)
            {
                cbxDoktor.SelectedIndex = 0;
            }
        }

        private void tsmiDoktorlar_Click(object sender, EventArgs e)
        {
            Doktorlar doktorlar = new Doktorlar(doctors,this);
            doktorlar.ShowDialog();
        }

        private void tsmiHastalar_Click(object sender, EventArgs e)
        {
            Hastalar hastalar = new Hastalar(patients, this);
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
            //appointments.ListChanged += Appointments_ListChanged;

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
        private void Appointments_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvRandevu.Rows.Clear();

            foreach (var appointment in appointments)
            {
                dgvRandevu.Rows.Add(appointment.Id, appointment.Description, appointment.Notes, appointment.Doctor.Profession, appointment.Doctor.Name, appointment.Doctor.Title, appointment.Patient.Name, appointment.Patient.Gender, appointment.AppointmentDate);
            }
        }

        private void dgvRandevu_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRandevu.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRandevu.SelectedRows[0].Cells[0].Value);
                Appointment appointment = appointments.FirstOrDefault(x => x.Id == id);
                appointments.Remove(appointment);
            }
        }
    }
}
