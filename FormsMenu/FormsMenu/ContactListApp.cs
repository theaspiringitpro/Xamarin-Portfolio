using System.Linq;
using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactListApp : ContentPage
    {
        private readonly App _app = Application.Current as App;
        private readonly ContactRepository _database;
        //View
        public ContactListApp(ContactRepository database)
        {
            //Initialize
            _database = database;

            //Heading
            var heading = new Label
            {
                Text = "Contact List",
                FontSize = 50,
                HorizontalOptions = LayoutOptions.Start,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            //Buttons
            var contactBtn = new Button
            {
                Text = "Add Contact",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };

            //ButtonEventHandler
            contactBtn.Clicked += async (sender, args) =>
            {
                await Navigation
                    .PushAsync(new ContactAddPage(this, database));
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

            //Set Bindings (Bindings set within ContactCell for this project)
            //_app.ContactList.ItemTemplate.SetBinding(ContactCell.FirstNameProperty, "FirstName");
            //_app.ContactList.ItemTemplate.SetBinding(ContactCell.LastNameProperty, "FirstName");
            //_app.ContactList.ItemTemplate.SetBinding(ContactCell.TypeProperty, "Type");
            //_app.ContactList.ItemTemplate.SetBinding(ContactCell.DateProperty, "DateOfBirth");
            
            //ItemSelected Event Handler
            _app.ContactList.ItemSelected += async (sender, e) =>
            {
                var selectedContact = (Contact) e.SelectedItem;
                var editPage = new ContactEditPage(database)
                {
                    BindingContext = selectedContact
                };

                if (selectedContact == null) return;
                await Navigation.PushAsync(editPage);
                _app.ContactList.SelectedItem = null;
            };
            
            //Heading Layout
            var headingLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    heading,
                    contactBtn
                }
            };
            
            //Build Main Page
            var main = new StackLayout
            {
                Children =
                {
                    headingLayout,
                    _app.ContactList
                }
            };
            Content = main;
        }

        public void SortContacts()
        {
            var contacts = _database.GetContacts();

            _app.ContactList.ItemsSource =
                contacts.OrderBy(x => x.LastName).ToList();
        }
    }
}