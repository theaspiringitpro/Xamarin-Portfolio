using Xamarin.Forms;

namespace FormsMenu
{
    public class LocalImageDemoPage : ContentPage
    {
        //View
        public LocalImageDemoPage()
        {
            var heading = new Label
            {
                Text = "Local Image",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var image = new Image
            {
                Source = "zexample.png",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var mainLayout = new StackLayout
            {
                Children =
                {
                    heading,
                    image
                }
            };

            Content = mainLayout;
        }
    }
}