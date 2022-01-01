using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroup
    {
        [Key]
        public int GroupID { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکترهای {0} نمیتواند بیشتر از {1} باشد")]
        public string GroupTitle { get; set; }

        public virtual List<Page> Pages { get; set; }
        public PageGroup()
        {

        }
    }
}
