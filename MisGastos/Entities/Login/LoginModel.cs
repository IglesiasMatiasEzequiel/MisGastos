using System.ComponentModel.DataAnnotations;

namespace MisGastos.Entities
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}