using System;
using Xamarin.Forms;

namespace FormsMenu
{
    public class XFormsMenuPage : ContentPage
    {
        //View
        public XFormsMenuPage()
        {
            //Create Database Object
            var database = new ContactRepository();

            Title = "Forms Menu";
            var pageCommand = new Command<Type>(async pageType =>
                {
                    var page = (Page) Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            #region TableView Content
            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Views for Presentation")
                    {
                        new TextCell
                        {
                            Text = "BoxView, Images, and Webpages",
                            Command = pageCommand,
                            CommandParameter = typeof (ViewSourcesDemoPage)
                        },
                        new TextCell
                        {
                            Text = "Label",
                            Command = pageCommand,
                            CommandParameter = typeof (LabelPage)
                        }
                    },
                    new TableSection("Views that Initiate Commands"),
                    new TableSection("Views for Common Data Types"),
                    new TableSection("Views for Editing Text"),
                    new TableSection("Views to Indicate Activity"),
                    new TableSection("Views that Display Collections"),
                    new TableSection("Layouts with Single Content")

                    {
                        new TextCell
                        {
                            Text = "ScrollView",
                            Command = pageCommand,
                            CommandParameter = typeof (ScrollViewDemoPage)
                        }
                    },
                    new TableSection("Layouts with Multiple Children")
                    {
                        new TextCell
                        {
                            Text = "StackLayout",
                            Command = pageCommand,
                            CommandParameter = typeof (StackLayoutDemoPage)
                        },
                        new TextCell
                        {
                            Text = "ListView",
                            Command = new Command(async() =>
                                await Navigation.PushAsync(new ListViewDemoPage(database)))
                        }
                    },
                    new TableSection("Pages")
                    {
                        new TextCell
                        {
                            Text = "ContentPage",
                            Command = pageCommand,
                            CommandParameter = typeof (ContentDemoPage)
                        },
                        new TextCell
                        {
                            Text = "NavigationPage",
                            Command = pageCommand,
                            CommandParameter = typeof (NavigationDemoPage)
                        },
                        new TextCell
                        {
                            Text = "TabbedPage",
                            Command = pageCommand,
                            CommandParameter = typeof (TabbedPageDemo)
                        },
                        new TextCell
                        {
                            Text = "MasterDetailPage",
                            Command = pageCommand,
                            CommandParameter = typeof (MasterDetailDemoPage)
                        }
                    },
                    new TableSection("Class Project Apps")
                    {
                        new TextCell
                        {
                            Text = "StopWatch App",
                            Command = pageCommand,
                            CommandParameter = typeof (StopWatchApp)
                        },
                        new TextCell
                        {
                            Text = "Contact List App",
                            Command = new Command(async () => 
                               await Navigation.PushAsync(new ContactListApp(database)))
                        }
                    }
                }
            };
            #endregion
        }
    }
}