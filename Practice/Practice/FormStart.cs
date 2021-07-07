﻿using System;
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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
			
        }
		
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStart_Shown(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConn();

            try
            {
                conn.Open();
                this.status1.Text = "Соединение установлено";
            }
            catch (Exception ex)
            {
                this.status1.Text = "Нет соединения";
                MessageBox.Show("Нет соединения с БД\n\r" + ex.ToString());
            }
            finally 
            {
                conn.Close();
            }
        }

        private void CheckConnection(Task obj)
        {
            
        }
    }
}
