
namespace WASH_SOME
{
    partial class Form_Adddel_eq
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
            this.cmbox_eq = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmbox_del = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оборудование";
            // 
            // cmbox_eq
            // 
            this.cmbox_eq.AutoRoundedCorners = true;
            this.cmbox_eq.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_eq.BorderRadius = 17;
            this.cmbox_eq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_eq.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_eq.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_eq.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_eq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_eq.ItemHeight = 30;
            this.cmbox_eq.Location = new System.Drawing.Point(12, 45);
            this.cmbox_eq.Name = "cmbox_eq";
            this.cmbox_eq.Size = new System.Drawing.Size(83, 36);
            this.cmbox_eq.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Доставка";
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
            this.bt_add.Location = new System.Drawing.Point(211, 188);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(215, 45);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "Добавить";
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // cmbox_del
            // 
            this.cmbox_del.AutoRoundedCorners = true;
            this.cmbox_del.BackColor = System.Drawing.Color.Transparent;
            this.cmbox_del.BorderRadius = 17;
            this.cmbox_del.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbox_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_del.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_del.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbox_del.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbox_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbox_del.ItemHeight = 30;
            this.cmbox_del.Location = new System.Drawing.Point(276, 45);
            this.cmbox_del.Name = "cmbox_del";
            this.cmbox_del.Size = new System.Drawing.Size(83, 36);
            this.cmbox_del.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество";
            // 
            // num_count
            // 
            this.num_count.AutoRoundedCorners = true;
            this.num_count.BackColor = System.Drawing.Color.Transparent;
            this.num_count.BorderRadius = 17;
            this.num_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_count.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_count.Location = new System.Drawing.Point(15, 125);
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(100, 36);
            this.num_count.TabIndex = 12;
            this.num_count.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Form_Adddel_eq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(426, 233);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.cmbox_del);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_eq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Adddel_eq";
            this.Text = "Form_Add";
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_eq;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private Guna.UI2.WinForms.Guna2ComboBox cmbox_del;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_count;
    }
}