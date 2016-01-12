using System.Collections.Generic;

namespace FormsMenu
{
    public class MenuListData : List<MenuItem>
    {
        //Model
        public MenuListData()
        {
            Add(new MenuItem
            {
                Name = "Box View Page",
                DetailPage = typeof (BoxViewDemoPage)
            });

            Add(new MenuItem
            {
                Name = "Content Page",
                DetailPage = typeof (ContentDemoPage)
            });

            Add(new MenuItem
            {
                Name = "Image Page",
                DetailPage = typeof (DownloadImageDemoPage)
            });

            Add(new MenuItem
            {
                Name = "Label Page",
                DetailPage = typeof (LabelPage)
            });

            Add(new MenuItem
            {
                Name = "Stop Watch App",
                DetailPage = typeof (StopWatchApp)
            });
        }
    }
}