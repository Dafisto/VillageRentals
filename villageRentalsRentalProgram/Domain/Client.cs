using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace villageRentalsRentalProgram.Domain
{
    public class Client
    {
        private int customerID;
        private string lastName;
        private string firstName;
        private string contact_number;
        private string email;
        private string notes;
        private bool banned;
        
        [PrimaryKey]
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Contact_Number
        {
            get { return contact_number; }
            set { contact_number = value; }
        }
        public string Email
        {
            get { return email;  }
            set { email = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public bool Banned
        {
            get { return banned; }
            set { banned = value; }
        }

        public Client(int customerID, string lastName, string firstName, string contact_number, string email, string notes, bool banned)
        {
            this.CustomerID = customerID;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Contact_Number = contact_number;
            this.Email = email;
            this.Notes = notes;
            this.Banned = banned;
        }
        public Client()
        {

        }
        public override string ToString()
        {            
            return $"CLient ID: {CustomerID}, Name: {FirstName} {LastName}, Contact#: {Contact_Number}, email: {Email}, banned: {Banned}";
        }
        public string NotesToString()
        {
            return $"Notes for Client #: {CustomerID}-- {Notes}";
        }
    }
}
