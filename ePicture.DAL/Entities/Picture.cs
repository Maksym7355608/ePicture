﻿using System.Collections.Generic;

namespace ePicture.DAL.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }

    public enum Category
    {
        Renaissance,
        Mannerism,
        Baroque,
        Classicism,
        Romanticism,
        Impressionism,
        Expressionism,
        Avantgard,
        Modern,
        Postmodern
    }
}
