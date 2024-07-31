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
    public partial class Form_Addrentserv : Form
    {
        public Form_Addrentserv()
        {
            InitializeComponent();

            Form1.query = "SELECT rnt_id FROM Rents";
            int i = cmbox_rent.Items.Count;

            OleDbCommand SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                cmbox_rent.Items.Add(dbReader["rnt_id"].ToString());
            }
            dbReader.Close();


            Form1.query = "SELECT sv_id FROM Services";
            SELECT = new OleDbCommand(Form1.query, Form1.myconnection);
            dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                cmbox_service.Items.Add(dbReader["sv_id"].ToString());
            }


        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // АВТОМАТИЧЕСКОЕ ВЫЧИСЛЕНИЕ СУММЫ БЕЗ УЧАСТИЯ ПОЛЬЗОВАТЕЛЯ

            string rent = cmbox_rent.Text;
            string service = cmbox_service.Text;
            string sum = tb_sum.Text;
            string minutes = numMin.Value.ToString();

            Form1.query = $"INSERT INTO rent_serv(rs_rent, rs_service, rs_minutes, rs_sum) VALUES({rent}, {service}, {minutes}, {sum})";

            OleDbCommand INSERT = new OleDbCommand(Form1.query, Form1.myconnection);

            OleDbDataReader dbReader = INSERT.ExecuteReader();
        }


    }
    }

