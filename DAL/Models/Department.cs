using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Department : BaseModel
    {
        [Required(ErrorMessage ="code is required")]
        public string Code { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
