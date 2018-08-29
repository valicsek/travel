using System;
using System.IO;
namespace Travel
{
    public class Config
    {
        static string dbName = "travel.sqlite";
        static string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static string databasePath = Path.Combine(folderPath, dbName);
    }
}
