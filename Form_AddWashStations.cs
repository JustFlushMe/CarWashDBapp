using System;
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
    public partial class Form_AddWashStations : Form
    {
        public Form_AddWashStations()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbox_status.Text);

            string num = tb_num.Text;
            string status = cmbox_status.Text;
            string desc = tb_statusdesc.Text;

            Form1.query = $"INSERT INTO WashStations(ws_num, ws_status, ws_statusDesc) VALUES(\"{num}\", \"{status}\", \"{desc}\")";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }


    }
    }

