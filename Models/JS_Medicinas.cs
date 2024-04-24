using System.ComponentModel.DataAnnotations;

namespace JulianaSosa_Examen1P.Models
{
    public class JS_Medicinas
    {
        [Required]
        public int JS_MedicinasID {  get; set; }
        [MaxLength(20, ErrorMessage="Por favor ingresar hasta 20 caracteres"),MinLength(5)]
        public string? JS_DescripcionMedicina { get; set; }

        [Required]
        public DateTime JS_FechaDeEntrega { get; set; }
         
        public bool JS_ConReceta {  get; set; }

        
    }
}
