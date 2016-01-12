using System;
using System.IO;
using FormsMenu.iOS;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency(typeof (SQLite_iOS))]

namespace FormsMenu.iOS
{
    public class SQLite_iOS : ISQLite
    {
        #region ISQLite implementation

        public SQLiteConnection GetConnection()
        {
            var fileName = "contactDB.db3"; //Actual FileName "contactDatabase.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            ////New
            //if (!File.Exists(path))
            //{
            //    File.Copy(fileName, path);
            //}

            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);

            return connection;
        }

        #endregion
    }
}