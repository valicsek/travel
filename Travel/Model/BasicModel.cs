using System;
using SQLite;

namespace Travel.Model
{
    public abstract class BasicModel<T>
    {                                 
        public static bool Insert(T model)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<T>();
                int rows = conn.Insert(model);
                if (rows > 0) return true;
            }
            return false;
        }

        public static bool Delete(T model)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<T>();
                int rows = conn.Delete(model);
                if (rows > 0) return true;
            }
            return false;
        }
    }
}
