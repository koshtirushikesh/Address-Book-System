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
            for (int i = 0; i < contactsArrayList.Count ; i++)
            {
                Console.WriteLine(contactsArrayList[i].First_Name);
                Console.WriteLine(contactsArrayList[i].Last_Name);
                Console.WriteLine(contactsArrayList[i].Address);
                Console.WriteLine(contactsArrayList[i].City);
                Console.WriteLine(contactsArrayList[i].State);
                Console.WriteLine(contactsArrayList[i].Zip);
                Console.WriteLine(contactsArrayList[i].Phone_Number);
                Console.WriteLine(contactsArrayList[i].E_mail_Id);
                Console.WriteLine("-------------------------------------");
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

        public void DeleteTheContct()
        {
            Console.WriteLine("enter the first name of contact to delete: ");
            string Find = Console.ReadLine();
            int j = 0;
            for (int i = 0; i < numOfContacts; i++)
            {
                if (contactsArrayList[i].First_Name == Find)
                {
                    j = i;
                }
            }
            contactsArrayList.Remove(contactsArrayList[j]);
        }

        public void SearchPersonInCity(String CITY)
        {
            foreach(Contacts contacts in contactsArrayList.FindAll(e=>e.City== CITY))
            Console.WriteLine(contacts.First_Name+ " "+contacts.Last_Name);
        }

        public void PersonsInState(string State)
        {
            foreach (Contacts contacts in contactsArrayList.FindAll(e => e.State == State))
                Console.WriteLine(contacts.First_Name + " " + contacts.Last_Name);
        }
    }
}
