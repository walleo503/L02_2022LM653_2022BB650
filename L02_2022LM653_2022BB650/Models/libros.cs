using System.ComponentModel.DataAnnotations;

namespace L02_2022LM653_2022BB650.Models
{
    public class libros
    {

        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nombre { get; set; }

        [StringLength(255)]
        public string descripcion { get; set; }

        [StringLength(255)]
        public string url_imagen { get; set; }

        public int id_autor { get; set; }
        public int id_categoria { get; set; }

        [Required]
        public decimal precio { get; set; }

        [Required]
        public char estado { get; set; }


    }
}
