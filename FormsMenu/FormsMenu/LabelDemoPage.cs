using Xamarin.Forms;

namespace FormsMenu
{
    public class LabelPage : ContentPage
    {
        //View
        public LabelPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Label",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = 50,
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
                    },
                    new Label
                    {
                        Text = "Xamarin.Forms is a cross-plaform natively " +
                               "backed UI " + "toolkit abstraction that " +
                               "allows developers to easily  " + "create " +
                               "user interfaces that can be shared across " +
                               "Android, iOS, and Windows Phone.",
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof (Label))
                    }
                }
            };
        }
    }
}