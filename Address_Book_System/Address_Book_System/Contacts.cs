using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Contacts
    {
        
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public int Phone { get; set; }
            public string Email { get; set; }

        /// <summary>
        /// Add a new contactt to contact list
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter number of records You want to Add???");
            int numberOfRecord = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfRecord; i++)
            {
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();

                Console.WriteLine("State");
                string state = Console.ReadLine();

                Console.WriteLine("Enter Zip:");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Phone");
                int phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Contacts Objcontact = new Contacts()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    Phone = phone,
                    Email = email
                };

                Dictionary<int, Contacts> objDictContact = new Dictionary<int, Contacts>();
                //auto increment key 
                int count = objDictContact.Count;
                objDictContact.Add((count + 1), Objcontact);
                ShowAllContacts(objDictContact);
            }
        }


        public void ShowAllContacts(dynamic objShowDictContact)
        {
            foreach (KeyValuePair<int,Contacts> objShowContact in objShowDictContact)
            {
                Console.WriteLine("Key is={0}", objShowContact.Key);
                Contacts contTemp = objShowContact.Value;
                Console.WriteLine("Key show={0} \n First Name={1} \n Last Name={2} \n Address={3} \n City={4} \n State={5} \n Zip={6} \n Phone={7} \n Email={8}", objShowContact.Key, contTemp.FirstName, contTemp.LastName, contTemp.Address, contTemp.City, contTemp.State, contTemp.Zip, contTemp.Phone, contTemp.Email);
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }

        public void EditContact(Contacts contactFour)
        {
            Dictionary<int, Contacts> objEditDict = new Dictionary<int, Contacts>();
            objEditDict.Add(1, contactFour);
            Console.WriteLine("enter edited values");
                foreach (KeyValuePair<int , Contacts> contactkeyValuePair in objEditDict)
                {
                    Contacts contTemp = contactkeyValuePair.Value;
                    Console.WriteLine("This Is the contact to edit");
                    Console.WriteLine("Key show={0} \n First Name={1} \n Last Name={2} \n Address={3} \n City={4} \n State={5} \n Zip={6} \n Phone={7} \n Email={8}", contactkeyValuePair.Key, contTemp.FirstName, contTemp.LastName, contTemp.Address, contTemp.City, contTemp.State, contTemp.Zip, contTemp.Phone, contTemp.Email);
                }
                Console.WriteLine("-------------------------------------------------");
                AddContact();
                //insert contact
            //}

        }
        public void getCon(Contacts contact)
        {
            Console.WriteLine(contact.Address);
        }
    }
}
