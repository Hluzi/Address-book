namespace Ksiazka_telefoniczna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Contact_list = new System.Windows.Forms.ListBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Address_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LN_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FN_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contact_list
            // 
            this.Contact_list.FormattingEnabled = true;
            this.Contact_list.Location = new System.Drawing.Point(4, 7);
            this.Contact_list.Name = "Contact_list";
            this.Contact_list.Size = new System.Drawing.Size(585, 199);
            this.Contact_list.TabIndex = 1;
            this.Contact_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.Contact_list.DoubleClick += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(439, 212);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(150, 46);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_box);
            this.groupBox1.Location = new System.Drawing.Point(4, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search box";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(6, 19);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(240, 20);
            this.search_box.TabIndex = 0;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(273, 212);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(150, 46);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "Add\r\n";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Email_box);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Phone_box);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Address_box);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LN_box);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FN_box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(609, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 251);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // Email_box
            // 
            this.Email_box.Location = new System.Drawing.Point(125, 130);
            this.Email_box.Name = "Email_box";
            this.Email_box.ReadOnly = true;
            this.Email_box.Size = new System.Drawing.Size(279, 20);
            this.Email_box.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email Address\r\n";
            // 
            // Phone_box
            // 
            this.Phone_box.Location = new System.Drawing.Point(125, 102);
            this.Phone_box.MaxLength = 9;
            this.Phone_box.Name = "Phone_box";
            this.Phone_box.ReadOnly = true;
            this.Phone_box.Size = new System.Drawing.Size(95, 20);
            this.Phone_box.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone Number";
            // 
            // Address_box
            // 
            this.Address_box.Location = new System.Drawing.Point(125, 74);
            this.Address_box.Name = "Address_box";
            this.Address_box.ReadOnly = true;
            this.Address_box.Size = new System.Drawing.Size(259, 20);
            this.Address_box.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address";
            // 
            // LN_box
            // 
            this.LN_box.Location = new System.Drawing.Point(125, 48);
            this.LN_box.Name = "LN_box";
            this.LN_box.ReadOnly = true;
            this.LN_box.Size = new System.Drawing.Size(259, 20);
            this.LN_box.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name";
            // 
            // FN_box
            // 
            this.FN_box.Location = new System.Drawing.Point(125, 22);
            this.FN_box.Name = "FN_box";
            this.FN_box.ReadOnly = true;
            this.FN_box.Size = new System.Drawing.Size(259, 20);
            this.FN_box.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 268);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Contact_list);
            this.Name = "Form1";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Contact_list;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LN_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FN_box;
        private System.Windows.Forms.Label label1;
    }
}

