using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public Client client { get; set; }

        public List<Item> items { get; set; }
    }
}