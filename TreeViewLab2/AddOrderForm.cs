using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeViewLab2
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        public DateTime OrderDate
        {
            get { return dtpOrderDate.Value; }
            set {; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (dtpOrderDate.Value < DateTime.Today)
            {
                errorProvider.SetError(dtpOrderDate, "Дата не может быть раньше текущей даты.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
