using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hii");
            Contacts objContact = new Contacts();
            //Contacts contactOne = new Contacts()
            //{
            //    FirstName = "sid",
            //    LastName = "Rao",
            //    Address = "Dhankavdi",
            //    City = "Pune",
            //    State = "Maharashtra",
            //    Zip = 101,
            //    Phone = 232423,
            //    Email = "Sid@gail.com"
            //};
            Contacts contactTwo = new Contacts()
            {
                FirstName = "sidhi",
                LastName = "Raj",
                Address = "Dhankavdi",
                City = "nagar",
                State = "Maharashtra",
                Zip = 103,
                Phone = 232423,
                Email = "Sidhi@gail.com"
            };
            Dictionary<int, Contacts> dictContact = new Dictionary<int, Contacts>();
            //dictContact.Add(1, contactOne);
            dictContact.Add(2, contactTwo);
            foreach (KeyValuePair<int, Contacts> contactkeyValuePair in dictContact)
            {
                Console.WriteLine("Key is {0}", contactkeyValuePair.Key);
                Contacts contTemp = contactkeyValuePair.Value;
                Console.WriteLine(" First Name ={1} \n Last Name ={2} \n Address = {3} \n City = {4} \n State = {5} \n Zip = {6} \n Phone = {7} \n Email = {8}", contactkeyValuePair.Key, contTemp.FirstName, contTemp.LastName, contTemp.Address, contTemp.City, contTemp.State, contTemp.Zip, contTemp.Phone, contTemp.Email);
                Console.WriteLine("---------------------------------------------------------------------");
            }

            Console.WriteLine("enter You're choice:");
            Console.WriteLine("1:add an contact \n 2:edit contact");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //added an contact
                    objContact.AddContact();
                    break;
                case 2:
                    //edit contact
                    objContact.EditContact();
                    break;
                default:
                    Console.WriteLine("default value");
                    break;
            }
            Console.ReadKey();

        }
    }
    
}
