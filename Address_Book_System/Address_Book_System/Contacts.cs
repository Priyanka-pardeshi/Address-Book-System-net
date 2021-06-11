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
            int zip =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone");
            int phone =Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Contacts Objcontact = new Contacts()
            {
                FirstName =firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Phone = phone,
                Email =email
            };

            Dictionary<int, Contacts> objDictContact = new Dictionary<int, Contacts>();
            objDictContact.Add(3,Objcontact);
            foreach (KeyValuePair<int, Contacts> contactkeyValuePair in objDictContact)
            {
                Console.WriteLine("Key is {0}", contactkeyValuePair.Key);
                Contacts contTemp = contactkeyValuePair.Value;
                Console.WriteLine("Key show={0} \n First Name={1} \n Last Name={2} \n Address={3} \n City={4} \n State={5} \n Zip={6} \n Phone={7} \n Email={8}", contactkeyValuePair.Key, contTemp.FirstName, contTemp.LastName, contTemp.Address, contTemp.City, contTemp.State, contTemp.Zip, contTemp.Phone, contTemp.Email);
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }

        public void Insert()
        {
           

        }

        public void EditContact()
        {
            Contacts contactFour = new Contacts()
            {
                FirstName = "sid",
                LastName = "Rao",
                Address = "Dhankavdi",
                City = "Pune",
                State = "Maharashtra",
                Zip = 101,
                Phone = 232423,
                Email = "Sid@gail.com"
            };
            Dictionary<int, Contacts> objContactInsert = new Dictionary<int, Contacts>();

            objContactInsert.Add(4, contactFour);
            if (objContactInsert.ContainsKey(4) == true)
            {
                foreach (KeyValuePair<int , Contacts> contactkeyValuePair in objContactInsert)
                {
                    Contacts contTemp = contactkeyValuePair.Value;
                    Console.WriteLine("from edit   Key show={0} \n First Name={1} \n Last Name={2} \n Address={3} \n City={4} \n State={5} \n Zip={6} \n Phone={7} \n Email={8}", contactkeyValuePair.Key, contTemp.FirstName, contTemp.LastName, contTemp.Address, contTemp.City, contTemp.State, contTemp.Zip, contTemp.Phone, contTemp.Email);
                }
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("enter edited values");
                AddContact();
                //Console.WriteLine("1.first name \n 2.last name \n 3.address \n 4.city \n 5.state \n 6.zip \n 7.Phone \n 8.email \n");
                //int checkChoice = Convert.ToInt32(Console.ReadLine());
                //switch (checkChoice)
                //{
                //    case 1:
                //        Console.WriteLine("Enter Update:");
                //        string updateFirstName = Console.ReadLine();
                //        break;
                //}


            }
        }
    }
}
