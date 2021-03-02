using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Product.name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Product.price")]
        public float price { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Product.img")]
        public string img { get; set; }
    }
}