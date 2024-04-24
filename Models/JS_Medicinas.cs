using System.ComponentModel.DataAnnotations;

namespace JulianaSosa_Examen1P.Models
{
    public class JS_Medicinas
    {
        [Required]
        public int JS_MedicinasID {  get; set; }
        [MaxLength(20, ErrorMessage="Por favor ingresar hasta 20 caracteres"),MinLength(5)]
        public string? JS_DescripcionMedicina { get; set; }
        [RequerirCantidad]
        public int cantidad {  get; set; }

        [Required]
        public DateTime JS_FechaDeEntrega { get; set; }
         //Prueba
        public bool JS_ConReceta {  get; set; }

        public class RequerirCantidad : ValidationAttribute
        {
            public override bool IsValid(object? value)
            {
                decimal valor = (int)value;
                if (valor <= 0)
                {
                    return false;

                }
                else
                {
                    return true;
                }
                //return base.IsValid(value);
            }

        }
    }
