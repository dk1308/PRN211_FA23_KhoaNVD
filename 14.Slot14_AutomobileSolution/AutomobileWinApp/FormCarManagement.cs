using AutomibileLibrary.BusinessObject;
using AutomibileLibrary.Repository;
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
    public partial class FormCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        BindingSource binding = new BindingSource();

        public FormCarManagement()
        {
            InitializeComponent();
        }

        private void FormCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvCarList.CellDoubleClick += dgvCarList_ClickDoubleCell;

        }

        public Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleasedYear = int.Parse(txtReleaseYear.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car object");
            }
            return car;
        }

        public void ClearAll()
        {
            txtCarID.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        public void LoadCarList()
        {
            var cars = carRepository.GetCars();
            binding.DataSource = cars;

            txtCarID.DataBindings.Clear();
            txtCarName.DataBindings.Clear();
            txtManufacturer.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtReleaseYear.DataBindings.Clear();

            txtCarID.DataBindings.Add("Text", binding, "CarID");
            txtCarName.DataBindings.Add("Text", binding, "CarName");
            txtManufacturer.DataBindings.Add("Text", binding, "Manufacturer");
            txtPrice.DataBindings.Add("Text", binding, "Price");
            txtReleaseYear.DataBindings.Add("Text", binding, "ReleasedYear");

            dgvCarList.DataSource = null;
            dgvCarList.DataSource = binding;

            if (binding.Count == 0)
            {
                ClearAll();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FormCarDetails formCarDetails = new FormCarDetails
                {
                    Text = "Insert car",
                    CarRepository = carRepository,
                    InsertOrUpdate = true
                };
                formCarDetails.ShowDialog();
                LoadCarList();
                binding.Position = binding.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert new car");
            }

        }

        private void dgvCarList_ClickDoubleCell(object sender, DataGridViewCellEventArgs e)
        {
            FormCarDetails formCarDetails = new FormCarDetails
            {
                Text = "Update car",
                CarRepository = carRepository,
                CarInfo = GetCarObject(),
                InsertOrUpdate = false
            };
            formCarDetails.ShowDialog();
            LoadCarList();
            binding.Position = binding.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete car");
            }
        }

        private void dgvCarList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

