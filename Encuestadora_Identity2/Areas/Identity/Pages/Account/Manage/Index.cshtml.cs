using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Encuestadora_Identity2.Data;
//AGREGADO
using Encuestadora_Identity2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Encuestadora_Identity2.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        
        //MODIFICADO
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        //AGREGADO
        private readonly ApplicationDbContext _context;

        //MODIFICADO
        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //AGREGADO
            _context = context;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Telefono(Opcional)")]
            public string PhoneNumber { get; set; }
            //AGREGADO
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Custom Tag")]
            public string CustomTag { get; set; }

            //AGREGADO
            [Required]
            [DataType(DataType.Text)]
            [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
            [Display(Name = "Nombre completo")]
            public string Nombre { get; set; }

            //AGREGADO
            [Required]
            [Display(Name = "Membresia")]
            [EnumDataType(typeof(PrecioCliente))]
            public PrecioCliente PrecioCliente { get; set; }

        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                //AGREGADO
                CustomTag = user.CustomTag,
                Nombre = user.Nombre,
                PrecioCliente = user.precioCliente
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            //AGREGADO
            var usuario = _context.usuarios.Single(u => u.UserName == user.UserName);
            ViewData["PuntosAcumulados"] = usuario.puntosAcumulados;
            ViewData["CustomTag"] = usuario.CustomTag;
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            //AGREGADO
            if (Input.CustomTag != user.CustomTag)
            {
                user.CustomTag = Input.CustomTag;
            }
            if (Input.Nombre != user.Nombre)
            {
                user.Nombre = Input.Nombre;
            }
            if (Input.PrecioCliente != user.precioCliente)
            {
                user.precioCliente = Input.PrecioCliente;
            }
            //AGREGADO
            await _userManager.UpdateAsync(user);
            
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Su perfil fue actualizado";
            return RedirectToPage();
        }
    }
}
