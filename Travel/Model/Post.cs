using System;
using SQLite;

namespace Travel.Model
{
    public class Post : BasicModel<Post>
    {
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get => id;
            set => SetField(ref id, value);
        }

        private string experience;
        [MaxLength(200)]
        public string Experience
        {
            get => experience;
            set => SetField(ref experience, value);
        }

    }
}
