﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WASH_SOME
{
    public partial class Form_AddDelivery : Form
    {
        public Form_AddDelivery()
        {
            InitializeComponent();

            


        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString();
            string details = tb_details.Text;
            string status = cmbox_cat.Text;
            

            Form1.query = $"INSERT INTO Delivery(dl_date, dl_desc, dl_status) VALUES(\"{date}\", \"{details}\", \"{status}\")";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

