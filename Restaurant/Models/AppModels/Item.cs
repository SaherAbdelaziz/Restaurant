using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Restaurant.Models.AppModels
{
    public class Item
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name1 { get; set; }

        [StringLength(150)]
        public string Name2 { get; set; }


        [Column(TypeName = "image")]
        public byte[] ImageItem { get; set; }

        public double? StaticPrice { get; set; }

        [StringLength(200)]
        public string Description1 { get; set; }

        [StringLength(200)]
        public string Description2 { get; set; }

        public DateTime? CreateDate { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }


}