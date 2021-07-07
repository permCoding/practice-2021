using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practice
{
    public partial class FormAutho : Form
    {
        public FormAutho()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAutho_Click(object sender, EventArgs e)
        {
            // SELECT ищите пользователя

            int id = 66;

            Form4 form4 = new Form4(id);
            form4.Show();
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
