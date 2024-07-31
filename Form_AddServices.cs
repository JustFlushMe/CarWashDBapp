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
    public partial class Form_AddServices : Form
    {
        public Form_AddServices()
        {
            InitializeComponent();
            
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;

            // СДЕЛАТЬ ПРОВЕРКУ НА ЦИФРЫ
            string price = tb_price.Text;

            Form1.query = $"INSERT INTO Services(sv_name, sv_price) VALUES(\"{name}\", \"{price}\")";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }

       
    }
    }

