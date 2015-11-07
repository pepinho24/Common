﻿namespace WebApiTemplate.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SampleClass
    {
        [Key]
        public int SampleId { get; set; }

        [MinLength(21)]
        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
