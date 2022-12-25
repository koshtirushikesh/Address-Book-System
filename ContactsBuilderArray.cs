using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactsBuilderArray
    {
        private List<Contacts> contactsArrayList;
        public int numOfContacts = 0;
        private int j;

        public ContactsBuilderArray()
        {
            this.contactsArrayList = new List<Contacts>();
        }

        public void AddContact(string First_Name, string Last_Name, string Address, string City, string State, int Zip, int Phone_Number, string E_mail_Id)
        {
            Contacts contacts = new Contacts(First_Name, Last_Name, Address, City, State, Zip, Phone_Number, E_mail_Id);
            this.contactsArrayList.Add(contacts);
            numOfContacts++;
        }

        public void DisplayContacts()
        {
            for (int i = 0; i < numOfContacts; i++)
            {
                Console.WriteLine(contactsArrayList[i].First_Name);
            }
        }


        public void EditTheContact()
        {
            Console.WriteLine("enter the first name of contact to edit");
            string Find = Console.ReadLine();

            for (int i = 0; i < numOfContacts; i++)
            {
                if (contactsArrayList[i].First_Name == Find)
                {
                    int j = i;
                }
            }
            Console.WriteLine("Enter the new Address: ");
            contactsArrayList[j].Address = Console.ReadLine();

            Console.WriteLine("Enter the new phone number: ");
            contactsArrayList[j].Phone_Number = (int)Convert.ToInt64(Console.ReadLine()) ;

            Console.WriteLine("Enter the new E mail: ");
            contactsArrayList[j].E_mail_Id = Console.ReadLine();

            Console.WriteLine(contactsArrayList[j].Address);
            Console.WriteLine(contactsArrayList[j].Phone_Number);
            Console.WriteLine(contactsArrayList[j].E_mail_Id);
        }

    }
}
