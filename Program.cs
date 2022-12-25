using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");

            ContactsBuilderArray contactsBuilderArray = new ContactsBuilderArray();
            contactsBuilderArray.AddContact("rutik", "koshti", "3/5 jay", "mumbai", "maharastra", 400078, 8898338, "koshti.432@gmail.com");
            contactsBuilderArray.AddContact("rushi", "koshti", "3/5 jay", "mumbai", "maharastra", 400078, 7021734, "koshti.123@gmail.com");

            contactsBuilderArray.DisplayContacts();

            // contactsBuilderArray.EditTheContact();

            contactsBuilderArray.DeleteTheContct();

            Console.WriteLine("=============================");

            contactsBuilderArray.DisplayContacts();

        }
    }
}
