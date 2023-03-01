﻿namespace CleanArchitecture.Infrastracture.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public List<Book>? Books { get; set;}
    }
}