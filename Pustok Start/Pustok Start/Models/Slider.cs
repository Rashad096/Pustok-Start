﻿using System.ComponentModel.DataAnnotations;

namespace Pustok_Start.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title1 { get; set; }
        [MaxLength(35)]

        public string Title2 { get; set; }
        [MaxLength(150)]

        public string Description { get; set; }
        [Required]
        [MaxLength(100)]

        public string Image { get; set; }
        [MaxLength(50)]


        public string BtnText { get; set; }
        [MaxLength(250)]

        public string BtnUrl { get; set; }
    }
}
