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
    public partial class Form_Adddel_eq : Form
    {
        public Form_Adddel_eq()
        {
            InitializeComponent();

            Form1.query = "SELECT dl_id FROM Delivery";
            int i = cmbox_del.Items.Count;

            OleDbCommand SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            

            while (dbReader.Read())
            {
                cmbox_del.Items.Add(dbReader["dl_id"].ToString());
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
            MessageBox.Show(cmbox_del.Text);

            string eq = cmbox_eq.Text;
            string del = cmbox_del.Text;
            string count = num_count.Value.ToString();

            Form1.query = $"INSERT INTO del_eq(de_delivery, de_equipment, de_count) VALUES(\"{del}\", \"{eq}\", {count})";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

