using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Controllers
{
    public class DataTableController : Controller
    {
        [ActionName("Index")]
        public IActionResult DataTableIndex()
        {
            return View("DataTableIndex");
        }
    }
}
