﻿namespace LibraryManagementSys.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool IsAvilable { get; set; }
        public string Custodian { get; set; }


    }
}
