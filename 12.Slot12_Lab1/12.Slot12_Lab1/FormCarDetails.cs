using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class FormCarDetails : Form
    {
        public FormCarDetails()
        {
            InitializeComponent();
        }
        public Car CarInfo { get; set; }
        public ICarRepository CarRepository { get; set; }
        public Boolean InsertOrUpdate { get; set; } // if true => insert, else update

        private void FormCarDetails_Load(object sender, EventArgs e)
        {
            txtCarID.Enabled = InsertOrUpdate;
            if (!InsertOrUpdate)  // update mode
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.CarPrice.ToString();
                txtReleaseYear.Text = CarInfo.CarReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.CarManufacturer;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car newCar = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    CarManufacturer = cboManufacturer.Text,
                    CarPrice = double.Parse(txtPrice.Text),
                    CarReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                
                if (InsertOrUpdate) CarRepository.InsertNewCar(newCar);
                else CarRepository.UpdateCar(newCar);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "loi");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}