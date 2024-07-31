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
    public partial class Form_AddRents : Form
    {
        public Form_AddRents()
        {
            InitializeComponent();

            Form1.query = "SELECT bp_id FROM BonusProg";
            int i = cmbox_client.Items.Count;

            OleDbCommand SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            

            while (dbReader.Read())
            {
                cmbox_client.Items.Add(dbReader["bp_id"].ToString());
            }
            dbReader.Close();

            Form1.query = "SELECT ws_id FROM WashStations";
            SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                cmbox_wash.Items.Add(dbReader["ws_id"].ToString());
            }


        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbox_client.Text);

            string dtime = dateTimePicker1.Value.ToString();
            string client = cmbox_client.Text;
            string wash = cmbox_wash.Text;
            string sum = tb_sum.Text;
            string card = tb_card.Text;

            Form1.query = $"INSERT INTO Rents(rnt_rgclient, rnt_date, rnt_sum, rnt_card, rnt_washStation) VALUES({client}, \"{dtime}\", {sum}, {card}, {wash})";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

