﻿using System.Collections.Generic;

namespace ePicture.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get => "User"; }
        public IEnumerable<Picture> Pictures { get; set; }
    }
}
