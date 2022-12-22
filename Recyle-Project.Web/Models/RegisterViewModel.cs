using System.ComponentModel.DataAnnotations;

namespace Recyle_Project.Web.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(6, ErrorMessage = "Password can be min 6 characters.")]
    [MaxLength(8, ErrorMessage = "Password can be max 8 characters.")]
    public string Password { get; set; }
    public string WalletName { get; set; }
    
    [Required]
    [Compare(nameof(Password))]
    
    public string RePassword { get; set; }
    [Required(ErrorMessage = "Name Surname is required")]
    public string phoneNumber { get; set; }



}
