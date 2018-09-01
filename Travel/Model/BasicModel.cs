using SQLite;
using Travel.Model.Interfaces;

namespace Travel.Model
{
    public abstract class BasicModel<T>: Bindable, IModelService<T>
    {                                 
        public bool Save()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<T>();
                int rows = conn.Insert(this);
                if (rows > 0) return true;
                conn.Close();
            }
            return false;
        }

        public bool Delete()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<T>();
                int rows = conn.Delete(this);
                if (rows > 0) return true;
                conn.Close();
            }
            return false;
        }

        public bool Edit()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<T>();
                int rows = conn.Update(this);
                if (rows > 0) return true;
                conn.Close();
            }
            return false;
        }
    }
}
