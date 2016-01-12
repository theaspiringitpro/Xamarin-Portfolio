using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsMenu
{
    //This version of the masterdetailpagedemo combines all classes into one.
    //
    //The navigation bar button will correctly slide out the master detail menu
    //if app.cs main page navigation is modified to load a MasterDetailPageDemo object.
    //
    //Not currently in use within FormsMenu due to xamarin/android limitations.
    public class MasterDetailPageDemo : MasterDetailPage
    {
        private class DetailPageContent
        {
            public string Name { private set; get; }
            public Type DetailPage { private set; get; }
            
            public DetailPageContent(string name, Type detailPage)
            {
                Name = name;
                DetailPage = detailPage;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public MasterDetailPageDemo()
        {
            //ListData
            var menuData = new List<DetailPageContent>
            {
                new DetailPageContent("Box View Page", typeof (BoxViewDemoPage)),
                new DetailPageContent("Content Page", typeof (ContentDemoPage)),
                new DetailPageContent("Image Page", typeof (DownloadImageDemoPage)),
                new DetailPageContent("Label Page", typeof (LabelPage)),
                new DetailPageContent("Stop Watch App", typeof (StopWatchApp))
            };

            //Create MenuListView
            var detailMenuView = new ListView
            {
                ItemsSource = menuData,
            };

            //Create new TapGesture
            var tap = new TapGestureRecognizer();
            tap.Tapped += (sender, args) => { IsPresented = true; };

            //Click/tap eventhandler
            detailMenuView.ItemSelected += (sender, args) =>
            {
                var detailItem = (DetailPageContent) args.SelectedItem;
                
                DetailPageContent detailList =
                    new DetailPageContent(detailItem.Name, detailItem.DetailPage);

                ContentPage page = 
                    (ContentPage) Activator.CreateInstance(detailList.DetailPage);

                Detail = page;
                page.Content.GestureRecognizers.Add(tap);

                IsPresented = false;
            };

            //Set Homepage Detail
            var home = new BoxViewDemoPage();
            Detail = home;
            home.Content.GestureRecognizers.Add(tap);

            //BuildPage
            Master = new ContentPage
            {
                Title = "MasterPage",
                Content = new StackLayout
                {
                    Children = { detailMenuView }
                }

            };
        }
    }
}
