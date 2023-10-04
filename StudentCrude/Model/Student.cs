﻿using System.ComponentModel.DataAnnotations;

namespace StudentCrude.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }
    }
}
