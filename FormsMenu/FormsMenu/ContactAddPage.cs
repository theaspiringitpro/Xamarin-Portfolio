using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactAddPage : ContentDemoPage
    {
        private readonly ContactRepository _database;
        private readonly ContactListApp _parentPage;
        //View
        public ContactAddPage(ContactListApp parentPage, ContactRepository database)
        {
            _parentPage = parentPage;
            _database = database;

            //EntryCells
            var firstNameCell = new EntryCell {Label = "First Name:"};
            var lastNameCell = new EntryCell {Label = "Last Name:"};
            var typeCell = new EntryCell {Label = "Contact Type:"};
            var dateCell = new EntryCell { Label = "Date of Birth:" };

            //Save Btn
            var saveBtn = new Button
            {
                Text = "   Save Contact   ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            saveBtn.Clicked += async (sender, e) =>
            {
                var fName = firstNameCell.Text;
                var lName = lastNameCell.Text;
                var type = typeCell.Text;
                var date = dateCell.Text;

                //Validate Cells
                if (fName != null
                    || lName != null
                    || type != null
                    || date != null)
                {
                    _database.AddContact(fName, lName, date, type );
                    _parentPage.SortContacts();

                    //Clear Cells
                    firstNameCell.Text = string.Empty;
                    lastNameCell.Text = string.Empty;
                    typeCell.Text = string.Empty;
                    dateCell.Text = string.Empty;
                }
                else
                {
                    await DisplayAlert
                        ("Warning", "Please Fill In All Fields", "OK");
                }
            };

            //Return Btn
            var returnBtn = new Button
            {
                Text = "       Return      ",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            returnBtn.Clicked += async (sender, args) => { await Navigation.PopAsync(); };

            //Create TableView
            var tableView = new TableView
            {
                HeightRequest = 275,
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection("Add a New Contact")
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
                Children = {saveBtn, returnBtn}
            };

            //Build Main Page
            var main = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {tableView, btnLayout}
            };

            Content = main;
        }
    }
}