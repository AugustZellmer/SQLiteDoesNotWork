using Microsoft.Data.Sqlite;

namespace Broken
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var db = new SqliteConnection("Data Source=testDB.sqlite");
            db.Open();
        }
    }
}
