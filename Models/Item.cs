using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    public class Item
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Product")]
        public int idProduct { get; set; }

        [Required(ErrorMessage = "Esse campo é orbigatório Item.name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Item.price")]
        public float price { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Item.quantity")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Item.img")]
        public string img { get; set; }
    }

}