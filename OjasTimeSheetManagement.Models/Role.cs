using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OjasTimeSheetManagement.Models
{
    public class Role
    {
        [Key]

        public int RoleID { get; set; }
        public string Rolename { get; set; }
    }
}
