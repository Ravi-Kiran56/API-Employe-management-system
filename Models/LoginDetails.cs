using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ems.Models
{
    public class LoginDetails
    {
        [Key]public string EmpId {  get; set; }
        public string Password {  get; set; }
    }
}
