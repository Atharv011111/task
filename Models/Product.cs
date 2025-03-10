﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Task1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
    }
}
