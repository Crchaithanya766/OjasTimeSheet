using OjasTimeSheetManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OjasTimeSheetManagemt.Interface
{
    public interface IRole<T>
    {
        bool AddRolename(Role Rolename);
        
    }
}
