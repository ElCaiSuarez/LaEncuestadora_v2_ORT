using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Encuestadora_Identity2.Models
{
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo encuesta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloEncuesta { get; set; }

        [Display(Name = "Fecha creación")]
        [DataType(DataType.Date)]
        public DateTime datetimeCreacionEncuesta { get; set; }

        [Display(Name = "Fecha vencimiento")]
        [DataType(DataType.Date)]
        public DateTime datetimeVencimientoEncuesta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PuntosEncuesta
        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public PuntosEncuesta puntosEncuesta { get; set; }

        //reference navigation property de CLIENTE
        [ForeignKey("ClienteId")]
        public virtual string ApplicationUserId { get; set; }
        
        //public virtual ApplicationUser ApplicationUser { get; set; }

        //RELACION 1 a N CON PREGUNTA (ENCUESTA es la entidad principal y PREGUNTA es la entidad dependiente)
        [Display(Name = "Preguntas")]
        public virtual ICollection<Pregunta> preguntas { get; set; }

        //CAMBIAMOS A ENCUESTA RESPONDIDA
        ////RELACION N a N CON USUARIO
        //[Display(Name = "EncuestasUsuarios")]
        //public ICollection<EncuestasUsuarios> EncuestasUsuarios { get; set; }




    }
}
