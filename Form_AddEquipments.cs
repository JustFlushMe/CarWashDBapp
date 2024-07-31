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
    public partial class Form_AddEquipments : Form
    {
        public Form_AddEquipments()
        {
            InitializeComponent();

        }

        private void bt_add_Click(object sender, EventArgs e)
        {


            string name = tb_name.Text;
            string cat = cmbox_cat.Text;
            string count = num_count.Value.ToString();
            

            Form1.query = $"INSERT INTO Equipments(eq_category, eq_name, eq_count) VALUES(\"{cat}\", \"{name}\", \"{count}\")";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

