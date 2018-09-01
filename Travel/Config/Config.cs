using System;
using System.IO;
namespace Travel
{
    public class Config
    {
        static string dbName = "travel.sqlite";
        static string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static string databasePath = Path.Combine(folderPath, dbName);
        public static string exampleProfileApiRequest = "https://reqres.in/api/users";
        public static TimeSpan timeoutInSeconds = TimeSpan.FromSeconds(10);
    }
}
