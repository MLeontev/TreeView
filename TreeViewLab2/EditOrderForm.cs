using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewLab2
{
    public partial class EditOrderForm : Form
    {
        public EditOrderForm()
        {
            InitializeComponent();
        }

        public DateTime OrderDate
        {
            get { return dtpOrderDate.Value; }
            set { dtpOrderDate.Value = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
