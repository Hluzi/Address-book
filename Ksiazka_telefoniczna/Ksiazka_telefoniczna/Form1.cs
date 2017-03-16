using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiazka_telefoniczna
{
    public partial class Form1 : Form
    {
        public List<Person> Contacts = new List<Person>();
        public List<string> Lista_nazwisk = new List<string>();
        private Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Contact_list.SelectedIndex >= 0)
            {

                foreach (Person p in Contacts)
                {
                    if (p.First_name + " " + p.Last_name == (String)Contact_list.SelectedItem)
                    {
                        FN_box.Text = p.First_name;
                        LN_box.Text = p.Last_name;
                        Address_box.Text = p.Address;
                        Phone_box.Text = p.Phone_number;
                        Email_box.Text = p.Email_address;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Add_button_Click(object sender, EventArgs e)
        {
            bool Success;

            frm2.ShowDialog();

            Success = frm2.get_add_bool();



            if (Success == true)
            {

                Lista_nazwisk.Add(frm2.get_full_name());

                Contact_list.Items.Add(frm2.get_full_name());

                Contacts.Add(frm2.get_Person());

            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (this.Contact_list.SelectedIndex >= 0)
            {
                DialogResult question = MessageBox.Show("100% ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    this.Contact_list.Items.RemoveAt(this.Contact_list.SelectedIndex);

                    FN_box.Text = "";
                    LN_box.Text = "";
                    Address_box.Text = "";
                    Phone_box.Text = "";
                    Email_box.Text = "";
                }

            }

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            Contact_list.Items.Clear();

            List<string> temp = new List<string>();

            foreach (string s in Lista_nazwisk)
            {

                if (s.Contains(search_box.Text) || s.Contains(search_box.Text))
                {
                    temp.Add(s);
                }
            }

            foreach (string s in temp)
            {
                Contact_list.Items.Add(s);
            }

        }
        
        public Person get_person(String s)
        {
            foreach (Person p in Contacts)
            {
                if (p.First_name == s)
                {
                    return p;
                }
            }

            return null;
        }

        public string get_FN()
        {
            return FN_box.Text;
        }

    }


}
    
  

 