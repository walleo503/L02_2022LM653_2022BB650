using System.ComponentModel.DataAnnotations;

namespace L02_2022LM653_2022BB650.Models
{
    public class pedido_detalle
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int id_pedido { get; set; }

        [Required]
        public int id_libro { get; set; }

        public DateTime created_at { get; set; } = DateTime.Now;
    }
}
