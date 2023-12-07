using FPTUniversityLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTUniversityWinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using Prn211Context context = new Prn211Context();
            List<Doctor> doctors = context.Doctors.Include(d => d.Specialization).ToList();
            LoadForm(doctors);
            txtDoctorId.Enabled = false;
        }

        private void LoadForm(List<Doctor> doctorsAsList)
        {
            try
            {
                using Prn211Context context = new Prn211Context();
                IEnumerable<Doctor> doctors = doctorsAsList;

                txtDoctorId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                cboSpecialization.DataBindings.Clear();
                txtAddress.DataBindings.Clear();


                txtDoctorId.DataBindings.Add("Text", doctors, "DoctorId");
                txtName.DataBindings.Add("Text", doctors, "DoctorName");

                Doctor doctor = context.Doctors.FirstOrDefault(d => d.DoctorId == int.Parse(txtDoctorId.Text));
                Specialization specialization = context.Specializations.First(s => s.SpecializationId == doctor.SpecializationId);

                cboSpecialization.DataBindings.Add("Text", specialization, "SpecializationName");
                txtAddress.DataBindings.Add("Text", doctors, "Address");

                dgvDoctorList.DataSource = null;
                dgvDoctorList.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load the form");
            }
        }

        private void ClearAll()
        {
            txtDoctorId.Text = string.Empty;
            txtName.Text = string.Empty;
            cboSpecialization.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddOrUpload formAddOrUpload= new FormAddOrUpload
                {
                    IsInsert = true
                };
                formAddOrUpload.ShowDialog();
                using Prn211Context context = new Prn211Context();
                List<Doctor> doctors = context.Doctors.Include(d => d.Specialization).ToList();
                LoadForm(doctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert doctor");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using Prn211Context context = new Prn211Context();
                Specialization specialization = context.Specializations.FirstOrDefault(s => s.SpecializationName.Equals(cboSpecialization.Text));

                FormAddOrUpload formAddOrUpload = new FormAddOrUpload
                {
                    Doctor = new Doctor
                    {
                        DoctorId = int.Parse(txtDoctorId.Text),
                        DoctorName = txtName.Text,
                        Address = txtAddress.Text,
                        SpecializationId = specialization.SpecializationId,
                        Specialization = specialization
                    },
                    IsInsert = false
                };
                formAddOrUpload.ShowDialog();
                List<Doctor> doctors = context.Doctors.Include(d => d.Specialization).ToList();
                LoadForm(doctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update doctor");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using Prn211Context context = new Prn211Context();
                Doctor doctor = context.Doctors.FirstOrDefault(d => d.DoctorId == int.Parse(txtDoctorId.Text));
                
                context.Doctors.Remove(doctor);
                context.SaveChanges();
                List<Doctor> doctors = context.Doctors.ToList();
                LoadForm(doctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete doctor");
            }
        }
    }
}
