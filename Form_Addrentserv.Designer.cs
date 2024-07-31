
namespace WASH_SOME
{
    partial class Form_Addrentserv
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
            this.tb_sum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbox_service = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbox_rent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_sum
            // 
            this.tb_sum.AutoRoundedCorners = true;
            this.tb_sum.BorderRadius = 17;
            this.tb_sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sum.DefaultText = "";
            this.tb_sum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_sum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_sum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_sum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_sum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_sum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_sum.Location = new System.Drawing.Point(12, 235);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.PasswordChar = '\0';
            this.tb_sum.PlaceholderText = "";
            this.tb_sum.SelectedText = "";
            this.tb_sum.Size = new System.Drawing.Size(151, 36);
            this.tb_sum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Транкзакция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Минуты:";
            // 
            // cmbox_service
            // 
            this.cmbox_service.AutoRoundedCorners = true;
            this.cmbox_service.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_service.BorderRadius = 17;
            this.cmbox_service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_service.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_service.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_service.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_service.ItemHeight = 30;
            this.cmbox_service.Location = new System.Drawing.Point(15, 100);
            this.cmbox_service.Name = "cmbox_service";
            this.cmbox_service.Size = new System.Drawing.Size(97, 36);
            this.cmbox_service.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Услуга";
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
            this.bt_add.Location = new System.Drawing.Point(104, 299);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(215, 45);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "Добавить";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // cmbox_rent
            // 
            this.cmbox_rent.AutoRoundedCorners = true;
            this.cmbox_rent.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_rent.BorderRadius = 17;
            this.cmbox_rent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_rent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_rent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_rent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_rent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_rent.ItemHeight = 30;
            this.cmbox_rent.Location = new System.Drawing.Point(12, 45);
            this.cmbox_rent.Name = "cmbox_rent";
            this.cmbox_rent.Size = new System.Drawing.Size(224, 36);
            this.cmbox_rent.TabIndex = 11;
            // 
            // numMin
            // 
            this.numMin.AutoRoundedCorners = true;
            this.numMin.BackColor = System.Drawing.Color.Transparent;
            this.numMin.BorderColor = System.Drawing.Color.Transparent;
            this.numMin.BorderRadius = 17;
            this.numMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numMin.Location = new System.Drawing.Point(12, 168);
            this.numMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(61, 36);
            this.numMin.TabIndex = 12;
            this.numMin.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Form_Addrentserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(319, 344);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.cmbox_rent);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_service);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Addrentserv";
            this.Text = "Form_Add";
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tb_sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_service;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_rent;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMin;
    }
}