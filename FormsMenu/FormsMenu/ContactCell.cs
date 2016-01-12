using Xamarin.Forms;

namespace FormsMenu
{
    class ContactCell : ViewCell
    {
        public ContactCell()
        {
            var fNameLabel = new Label()
            {
                TextColor = Color.FromHex("32b1e0"),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof (Label)),
            };

            var lNameLabel = new Label()
            {
                TextColor = Color.FromHex("32b1e0"),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            var typeLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };

            var dateLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            };
            
            fNameLabel.SetBinding(Label.TextProperty, "FirstName");
            lNameLabel.SetBinding(Label.TextProperty, "LastName");
            dateLabel.SetBinding(Label.TextProperty, "DateOfBirth");
            typeLabel.SetBinding(Label.TextProperty, "Type");

            StackLayout cellWrapper = new StackLayout();
            StackLayout nameLayout = new StackLayout();
            StackLayout detailsLayout = new StackLayout();

            nameLayout.Orientation = StackOrientation.Horizontal;
            nameLayout.Padding = new Thickness(0, 0, 0, 3);
            nameLayout.Children.Add(fNameLabel);
            nameLayout.Children.Add(lNameLabel);

            detailsLayout.Padding = new Thickness(0, 0, 0, 3);
            detailsLayout.Spacing = 10;
            detailsLayout.Children.Add(dateLabel);
            detailsLayout.Children.Add(typeLabel);
            
            cellWrapper.Padding = new Thickness(20, 9, 0, 10);
            cellWrapper.Children.Add(nameLayout);
            cellWrapper.Children.Add(detailsLayout);
            
            View = cellWrapper;
        }
    }
}
