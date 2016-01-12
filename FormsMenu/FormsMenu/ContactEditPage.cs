using System.Linq;
using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactEditPage : ContentPage
    {
        private readonly App _app = Application.Current as App;
        private readonly ContactRepository _database;
        //View
        public ContactEditPage(ContactRepository database)
        {
            //Initialize
            _database = database;

            //Create EntryCells
            var firstNameCell = new EntryCell {Label = "First Name:"};
            var lastNameCell = new EntryCell {Label = "Last Name:"};
            var typeCell = new EntryCell {Label = "Contact Type:"};
            var dateCell = new EntryCell { Label = "Date of Birth:"};

            //Set DataBinding
            firstNameCell.SetBinding(EntryCell.TextProperty, "FirstName");
            lastNameCell.SetBinding(EntryCell.TextProperty, "LastName");
            typeCell.SetBinding(EntryCell.TextProperty, "Type");
            dateCell.SetBinding(EntryCell.TextProperty, "DateOfBirth");

            //Save Btn
            var saveBtn = new Button
            {
                Text = "   Save Contact   ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            saveBtn.Clicked += async (sender, args) =>
            {
                //Validate Text Fields
                if (firstNameCell.Text == string.Empty
                    || lastNameCell.Text == string.Empty
                    || typeCell.Text == string.Empty
                    || dateCell.Text == string.Empty)
                {
                    await DisplayAlert
                        ("Warning", "Please Fill In All Fields", "OK");
                }
                else
                {
                    //Saves Changes to Database
                    var contactItem = (Contact) BindingContext;
                    _database.SaveContact(contactItem);

                    await Navigation.PopAsync();
                    SortContacts();
                }
            };

            //Delete Btn
            var deleteBtn = new Button
            {
                Text = "  Delete Contact  ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            deleteBtn.Clicked += async (sender, e) =>
            {
                //Deletes Contact from Database
                var contactItem = (Contact) BindingContext;
                _database.DeleteContact(contactItem);

                await Navigation.PopAsync();
                SortContacts();
            };

            //Cancel Btn
            var cancelBtn = new Button
            {
                Text = "       Cancel       ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            cancelBtn.Clicked += async (sender, args) => { await Navigation.PopAsync(); };

            //Create TableView
            var tableView = new TableView
            {
                HeightRequest = 275,
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection("Edit/Delete a Contact")
                    {
                        firstNameCell,
                        lastNameCell,
                        dateCell,
                        typeCell
                    }
                }
            };

            //Build Button Layout
            var btnLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {saveBtn, deleteBtn, cancelBtn}
            };

            //Build Main Page
            var main = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {tableView, btnLayout}
            };

            Content = main;
        }

        private void SortContacts()
        {
            var contacts = _database.GetContacts();

            _app.ContactList.ItemsSource =
                contacts.OrderBy(x => x.LastName).ToList();
        }
    }
}