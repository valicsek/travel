using System;
using System.Collections.Generic;

namespace Travel.Model
{
    public class Data
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string A { get; set; }
    }

    public class RootObject
    {
        public List<Data> Data { get; set; }
    }
}
