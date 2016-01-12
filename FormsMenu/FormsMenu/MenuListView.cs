using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsMenu
{
    public class MenuListView : ListView
    {
        //ViewModel
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;

            var cell = new DataTemplate(typeof (TextCell));
            cell.SetBinding(TextCell.TextProperty, "Name");

            ItemTemplate = cell;
        }
    }
}