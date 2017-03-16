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
    public partial class Form2 : Form
    {

        private Person new_Person = new Person();
        bool add_bool;
        string full_name;

        public Form2()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            FN_box.Clear();
            LN_box.Clear();
            Address_box.Clear();
            Phone_box.Clear();
            Email_box.Clear();
            this.Close();

            add_bool = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            bool empty_FN = string.IsNullOrWhiteSpace(FN_box.Text);
            bool empty_LN = string.IsNullOrWhiteSpace(LN_box.Text);
            bool empty_Address = string.IsNullOrWhiteSpace(Address_box.Text);
            bool empty_Phone = string.IsNullOrWhiteSpace(Phone_box.Text);
            bool empty_Email = string.IsNullOrWhiteSpace(Email_box.Text);
            


            if (FN_box.Text.Contains(" ") == true || LN_box.Text.Contains(" ") == true || Phone_box.Text.Contains(" ") == true || Email_box.Text.Contains(" ") == true)
            {
                MessageBox.Show("Serio?? Usun ta spacje deklu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (empty_FN == true)
            {
                MessageBox.Show("Podaj imie!", "Error", MessageBoxButtons.OK);
                FN_box.Clear();
                return;
            }

            if (empty_LN == true)
            {
                MessageBox.Show("Podaj nazwisko!","Error", MessageBoxButtons.OK);
                LN_box.Clear();
                return;
            }

            if (empty_Address == true)
            {
                MessageBox.Show("Podaj adres!", "Error", MessageBoxButtons.OK);
                Address_box.Clear();
                return;
            }

            if (empty_Phone == true || is_numeric() == false || Phone_box.Text.Length != 9)
            {
                MessageBox.Show("Podaj poprawny numer telefonu!", "Error", MessageBoxButtons.OK);
                Phone_box.Clear();
                return;
            }

            if (empty_Email == true)
            {
                MessageBox.Show("Podaj email!", "Error", MessageBoxButtons.OK);
                Email_box.Clear();
                return;
            }


            Person person = new Person();
            person.First_name = FN_box.Text;
            person.Last_name = LN_box.Text;
            person.Address = Address_box.Text;
            person.Phone_number = Phone_box.Text;
            person.Email_address = Email_box.Text;

            new_Person = person;
            full_name = FN_box.Text + " " + LN_box.Text;


            add_bool = true;

            FN_box.Clear();
            LN_box.Clear();
            Address_box.Clear();
            Phone_box.Clear();
            Email_box.Clear();
            this.Close();

          
        }

        public Person get_Person()
        {
            return new_Person;
        }

        public string get_full_name()
        {
            return full_name;
        }

        public bool get_add_bool()
        {
            return add_bool;
        }

        public bool is_numeric()
        {
            int number;
            bool is_numeric = int.TryParse(Phone_box.Text, out number);
            return is_numeric;
        }


    }

}
