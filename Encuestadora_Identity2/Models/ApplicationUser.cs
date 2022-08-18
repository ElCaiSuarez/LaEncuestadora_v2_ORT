using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Encuestadora_Identity2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Custom Tag")]
        [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string CustomTag { get; set; }

        [Display(Name = "Nombre Completo")]
        [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string Nombre { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PrecioCliente
        [Display(Name = "Membresia")]
        [EnumDataType(typeof(PrecioCliente))]
        public PrecioCliente precioCliente { get; set; }

        [Display(Name = "Puntos Acumulados")]
        public int puntosAcumulados { get; set; }
        public void sumarPuntosEncuesta(int puntosRecibidos)
        {
            this.puntosAcumulados += puntosRecibidos;
        }

        //RELACION 1 a N CON ENCUESTA (CLIENTE es la entidad principal y ENCUESTA es la entidad dependiente)
        [Display(Name = "Encuestas")]
        public virtual ICollection<Encuesta> encuestas { get; set; }


    }
}
