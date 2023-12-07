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
    public partial class FormAddOrUpload : Form
    {
        public Boolean IsInsert { get; set; }
        public Doctor Doctor { get; set; }
        public FormAddOrUpload()
        {
            InitializeComponent();
        }

        private void FormAddOrUpload_Load(object sender, EventArgs e)
        {
            if (!IsInsert)
            {
                LoadForm();
                txtDoctorId.Enabled = false;
            }
            else txtDoctorId.Enabled = true;
        }

        private void LoadForm()
        {
            txtDoctorId.Text = Doctor.DoctorId.ToString();
            txtName.Text = Doctor.DoctorName;
            txtAddress.Text = Doctor.Address;
            cboSpecialization.Text = Doctor.Specialization.SpecializationName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using Prn211Context context = new Prn211Context();
                Specialization specialization = context.Specializations.FirstOrDefault(s => s.SpecializationName.Equals(cboSpecialization.Text));
/*                Doctor newDoctor = new Doctor
                {
                    DoctorId = int.Parse(txtDoctorId.Text),
                    DoctorName = txtName.Text,
                    Address = txtAddress.Text,
                    SpecializationId = specialization.SpecializationId
                };*/
                if (!IsInsert)
                {
                    context.Entry<Doctor>(new Doctor
                    {
                        DoctorId = int.Parse(txtDoctorId.Text),
                        DoctorName = txtName.Text,
                        Address = txtAddress.Text,
                        SpecializationId = specialization.SpecializationId
                    }).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    context.Doctors.Add(new Doctor
                    {
                        DoctorName = txtName.Text,
                        Address = txtAddress.Text,
                        SpecializationId = specialization.SpecializationId
                    });
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
