using OjasTimeSheetManagement.Models;
using OjasTimeSheetManagemt.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OjasTimeSheetManagement.Concrete
{
    public class RolesConcrete : IRole<Role>
    {
        private DatabaseContext context;
        public RolesConcrete(DatabaseContext context)
        {
            this.context = context;
        }

        //public Role getRolesofUserbyRolename(Role Rolename)
        //{
        //     context.Role.Add(Rolename);
        //    context.SaveChanges();
        //    return Rolename;
        //}
        public bool AddRolename(Role Rolename)
        {
            context.Role.Add(Rolename);
            context.SaveChanges();
            return true;
        }
        
    }
}
