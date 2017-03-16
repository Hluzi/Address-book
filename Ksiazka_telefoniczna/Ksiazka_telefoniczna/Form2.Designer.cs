namespace Ksiazka_telefoniczna
{
    partial class Form2
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
            this.FN_box = new System.Windows.Forms.TextBox();
            this.LN_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Address_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FN_box
            // 
            this.FN_box.Location = new System.Drawing.Point(126, 19);
            this.FN_box.Name = "FN_box";
            this.FN_box.Size = new System.Drawing.Size(259, 20);
            this.FN_box.TabIndex = 6;
            this.FN_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LN_box
            // 
            this.LN_box.Location = new System.Drawing.Point(126, 45);
            this.LN_box.Name = "LN_box";
            this.LN_box.Size = new System.Drawing.Size(259, 20);
            this.LN_box.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // Address_box
            // 
            this.Address_box.Location = new System.Drawing.Point(126, 71);
            this.Address_box.Name = "Address_box";
            this.Address_box.Size = new System.Drawing.Size(259, 20);
            this.Address_box.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // Phone_box
            // 
            this.Phone_box.Location = new System.Drawing.Point(126, 99);
            this.Phone_box.MaxLength = 9;
            this.Phone_box.Name = "Phone_box";
            this.Phone_box.Size = new System.Drawing.Size(95, 20);
            this.Phone_box.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Email_box
            // 
            this.Email_box.Location = new System.Drawing.Point(126, 127);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(279, 20);
            this.Email_box.TabIndex = 16;
            this.Email_box.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email Address\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(235, 188);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(97, 59);
            this.Cancel_button.TabIndex = 18;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(121, 188);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(97, 59);
            this.Save_button.TabIndex = 19;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Email_box);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Phone_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Address_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LN_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FN_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Cancel_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FN_box;
        private System.Windows.Forms.TextBox LN_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Address_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phone_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}