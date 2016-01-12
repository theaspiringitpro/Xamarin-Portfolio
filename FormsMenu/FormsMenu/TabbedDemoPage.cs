using Xamarin.Forms;

namespace FormsMenu
{
    public class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo()
        {
            Children.Add(new BoxViewDemoPage {Title = "BoxView"});

            Children.Add(new NavigationDemoPage {Title = "NavigationPage"});

            Children.Add(new ScrollViewDemoPage {Title = "ScrollView"});

            Children.Add(new StopWatchApp {Title = "StopWatch"});

            Children.Add(new ContentDemoPage { Title = "Content" });
        }
    }
}