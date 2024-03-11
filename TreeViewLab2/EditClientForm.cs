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
    public partial class EditClientForm : Form
    {
        public EditClientForm()
        {
            InitializeComponent();
        }

        public string ClientName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string ClientSurname
        {
            get { return tbSurname.Text; }
            set { tbSurname.Text = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                errorProvider.SetError(tbSurname, "Введите фамилию клиента.");
                return;
            }
            else
            {
                errorProvider.SetError(tbSurname, "");

                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    errorProvider.SetError(tbName, "Введите имя клиента.");
                    return;
                }
                else
                {
                    errorProvider.SetError(tbName, "");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
