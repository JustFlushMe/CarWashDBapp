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
    public partial class Form_AddBonusProg : Form
    {
        public Form_AddBonusProg()
        {
            InitializeComponent();

        }

        private void bt_add_Click(object sender, EventArgs e)
        {


            string name = tb_name.Text;
            string cat = cmbox_cat.Text;

            // ФОРМАТ НОМЕРА ЛИБО ПРОВЕРКА НА ЦИФРЫ
            string phone = tb_phone.Text;

            Form1.query = $"INSERT INTO BonusProg(bp_cat, bp_clName, bp_clPhone) VALUES(\"{name}\", \"{cat}\", \"{phone}\")";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

