using crudTest.Models;
using crudTest.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Controllers
{
    public class ContentController:Controller
    {
        private ContentService contentService;

        public ContentController(ContentService _contentService)
        {
            this.contentService = _contentService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult GetContentList()
        {
            try
            {
                List<Content> contents = contentService.ContentList();
                return Json(contents);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
