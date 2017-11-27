using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToolNguyenIT.Controllers
{
    public class TiengVietController : Controller
    {
        // GET: /<controller>/
        [Route("chuyen-doi-tieng-viet-thanh-tieq-viet")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Convert(string text)
        {
            text = text.Replace("Ch", "C");
            text = text.Replace("ch", "c");
            text = text.Replace("Tr", "C");
            text = text.Replace("tr", "c");
            text = text.Replace("Đ", "D");
            text = text.Replace("đ", "d");
            text = text.Replace("Gh", "G");
            text = text.Replace("gh", "g");
            text = text.Replace("Ph", "F");
            text = text.Replace("ph", "f");
            text = text.Replace("C", "K");
            text = text.Replace("c", "k");
            text = text.Replace("Q", "k");
            text = text.Replace("q", "k");
            text = text.Replace("Ng", "Q");
            text = text.Replace("ng", "q");
            text = text.Replace("Ngh", "Ngh");
            text = text.Replace("ngh", "ngh");
            text = text.Replace("Kh", "X");
            text = text.Replace("kh", "x");
            text = text.Replace("Th", "W"); 
            text = text.Replace("th", "w");
            text = text.Replace("D", "Z");
            text = text.Replace("d", "z");
            text = text.Replace("Gi", "Z");
            text = text.Replace("gi", "z");
            text = text.Replace("R", "Z");
            text = text.Replace("r", "z");
            text = text.Replace("Nh", "N'");
            text = text.Replace("nh", "n'");
            return Json(text);
        }
    }
}
