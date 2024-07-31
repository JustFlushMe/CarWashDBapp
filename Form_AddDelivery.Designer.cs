
namespace WASH_SOME
{
    partial class Form_AddDelivery
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
            this.tb_details = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbox_cat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_details
            // 
            this.tb_details.AutoRoundedCorners = true;
            this.tb_details.BorderRadius = 17;
            this.tb_details.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_details.DefaultText = "";
            this.tb_details.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_details.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_details.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_details.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_details.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_details.Location = new System.Drawing.Point(16, 118);
            this.tb_details.Name = "tb_details";
            this.tb_details.PasswordChar = '\0';
            this.tb_details.PlaceholderText = "";
            this.tb_details.SelectedText = "";
            this.tb_details.Size = new System.Drawing.Size(366, 36);
            this.tb_details.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата поставки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Детали поставки:";
            // 
            // cmbox_cat
            // 
            this.cmbox_cat.AutoRoundedCorners = true;
            this.cmbox_cat.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_cat.BorderRadius = 17;
            this.cmbox_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_cat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_cat.ItemHeight = 30;
            this.cmbox_cat.Items.AddRange(new object[] {
            "Доставлено",
            "В процессе",
            "Отменено",
            "Задержан"});
            this.cmbox_cat.Location = new System.Drawing.Point(12, 188);
            this.cmbox_cat.Name = "cmbox_cat";
            this.cmbox_cat.Size = new System.Drawing.Size(149, 36);
            this.cmbox_cat.TabIndex = 8;
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
            this.bt_add.Location = new System.Drawing.Point(212, 241);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(215, 45);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "Добавить";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Form_AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(426, 286);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cmbox_cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddDelivery";
            this.Text = "Добавить поставку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_cat;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}