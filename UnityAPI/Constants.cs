using SQLite;

namespace UnityAPI
{
    public static class Constants
    {
        public static readonly SQLiteConnection Connection = DbConnection.Instance.Connection;
    }
}