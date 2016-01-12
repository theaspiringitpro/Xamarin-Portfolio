using System;
using Xamarin.Forms;

namespace FormsMenu
{
    public class MasterDetailDemoPage : MasterDetailPage
    {
        //View
        public MasterDetailDemoPage()
        {
            var menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) =>
                NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;

            var box = new BoxViewDemoPage();
            Detail = box;

            var tap = new TapGestureRecognizer();
            tap.Tapped += (sender, args) => { IsPresented = true; };

            box.Content.BackgroundColor = Color.Transparent;
            box.Content.GestureRecognizers.Add(tap);
        }

        private void NavigateTo(MenuItem menu)
        {
            var displayPage = (Page) Activator.CreateInstance(menu.DetailPage);

            Detail = displayPage;

            IsPresented = false;
        }
    }
}