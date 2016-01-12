using SQLite.Net;

namespace FormsMenu
{
    //Interface
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}