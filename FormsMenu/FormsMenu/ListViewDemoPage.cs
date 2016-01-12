using System.Linq;
using Xamarin.Forms;

namespace FormsMenu
{
    public class ListViewDemoPage : ContentPage
    {
        private readonly App _app = Application.Current as App;
        private readonly ContactRepository _database;
        //View
        public ListViewDemoPage(ContactRepository database)
        {
            _database = database;

            //Heading
            var heading = new Label
            {
                Text = "Contacts",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Start,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            //Setup ListView
            var contacts = _database.GetContacts();
            _app.ContactList = new ListView
            {
                //To fit custom ViewCell
                RowHeight = 96,
                
                ItemsSource = contacts.OrderBy(x => x.LastName).ToList(),
                ItemTemplate = new DataTemplate(typeof (ContactCell))
            };

            //Setup Bindings
            //_app.ContactList.ItemTemplate.SetBinding(TextCell.TextProperty, "FullName");
            //_app.ContactList.ItemTemplate.SetBinding(TextCell.DetailProperty, "Type");

            //Build Page
            var main = new StackLayout
            {
                Children =
                {
                    heading,
                    _app.ContactList
                }
            };

            Content = main;
        }
    }
}