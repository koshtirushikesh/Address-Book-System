using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contacts
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public int Phone_Number;
        public string E_mail_Id;

        public Contacts(string First_Name, string Last_Name, string Address, string City, string State, int Zip, int Phone_Number, string E_mail_Id)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Phone_Number = Phone_Number;
            this.E_mail_Id = E_mail_Id;
        }

        
    }
}
