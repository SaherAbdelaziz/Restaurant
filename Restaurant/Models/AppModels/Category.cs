using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models.AppModels
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

    }
}