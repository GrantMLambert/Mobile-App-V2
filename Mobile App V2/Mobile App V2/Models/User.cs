using SQLite;

namespace Mobile_App_V2.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string UserName { get; set; }

        public string name { get; set; }

    }
}
