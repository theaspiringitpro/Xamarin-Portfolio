using System;
using Xamarin.Forms;

namespace FormsMenu
{
    public class NavigationDemoPage : ContentPage
    {
        //View
        public NavigationDemoPage()
        {
            var heading = new Label
            {
                Text = "NavigationPage",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var labelPageButton = new Button
            {
                Text = "Label Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            labelPageButton.Clicked += OnLabelButtonClick;

            var scrollViewButton = new Button
            {
                Text = "ScrollView Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            scrollViewButton.Clicked += OnScrollButtonClick;

            var stackLayoutButton = new Button
            {
                Text = "StackLayout Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Button)),
                BorderWidth = 1
            };

            stackLayoutButton.Clicked += OnStackButtonClick;

            var buttonLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Start,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    labelPageButton,
                    scrollViewButton,
                    stackLayoutButton
                }
            };

            var mainLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    heading,
                    buttonLayout
                }
            };

            Content = mainLayout;
        }

        private void OnLabelButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LabelPage());
        }

        private void OnScrollButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewDemoPage());
        }

        private void OnStackButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutDemoPage());
        }
    }
}