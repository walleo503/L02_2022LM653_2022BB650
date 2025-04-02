using System.ComponentModel.DataAnnotations;

namespace L02_2022LM653_2022BB650.Models
{
    public class clientes
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string apellido { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string email { get; set; }

        [StringLength(255)]
        public string direccion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_at { get; set; } = DateTime.Now;
    }
}
