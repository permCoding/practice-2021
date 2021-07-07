using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form4 : Form
    {
        int idUser = 0;
        public Form4(int _idUser)
        {
            InitializeComponent();
            idUser = _idUser;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = idUser.ToString();
        }
    }
}
