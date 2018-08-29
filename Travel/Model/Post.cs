using System;
using SQLite;

namespace Travel.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Experience{ get;set; }

        public Post()
        {
        }
    }
}
