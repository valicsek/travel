using System;
using SQLite;

namespace Travel.Model
{
    public class Post : Bindable
    {
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set
            {
                this.id = value;
                OnPropertyChanged("Id");
            }
        }

        private string experience;
        [MaxLength(200)]
        public string Experience
        {
            get { return experience; }
            set
            {
                this.experience = value;
                OnPropertyChanged("Experience");
            }
        }

    }
}
