namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            ContactsArrayList Contact1 = new ContactsArrayList("rushi", "koshti", "3/5 jay", "mumbai", "maharastra", 400078,7021734, "koshti.123@gmail.com");
            ContactsArrayList Contact2 = new ContactsArrayList("rutik", "koshti", "3/5 jay", "mumbai", "maharastra", 400078, 8898338, "koshti.432@gmail.com");

            Console.WriteLine(Contact1.First_Name);
            Console.WriteLine(Contact1.Last_Name);
            Console.WriteLine(Contact1.Address);
            Console.WriteLine(Contact1.City);
            Console.WriteLine(Contact1.State);
            Console.WriteLine(Contact1.Zip);
            Console.WriteLine(Contact1.Phone_Number);
            Console.WriteLine(Contact1.E_mail_Id);

            Console.WriteLine(Contact2.First_Name);
            Console.WriteLine(Contact2.Last_Name);
            Console.WriteLine(Contact2.Address);
            Console.WriteLine(Contact2.City);
            Console.WriteLine(Contact2.State);
            Console.WriteLine(Contact2.Zip);
            Console.WriteLine(Contact2.Phone_Number);
            Console.WriteLine(Contact2.E_mail_Id);

        }
    }
}