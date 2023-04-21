﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string? Detail1 { get; set; }
        public string? Detail2 { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
