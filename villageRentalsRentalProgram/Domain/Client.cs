using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Domain
{
    internal class Client
    {
        private int customerID;
        private string lastName;
        private string firstName;
        private string contact_number;
        private string email;
        private string notes;
        private bool banned;

        public int customerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string contact_number
        {
            get { return contact_number; }
            set { contact_number = value; }
        }
        public string email
        {
            get { return email}
            set { email = value; }
        }
        public string notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public bool banned
        {
            get { return banned; }
            set { banned = value; }
        }

        public Client(int customerID, string lastName, string firstName, string contact_number, string email, string notes, bool banned)
        {

        }
        public override string ToString()
        {            
        }
    }
}
