using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace FormsMenu
{
    //Model
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string DateOfBirth { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}