using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Client.name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Client.email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório Client.tel")]
        public string tel { get; set; }
    }
}