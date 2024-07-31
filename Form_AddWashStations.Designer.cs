
namespace WASH_SOME
{
    partial class Form_AddWashStations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_statusdesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_num = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // tb_statusdesc
            // 
            this.tb_statusdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_statusdesc.DefaultText = "";
            this.tb_statusdesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_statusdesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_statusdesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_statusdesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_statusdesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_statusdesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_statusdesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_statusdesc.Location = new System.Drawing.Point(12, 200);
            this.tb_statusdesc.MaxLength = 90;
            this.tb_statusdesc.Multiline = true;
            this.tb_statusdesc.Name = "tb_statusdesc";
            this.tb_statusdesc.PasswordChar = '\0';
            this.tb_statusdesc.PlaceholderText = "";
            this.tb_statusdesc.SelectedText = "";
            this.tb_statusdesc.Size = new System.Drawing.Size(366, 83);
            this.tb_statusdesc.TabIndex = 3;
            // 
            // tb_num
            // 
            this.tb_num.AutoRoundedCorners = true;
            this.tb_num.BorderRadius = 17;
            this.tb_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_num.DefaultText = "";
            this.tb_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_num.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_num.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_num.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_num.Location = new System.Drawing.Point(12, 49);
            this.tb_num.MaxLength = 30;
            this.tb_num.Name = "tb_num";
            this.tb_num.PasswordChar = '\0';
            this.tb_num.PlaceholderText = "";
            this.tb_num.SelectedText = "";
            this.tb_num.Size = new System.Drawing.Size(105, 36);
            this.tb_num.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание статуса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер мойки";
            // 
            // bt_add
            // 
            this.bt_add.Animated = true;
            this.bt_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_add.FillColor = System.Drawing.Color.Gold;
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bt_add.ForeColor = System.Drawing.Color.Black;
            this.bt_add.Location = new System.Drawing.Point(213, 300);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(215, 45);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "Добавить";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // cmbox_status
            // 
            this.cmbox_status.AutoRoundedCorners = true;
            this.cmbox_status.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_status.BorderRadius = 17;
            this.cmbox_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_status.ItemHeight = 30;
            this.cmbox_status.Items.AddRange(new object[] {
            "Рабочая",
            "Нерабочая"});
            this.cmbox_status.Location = new System.Drawing.Point(15, 125);
            this.cmbox_status.Name = "cmbox_status";
            this.cmbox_status.Size = new System.Drawing.Size(160, 36);
            this.cmbox_status.TabIndex = 11;
            // 
            // Form_AddWashStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(426, 344);
            this.Controls.Add(this.cmbox_status);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_statusdesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddWashStations";
            this.Text = "Добавить мойку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_statusdesc;
        private Guna.UI2.WinForms.Guna2TextBox tb_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_status;
    }
}