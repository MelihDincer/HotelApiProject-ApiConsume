using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Zorunludur!")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Şifre Girmeniz Zorunludur!")]
        public string? Password { get; set; }
    }
}
