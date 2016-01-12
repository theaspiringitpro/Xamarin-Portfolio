using Xamarin.Forms;

namespace FormsMenu
{
    public class MenuPage : ContentPage
    {
        //View
        public MenuPage()
        {
            Title = "MasterDetailPage";
            Icon = "hamburger.png";

            Menu = new MenuListView();

            var menuLabel = new Label
            {
                Text = "MasterDetailPage",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            layout.Children.Add(menuLabel);
            layout.Children.Add(Menu);

            Content = layout;
        }
        
        public ListView Menu { get; private set; }
    }
}