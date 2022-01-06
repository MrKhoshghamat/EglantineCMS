using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminLogin
    {
        [Key]
        public int LoginID { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string  UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "تعداد کارکترهای {0} نمیتواند بیشتر از {1} باشد")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نمیباشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کارکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string Password { get; set; }
    }
}
