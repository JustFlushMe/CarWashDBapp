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
    public partial class Form1 : Form
    {
        public static string dbconnect = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = empty.mdb";
        public static OleDbConnection myconnection;
        public static string query = "";
        public Form1()
        {
            InitializeComponent();
            dtgrid_main.ReadOnly = true;
            myconnection = new OleDbConnection(dbconnect);
            myconnection.Open();
        }
        
        private void dtgridClear() { dtgrid_main.ColumnCount = 0; }

        private void pn_Clear()
        {
            pn_Rents.Visible = false;
            pn_Services.Visible = false;
            pn_rent_serv.Visible = false;
            pn_BonusProg.Visible = false;
            pn_WashStations.Visible = false;
            pn_Equipments.Visible = false;
            pn_Delivery.Visible = false;
            pn_eqws.Visible = false;
            pn_del_eq.Visible = false;
            
        }

        // dtgridFill
        private void dtgridRentsFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 6;

            dtgrid_main.Columns[0].Name = "rnt_id";
            dtgrid_main.Columns[0].Width = 60;

            dtgrid_main.Columns[1].Name = "rnt_date";

            dtgrid_main.Columns[2].Name = "rnt_rgclient";
            dtgrid_main.Columns[2].Width = 60;

            dtgrid_main.Columns[3].Name = "rnt_sum";
            dtgrid_main.Columns[3].Width = 60;

            dtgrid_main.Columns[4].Name = "rnt_card";
            dtgrid_main.Columns[5].Name = "rnt_washStation";
        }

        private void dtgridServicesFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 3;

            dtgrid_main.Columns[0].Name = "sv_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "sv_name";
            dtgrid_main.Columns[2].Name = "sv_price";

        }

        private void dtgridrent_ServFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 5;

            dtgrid_main.Columns[0].Name = "rs_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "rs_rent";
            dtgrid_main.Columns[1].Width = 60;
            dtgrid_main.Columns[2].Name = "rs_service";
            dtgrid_main.Columns[2].Width = 60;
            dtgrid_main.Columns[3].Name = "rs_minutes";
            dtgrid_main.Columns[3].Width = 60;
            dtgrid_main.Columns[4].Name = "rs_sum";
        }

        private void dtgridBonusProgFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;

            dtgrid_main.Columns[0].Name = "bp_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "bp_cat";
            dtgrid_main.Columns[1].Width = 60;
            dtgrid_main.Columns[2].Name = "bp_clName";
            dtgrid_main.Columns[3].Name = "bp_clPhone";
        }

        private void dtgridWSFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;
            dtgrid_main.Columns[0].Name = "ws_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "ws_num";
            dtgrid_main.Columns[1].Width = 60;
            dtgrid_main.Columns[2].Name = "ws_status";
            dtgrid_main.Columns[2].Width = 60;
            dtgrid_main.Columns[3].Name = "ws_statusDesc";
        }

        private void dtgrideqwsFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;

            dtgrid_main.Columns[0].Name = "eqws_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "eqws_equipment";
            dtgrid_main.Columns[2].Name = "eqws_washstation";
            dtgrid_main.Columns[3].Name = "eqws_count";
        }

        private void dtgriddeleqFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;

            dtgrid_main.Columns[0].Name = "de_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "de_delivery";
            dtgrid_main.Columns[2].Name = "de_equipment";
            dtgrid_main.Columns[3].Name = "de_count";
        }

        private void dtgridEquipmentsFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;

            dtgrid_main.Columns[0].Name = "eq_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "eq_category";
            dtgrid_main.Columns[2].Name = "eq_name";
            dtgrid_main.Columns[3].Name = "eq_count";
        }

        private void dtgridDeliveryFill()
        {
            dtgridClear();
            dtgrid_main.ColumnCount = 4;

            dtgrid_main.Columns[0].Name = "dl_id";
            dtgrid_main.Columns[0].Width = 60;
            dtgrid_main.Columns[1].Name = "dl_date";
            dtgrid_main.Columns[2].Name = "dl_desc";
            dtgrid_main.Columns[3].Name = "dl_status";
        }


        // Show
        private void ShowRents()
        {
            dtgridRentsFill();
            
            query = "SELECT * FROM Rents";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while(dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["rnt_id"], dbReader["rnt_date"], dbReader["rnt_rgclient"], dbReader["rnt_sum"], dbReader["rnt_card"], dbReader["rnt_washStation"]);
            }
        }

        private void ShowServices()
        {
            dtgridServicesFill();

            query = "SELECT * FROM Services";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["sv_id"], dbReader["sv_name"], dbReader["sv_price"]);
            }
        }
        
        private void Showrent_serv()
        {
            dtgridrent_ServFill();

            query = "SELECT * FROM rent_serv";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["rs_id"], dbReader["rs_rent"], dbReader["rs_service"], dbReader["rs_minutes"], dbReader["rs_sum"]);
            }
        }

        private void ShowBonusProg()
        {
            dtgridBonusProgFill();

            query = "SELECT * FROM BonusProg";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["bp_id"], dbReader["bp_cat"], dbReader["bp_clName"], dbReader["bp_clPhone"]);
            }
        }

        private void ShowEquipments()
        {
            dtgridEquipmentsFill();

            query = "SELECT * FROM Equipments";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["eq_id"], dbReader["eq_category"], dbReader["eq_name"], dbReader["eq_count"]);
            }
        }

        private void ShowDelivery()
        {
            dtgridDeliveryFill();

            query = "SELECT * FROM Delivery";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["dl_id"], dbReader["dl_date"], dbReader["dl_desc"], dbReader["dl_status"]);
            }
        }

        private void Showeqws()
        {
            dtgrideqwsFill();

            query = "SELECT * FROM eq_ws";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["eqws_id"], dbReader["eqws_equipment"], dbReader["eqws_washstation"], dbReader["eqws_count"]);
            }
        }
        private void ShowWS()
        {
            dtgridWSFill();
            query = "SELECT * FROM WashStations";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["ws_id"], dbReader["ws_num"], dbReader["ws_status"], dbReader["ws_statusDesc"]);
            }
        }

        private void Showdel_eq()
        {
            dtgriddeleqFill();

            query = "SELECT * FROM del_eq";

            OleDbCommand SELECT = new OleDbCommand(query, myconnection);
            OleDbDataReader dbReader = SELECT.ExecuteReader();

            while (dbReader.Read())
            {
                dtgrid_main.Rows.Add(dbReader["de_id"], dbReader["de_delivery"], dbReader["de_equipment"], dbReader["de_count"]);
            }
        }



        private void bt_addRec_Click(object sender, EventArgs e)
        {
            switch (cmbox_main.SelectedIndex)
            {
                case 0:
                    Form_AddRents f_AddRents = new Form_AddRents();
                    f_AddRents.Owner = this;
                    f_AddRents.Show();
                    break;
                case 1:
                    Form_AddServices f_AddServices = new Form_AddServices();
                    f_AddServices.Owner = this;
                    f_AddServices.Show();
                    break;
                case 2:
                    Form_Addrentserv f_rentserv = new Form_Addrentserv();
                    f_rentserv.Owner = this;
                    f_rentserv.Show();
                    break;

                case 3:
                    Form_AddBonusProg f_BonusProg = new Form_AddBonusProg();
                    f_BonusProg.Owner = this;
                    f_BonusProg.Show();
                    break;

                case 4:
                    Form_AddWashStations f_WashStations = new Form_AddWashStations();
                    f_WashStations.Owner = this;
                    f_WashStations.Show();
                    break;

                case 5:
                    Form_AddEquipments f_Equipments = new Form_AddEquipments();
                    f_Equipments.Owner = this;
                    f_Equipments.Show();
                    break;


                case 6:
                    Form_AddDelivery f_delivery = new Form_AddDelivery();
                    f_delivery.Owner = this;
                    f_delivery.Show();
                    break;

                case 7:
                    Form_Addeq_ws f_eq_ws = new Form_Addeq_ws();
                    f_eq_ws.Owner = this;
                    f_eq_ws.Show();
                    break;

                case 8:
                    Form_Adddel_eq f_del_eq = new Form_Adddel_eq();
                    f_del_eq.Owner = this;
                    f_del_eq.Show();
                    break;
                    
            }

            }

        // Смена таблицы
        private void cmbox_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbox_main.SelectedIndex)
            {
                case 0:
                    ShowRents();
                    break;
                case 1:
                    ShowServices();
                    break;
                case 2:
                    Showrent_serv();
                    break;
                case 3:
                    ShowBonusProg();
                    break;
                case 4:
                    ShowWS();
                    break;
                case 5:
                    ShowEquipments();
                    break;
                case 6:
                    ShowDelivery();
                    break;
                case 7:
                    Showeqws();
                    break;
                case 8:
                    Showdel_eq();
                    break;



            }
                
                

        }

        private void dtgrid_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pn_Clear();
            switch(cmbox_main.SelectedIndex)
            {
                case 0:
                pn_Rents.Visible = true;

                if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    // rnt_id
                    tb_rnt_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // rnt_date
                    dt_rnt_date.Value = Convert.ToDateTime(dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString());

                    // rnt_rgclient
                    tb_rnt_rgclient.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                    // rnt_sum
                    tb_rnt_sum.Text = dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString();

                    // rnt_card
                    tb_rnt_card.Text = dtgrid_main.Rows[e.RowIndex].Cells[4].Value.ToString();

                    // rnt_washStation
                    tb_rnt_washStation.Text = dtgrid_main.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                    break;

                case 1:
                pn_Services.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // sv_id
                        tb_sv_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // sv_name
                        tb_sv_name.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // sv_price
                        tb_sv_price.Text = (dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                    break;

                case 2:
                    pn_rent_serv.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // rnt_rs_id
                        tb_rs_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // rnt_rs_rent
                        tb_rs_rent.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // rnt_rs_service
                        tb_rs_service.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // rnt_rs_minutes
                        tb_rs_minutes.Text = dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString();

                        // rnt_rs_sum
                        tb_rs_sum.Text = dtgrid_main.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                    break;

                case 3:
                    pn_BonusProg.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // bp_id
                        tb_bp_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // bp_cat
                        cb_bp_cat.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // bp_clName
                        tb_bp_clName.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // bp_clPhone
                        tb_bp_clPhone.Text = (dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString());

                    }
                    break;

                case 4:
                    pn_WashStations.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // ws_id
                        tb_ws_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // ws_num
                        tb_ws_num.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // ws_status
                        cb_ws_status.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // ws_statusDesc
                        tb_ws_statusDesc.Text = (dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString());

                    }
                    break;

                case 5:
                    pn_Equipments.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // eq_id
                        tb_eq_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // eq_category
                        cb_eq_category.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // eq_name
                        tb_eq_name.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // eq_count
                        num_eq_count.Text = (dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString());

                    }
                    break;

                case 6:
                    pn_Delivery.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // dl_id
                        tb_dl_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // dl_date
                        dt_dl_date.Value = Convert.ToDateTime(dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString());

                        // dl_status
                        tb_dl_desc.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // dl_desc
                        cb_dl_status.Text = dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString();

                        

                    }
                    break;

                case 7:
                    pn_eqws.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // eqws_id
                        tb_eqws_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // eqws_equipment
                        tb_eqws_equipment.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // eqws_washStation
                        tb_eqws_washStation.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // eqws_count
                        num_eqws_count.Text = dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;

                case 8:
                    pn_del_eq.Visible = true;

                    if (dtgrid_main.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        // eqws_id
                        tb_de_id.Text = dtgrid_main.Rows[e.RowIndex].Cells[0].Value.ToString();

                        // eqws_equipment
                        tb_de_delivery.Text = dtgrid_main.Rows[e.RowIndex].Cells[1].Value.ToString();

                        // eqws_washStation
                        tb_de_equipment.Text = dtgrid_main.Rows[e.RowIndex].Cells[2].Value.ToString();

                        // eqws_count
                        num_de_count.Text = dtgrid_main.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    break;
            }
        }

        private void bt_editRec_Click(object sender, EventArgs e)
        {
            OleDbCommand UPDATE;
            OleDbDataReader dbReader;
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите изменить данные?", "Подтвердите действие",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                switch (cmbox_main.SelectedIndex)
                {
                    case 0:

                        string rnt_id = tb_rnt_id.Text;
                        string rnt_date = dt_rnt_date.Value.ToString();
                        string rnt_rgclient = tb_rnt_rgclient.Text;
                        string rnt_sum = tb_rnt_sum.Text;
                        string rnt_card = tb_rnt_card.Text;
                        string rnt_washstation = tb_rnt_washStation.Text;

                        if (rnt_id == "" || rnt_date == "" || rnt_sum == "" || rnt_card == "" || rnt_washstation == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (rnt_rgclient == "") { rnt_rgclient = "null"; }

                        Form1.query = $"UPDATE Rents SET rnt_date = \"{rnt_date}\", rnt_rgclient = {rnt_rgclient}, rnt_sum = {rnt_sum}, rnt_card = \"{rnt_card}\", rnt_washStation = {rnt_washstation} WHERE rnt_id = {rnt_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();
                        break;

                    case 1:
                        string sv_id = tb_sv_id.Text;
                        string sv_name = tb_sv_name.Text;
                        string sv_price = tb_sv_price.Text;

                        if (sv_id == "" || sv_name == "" || sv_price == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE Services SET sv_name = \"{sv_name}\", sv_price = \"{sv_price}\" WHERE sv_id = {sv_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 2:
                        string rs_id = tb_rs_id.Text;
                        string rs_rent = tb_rs_rent.Text;
                        string rs_service = tb_rs_service.Text;
                        string rs_minutes = tb_rs_minutes.Text;
                        string rs_sum = tb_rs_sum.Text;

                        if (rs_id == "" || rs_rent == "" || rs_service == "" || rs_minutes == "" || rs_sum == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE rent_serv SET rs_rent = \"{rs_rent}\", rs_service = \"{rs_service}\", rs_minutes = \"{rs_minutes}\", rs_sum = \"{rs_sum}\" WHERE rs_id = {rs_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 3:
                        string bp_id = tb_bp_id.Text;
                        string bp_cat = cb_bp_cat.Text;
                        string bp_clName = tb_bp_clName.Text;
                        string bp_clPhone = tb_bp_clPhone.Text;

                        if (bp_id == "" || bp_cat == "" || bp_clName == "" || bp_clPhone == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE BonusProg SET bp_cat = \"{bp_cat}\", bp_clName = \"{bp_clName}\", bp_clPhone = \"{bp_clPhone}\" WHERE bp_id = {bp_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 4:
                        string ws_id = tb_ws_id.Text;
                        string ws_num = tb_ws_num.Text;
                        string ws_status = cb_ws_status.Text;
                        string ws_statusDesc = tb_ws_statusDesc.Text;

                        if (ws_id == "" || ws_num == "" || ws_status == "" || ws_statusDesc == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE WashStations SET ws_num = \"{ws_num}\", ws_status = \"{ws_status}\", ws_statusDesc = \"{ws_statusDesc}\" WHERE ws_id = {ws_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 5:
                        string eq_id = tb_eq_id.Text;
                        string eq_category = cb_eq_category.Text;
                        string eq_name = tb_eq_name.Text;
                        string eq_count = num_eq_count.Text;

                        if (eq_id == "" || eq_category == "" || eq_name == "" || eq_count == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE Equipments SET eq_category = \"{eq_category}\", eq_name = \"{eq_name}\", eq_count = \"{eq_count}\" WHERE eq_id = {eq_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 6:
                        string dl_id = tb_dl_id.Text;
                        string dl_date = dt_dl_date.Text;
                        string dl_desc = tb_dl_desc.Text;
                        string dl_status = cb_dl_status.Text;

                        if (dl_id == "" || dl_date == "" || dl_desc == "" || dl_status == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE Delivery SET dl_date = \"{dl_date}\", dl_desc = \"{dl_desc}\", dl_status = \"{dl_status}\" WHERE dl_id = {dl_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 7:
                        string eqws_id = tb_eqws_id.Text;
                        string eqws_equipment = tb_eqws_equipment.Text;
                        string eqws_washstation = tb_eqws_washStation.Text;
                        string eqws_count = num_eqws_count.Text;

                        if (eqws_id == "" || eqws_equipment == "" || eqws_washstation == "" || eqws_count == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE eq_ws SET eqws_equipment = \"{eqws_equipment}\", eqws_washstation = \"{eqws_washstation}\", eqws_count = \"{eqws_count}\"  WHERE eqws_id = {eqws_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;

                    case 8:
                        string de_id = tb_de_id.Text;
                        string de_delivery = tb_de_delivery.Text;
                        string de_equipment = tb_de_equipment.Text;
                        string de_count = num_de_count.Text;

                        if (de_id == "" || de_delivery == "" || de_equipment == "" || de_count == "")
                        {
                            MessageBox.Show("Проверьте корректность вносимых в запись данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"UPDATE del_eq SET de_delivery = \"{de_delivery}\", de_equipment = \"{de_equipment}\", de_count = \"{de_count}\"  WHERE de_id = {de_id}";

                        UPDATE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = UPDATE.ExecuteReader();

                        break;
                }
            }
            else { return; }
        }

        private void bt_delRec_Click(object sender, EventArgs e)
        {
            OleDbCommand DELETE;
            OleDbDataReader dbReader;
            
                switch (cmbox_main.SelectedIndex)
                {
                    case 0:


                        string rnt_id = tb_rnt_id.Text;
                        if (rnt_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        Form1.query = $"DELETE FROM Rents WHERE rnt_id = {rnt_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();


                        break;

                    case 1:
                        string sv_id = tb_sv_id.Text;
                        if (sv_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"DELETE FROM Services WHERE sv_id = {sv_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 2:
                        string rs_id = tb_rs_id.Text;
                        if (rs_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"DELETE FROM rent_serv WHERE rs_id = {rs_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 3:
                        string bp_id = tb_bp_id.Text;
                        if (bp_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Form1.query = $"DELETE FROM BonusProg WHERE bp_id = {bp_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 4:
                        string ws_id = tb_ws_id.Text;
                        if (ws_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"DELETE FROM WashStations WHERE ws_id = {ws_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 5:
                        string eq_id = tb_eq_id.Text;
                        if (eq_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Form1.query = $"DELETE FROM Equipments WHERE eq_id = {eq_id}";

                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 6:
                        string dl_id = tb_dl_id.Text;
                        if (dl_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Form1.query = $"DELETE FROM Delivery WHERE dl_id = {dl_id}";

                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 7:
                        string eqws_id = tb_eqws_id.Text;
                        if (eqws_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Form1.query = $"DELETE FROM eq_ws WHERE eqws_id = {eqws_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);
                        dbReader = DELETE.ExecuteReader();
                        break;

                    case 8:
                        string de_id = tb_de_id.Text;
                        if (de_id == "")
                        {
                            MessageBox.Show("Проверьте корректность удаляемых в запись данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Form1.query = $"DELETE FROM del_eq WHERE de_id = {de_id}";
                        DELETE = new OleDbCommand(Form1.query, Form1.myconnection);

                        dbReader = DELETE.ExecuteReader();
                        break;

                }
            
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            dtgrid_main.ColumnCount = 0;
            pn_Clear();
        }
    }
}
