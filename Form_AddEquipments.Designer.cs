
namespace WASH_SOME
{
    partial class Form_AddEquipments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbox_cat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.num_count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ФИО";
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
            "Расходные материалы",
            "Запчасти",
            "Инструмент",
            "Другое"});
            this.cmbox_cat.Location = new System.Drawing.Point(12, 67);
            this.cmbox_cat.Name = "cmbox_cat";
            this.cmbox_cat.Size = new System.Drawing.Size(224, 36);
            this.cmbox_cat.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.AutoRoundedCorners = true;
            this.tb_name.BorderRadius = 17;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.DefaultText = "";
            this.tb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Location = new System.Drawing.Point(12, 144);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderText = "";
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(366, 36);
            this.tb_name.TabIndex = 12;
            // 
            // num_count
            // 
            this.num_count.AutoRoundedCorners = true;
            this.num_count.BackColor = System.Drawing.Color.Transparent;
            this.num_count.BorderRadius = 17;
            this.num_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_count.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_count.Location = new System.Drawing.Point(12, 227);
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(100, 36);
            this.num_count.TabIndex = 13;
            this.num_count.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Form_AddEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(426, 344);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.cmbox_cat);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddEquipments";
            this.Text = "Добавить оборудование";
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_cat;
        private Guna.UI2.WinForms.Guna2TextBox tb_name;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_count;
    }
}