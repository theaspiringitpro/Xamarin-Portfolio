using Xamarin.Forms;

namespace FormsMenu
{
    public class BoxViewDemoPage : ContentPage
    {
        //View
        public BoxViewDemoPage()
        {
            var heading = new Label
            {
                Text = "BoxView",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var boxView = new BoxView
            {
                Color = Color.Red,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var mainLayout = new StackLayout
            {
                Children =
                {
                    heading,
                    boxView
                }
            };

            Content = mainLayout;
        }
    }
}