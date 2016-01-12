using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactRepository
    {
        private static readonly object Locker = new object();
        private readonly SQLiteConnection _dBconnection;
        //Repository
        public ContactRepository()
        {
            //Initialize Connection with Database
            _dBconnection = DependencyService.Get<ISQLite>().GetConnection();

            //Create Contact Table
            _dBconnection.CreateTable<Contact>();

            lock (Locker)
            {
                //Checks if database empty
                //if so, fills with default contacts
                if (!_dBconnection.Table<Contact>().Any())
                {
                    Contact contact;

                    #region Populate Default Contact List

                    contact = new Contact
                    {
                        FirstName = "Avery",
                        LastName = "Jenkins",
                        Type = "Work",
                        DateOfBirth = "11/23/1975"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Brad",
                        LastName = "Pitt",
                        Type = "Friend",
                        DateOfBirth = "3/15/1971"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Barry",
                        LastName = "Zito",
                        Type = "Family",
                        DateOfBirth = "6/4/1983"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Jack",
                        LastName = "Sparrow",
                        Type = "Family",
                        DateOfBirth = "1/15/1965"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Kyle",
                        LastName = "Broflofsky",
                        Type = "School",
                        DateOfBirth = "8/10/1999"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Fred",
                        LastName = "Durst",
                        Type = "Work",
                        DateOfBirth = "12/4/1972"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Marissa",
                        LastName = "Lopez",
                        Type = "Friend",
                        DateOfBirth = "9/1/1986"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Michael",
                        LastName = "Jackson",
                        Type = "Work",
                        DateOfBirth = "8/29/1958"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Stephon",
                        LastName = "Diggs",
                        Type = "Work",
                        DateOfBirth = "11/23/1993"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Gary",
                        LastName = "Buesey",
                        Type = "School",
                        DateOfBirth = "3/14/1953"

                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Kyle",
                        LastName = "Lobb",
                        Type = "Family",
                        DateOfBirth = "5/6/1986"
                    };
                    _dBconnection.Insert(contact);

                    contact = new Contact
                    {
                        FirstName = "Jessica",
                        LastName = "Alba",
                        Type = "School",
                        DateOfBirth = "4/12/1979"
                    };
                    _dBconnection.Insert(contact);

                    #endregion
                }
            }
        }

        public IEnumerable<Contact> GetContacts()
        {
            lock (Locker)
            {
                return (from t in _dBconnection.Table<Contact>()
                    select t).ToList();
            }
        }
        
        public int DeleteContact(Contact contact)
        {
            lock (Locker)
            {
                return _dBconnection.Delete<Contact>(contact.Id);
            }
        }
        //Not used, for testing purposes only
        public void DeteteAllItems()
        {
            lock (Locker)
            {
                _dBconnection.DropTable<Contact>();
                _dBconnection.CreateTable<Contact>();
            }
        }

        public int SaveContact(Contact contact)
        {
            lock (Locker)
            {
                if (contact.Id != 0)
                {
                    _dBconnection.Update(contact);
                    return contact.Id;
                }
                return _dBconnection.Insert(contact);
            }
        }

        public void AddContact(string firstName, string lastName, string type, string date)
        {
            var newContact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Type = type,
                DateOfBirth = date
                
            };
            lock (Locker)
            {
                _dBconnection.Insert(newContact);
            }
        }
    }
}