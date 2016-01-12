using Xamarin.Forms;

namespace FormsMenu
{
    public class ContentDemoPage : ContentPage
    {
        //View
        public ContentDemoPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "ContentPage",
                        HorizontalOptions = LayoutOptions.Center,
                        FontSize = 50,
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic // <-- Added for cohesiveness
                    },
                    new Label
                    {
                        Text = "ContentPage is the simplest type of page.\n" +
                               "\nThe content of a ContentPage is generally a layout" +
                               " of some\n" + "sort that can then be a parent to " +
                               "multiple children.\n" + "\nThis ContentPage contains " +
                               "a StackLayout, which in turn\n" + "contains four Label views" +
                               " (including the large one at the top)",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label))
                    }
                }
            };
        }
    }
}