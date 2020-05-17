using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraBlazor.Entidades
{
    public class Aritmetica
    {
        [Required(ErrorMessage ="El campo Primer Numero no puede estar vacio.")]
        public double numero1 { get; set; }
        [Required(ErrorMessage = "Este campo Segundo Numero no puede estar vacio.")]
        public double numero2 { get; set; }
        public double resultadoSuma { get; set; }
        public double resultadoResta { get; set; }
        public double resultadoMultiplicacion { get; set; }

        public Aritmetica()
        {
            numero1 = 0;
            numero2 = 0;
            resultadoSuma = 0;
            resultadoResta = 0;
            resultadoMultiplicacion = 0;
        }
        
    }
}
