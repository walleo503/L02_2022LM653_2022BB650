using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02_2022LM653_2022BB650.Models
{
    public class pedidoEncabezado
    {
       
        [Key]
        public int id { get; set; }

        [ForeignKey("clientes")]
        public int id_cliente { get; set; }
        public clientes cliente { get; set; } 

        public int cantidad_libros { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal total { get; set; }

        [Required]
        [StringLength(1)]
        public string estado { get; set; } = "P"; 
    }
}
