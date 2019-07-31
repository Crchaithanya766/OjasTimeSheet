using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OjasTimeSheetManagement.Models;
using OjasTimeSheetManagemt.Interface;

namespace OjasTimeSheetManagement.Controllers
{
    public class RoleController : Controller
    {
        private IRole<Role> _role;

        public RoleController(IRole<Role> role)
        {
            _role = role;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Role obj)
        {
            var data = _role.AddRolename(obj);
            return View("Index");
        }
        
        public IActionResult Index()
        {
            return View();
        }

    }
}