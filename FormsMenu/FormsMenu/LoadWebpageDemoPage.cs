using Xamarin.Forms;

namespace FormsMenu
{
    public class LoadWebpageDemoPage : ContentPage
    {
        //View
        public LoadWebpageDemoPage()
        {
            var heading = new Label
            {
                Text = "Webpage",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var webExample = new WebView
            {
                Source = "https://xamarin.com/branding",
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var mainLayout = new StackLayout
            {
                Children =
                {
                    heading,
                    webExample
                }
            };

            Content = mainLayout;
        }
    }
}