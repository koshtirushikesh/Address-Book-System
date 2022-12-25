namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            ContactsArrayList contactsArrayList = new ContactsArrayList();
            Console.WriteLine("Enter the first name :");
            contactsArrayList.First_Name = Console.ReadLine();

            Console.WriteLine("Enter the last name :");
            contactsArrayList.Last_Name = Console.ReadLine();

            Console.WriteLine("Enter the Address :");
            contactsArrayList.Address = Console.ReadLine();

            Console.WriteLine("Enter the city name :");
            contactsArrayList.City = Console.ReadLine();

            Console.WriteLine("Enter the state name :");
            contactsArrayList.State = Console.ReadLine();

            Console.WriteLine("Enter the zip number :");
            contactsArrayList.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the phone number :");
            contactsArrayList.Phone_Number = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the E mail id :");
            contactsArrayList.E_mail_Id = Console.ReadLine();

            Console.WriteLine(contactsArrayList.First_Name);
            Console.WriteLine(contactsArrayList.Last_Name);
            Console.WriteLine(contactsArrayList.Address);
            Console.WriteLine(contactsArrayList.City);
            Console.WriteLine(contactsArrayList.State);
            Console.WriteLine(contactsArrayList.Zip);
            Console.WriteLine(contactsArrayList.Phone_Number);
            Console.WriteLine(contactsArrayList.E_mail_Id);
            
        }
    }
}