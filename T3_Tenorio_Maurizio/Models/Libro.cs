using System.ComponentModel.DataAnnotations;

namespace T3_Tenorio_Maurizio.Models
{
    public class Libro
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El tema es obligatorio")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "El editorial es obligatorio")]
        public string Editorial { get; set; }


        [Required(ErrorMessage = "El Anio es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El anio debe ser entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "La categoria es obligatorio")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El Material es obligatorio")]
        public string Material { get; set; }


        [Required(ErrorMessage = "La pagina es obligatorio")]
        [Range(10, 1000, ErrorMessage = "Las paginas deben ser entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La copia es obligatorio")]
        [Range(1, 20, ErrorMessage = "Las copias deben ser entre 1 y 20")]
        public int Copias { get; set; }


    }
}