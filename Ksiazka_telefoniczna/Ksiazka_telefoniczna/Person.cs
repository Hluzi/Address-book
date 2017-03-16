using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiazka_telefoniczna
{
    public class Person
    {

        private int N;
        private int ID;
        private string first_name;
        private string last_name;
        private string address;
        private string phone_number;
        private string email_address;

        public int n
        {
            get
            {
                return N;
            }

            set
            {
                N = value;
            }
        }

        public int id
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }

        }

        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phone_number
        {
            get
            {
                return phone_number;
            }

            set
            {
                phone_number = value;
            }
        }

        public string Email_address
        {
            get
            {
                return email_address;
            }

            set
            {
                email_address = value;
            }
        }



        //public Person()
        //{
        //    ID = n;
        //    first_name = " ";
        //    last_name = " ";
        //    address = " ";
        //    phone_number = " ";
        //    email_address = " ";
        //    n++;
        //}
    }
}
