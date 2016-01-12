using System;
using Xamarin.Forms;

namespace FormsMenu
{
    public class DownloadImageDemoPage : ContentPage
    {
        //View
        public DownloadImageDemoPage()
        {
            var heading = new Label
            {
                Text = "Download Image",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var webImage = new Image
            {
                Source = ImageSource.FromUri(new Uri
                    ("https://xamarin.com/content/images/pages/branding/assets/xamarin-logo.png")),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var mainLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    heading,
                    webImage
                }
            };

            Content = mainLayout;
        }
    }
}