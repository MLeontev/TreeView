using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeViewLab2
{
    public partial class EditCarForm : Form
    {
        public EditCarForm()
        {
            InitializeComponent();
        }

        public string CarBrand
        {
            get { return tbBrand.Text; }
            set { tbBrand.Text = value; }
        }
        public string CarModel
        {
            get { return tbModel.Text; }
            set { tbModel.Text = value; }
        }

        public string CarPlate
        {
            get { return tbPlate.Text; }
            set { tbPlate.Text = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbBrand.Text))
            {
                errorProvider.SetError(tbBrand, "Введите марку автомобиля.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                errorProvider.SetError(tbModel, "Введите модель автомобиля.");
                return;
            }

            string pattern = @"^[А-Я]\d{3}[А-Я]{2}\d{2,3}$";
            if (!Regex.IsMatch(tbPlate.Text, pattern))
            {
                errorProvider.SetError(tbPlate, "Номер автомобиля должен соответствовать формату: А999АА99(9)");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
