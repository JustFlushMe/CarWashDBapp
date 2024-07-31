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
    public partial class Form_Addeq_ws : Form
    {
        public Form_Addeq_ws()
        {
            InitializeComponent();

            Form1.query = "SELECT ws_id FROM WashStations";
            int i = cmbox_ws.Items.Count;

            OleDbCommand SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            

            while (dbReader.Read())
            {
                cmbox_ws.Items.Add(dbReader["ws_id"].ToString());
            }
            dbReader.Close();

            Form1.query = "SELECT eq_id FROM Equipments";
            SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                cmbox_eq.Items.Add(dbReader["eq_id"].ToString());
            }


        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbox_ws.Text);

            string washst = cmbox_ws.Text;
            string eq = cmbox_eq.Text;
            string count = num_count.Value.ToString();

            Form1.query = $"INSERT INTO eq_ws(eqws_equipment, eqws_washstation, eqws_count) VALUES(\"{eq}\", \"{washst}\", {count})";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

