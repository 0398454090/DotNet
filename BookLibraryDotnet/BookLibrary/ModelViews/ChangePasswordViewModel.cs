using System.ComponentModel.DataAnnotations;

namespace BookLibrary.ModelViews
{
    public class ChangePasswordViewModel
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Mật khẩu hiện tại")]
        public string PasswordNow { get; set; }

        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới")]
        [MinLength(5, ErrorMessage = "Mật khẩu mới phải có ít nhất 5 ký tự")]
        public string Password { get; set; }

        [Display(Name = "Nhập lại mật khẩu mới")]
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [MinLength(5, ErrorMessage = "Mật khẩu mới phải có ít nhất 5 ký tự")]
        [Compare("Password", ErrorMessage = "Mật khẩu mới và mật khẩu xác nhận không khớp")]
        public string ConfirmPassword { get; set; }
    }
}
