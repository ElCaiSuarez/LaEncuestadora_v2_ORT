using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Encuestadora_Identity2.Models
{
    public class Pregunta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreguntaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo pregunta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloPregunta { get; set; }

        ////RELACIONES CON OTRAS ENTIDADES
        ////RELACION 1 a 1 CON TipoPregunta
        //[Required(ErrorMessage = "El {0} es requerido")]
        //[Display(Name = "Tipo pregunta")]
        //[EnumDataType(typeof(TipoPregunta))]
        //public TipoPregunta tipoPregunta { get; set; }

        //foreign key de ENCUESTA
        public int EncuestaId { get; set; }
        ////reference navigation property de ENCUESTA
        [ForeignKey("EncuestaId")]
        public virtual Encuesta Encuesta { get; set; }

        //RELACION 1 a N CON OPCIONPREGUNTA (PREGUNTA es la entidad principal y OPCIONPREGUNTA es la entidad dependiente)
        [Display(Name = "Opciones")]
        public virtual ICollection<OpcionPregunta> opciones { get; set; }

        //COMO RELACIONAR EL TIPO DE PREGUNTA CON EL INPUT DEL FORMULARIO???
    }
}
