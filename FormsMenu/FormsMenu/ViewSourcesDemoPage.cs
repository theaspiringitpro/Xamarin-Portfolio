using Xamarin.Forms;

namespace FormsMenu
{
    public class ViewSourcesDemoPage : ContentPage
    {
        //View
        public ViewSourcesDemoPage()
        {
            var heading = new Label
            {
                Text = "BoxView, Images, and Webpages",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var boxViewButton = new Button
            {
                Text = "BoxView",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            var localButton = new Button
            {
                Text = "Local Image",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            var downloadButton = new Button
            {
                Text = "Download Image",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            var webButton = new Button
            {
                Text = "WebPage",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            //Button Event Handlers
            boxViewButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new BoxViewDemoPage()); };

            localButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new LocalImageDemoPage()); };

            downloadButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new DownloadImageDemoPage()); };

            webButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new LoadWebpageDemoPage()); };

            //Build Button Layout
            var buttonLayout = new StackLayout
            {
                Children =
                {
                    boxViewButton,
                    localButton,
                    downloadButton,
                    webButton
                }
            };
            //Build Main Page
            var mainLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    heading,
                    buttonLayout
                }
            };

            Content = mainLayout;
        }
    }
}