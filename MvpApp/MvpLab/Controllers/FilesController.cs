using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MvpLab.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            
            return View(Directory.EnumerateFiles(Server.MapPath("~/TextFiles")));
        }

        public new ActionResult Content(string id)
        {
           
            string path = Server.MapPath("~/TextFiles/" + "/" + id + ".txt");
            try
            {
                System.Collections.IEnumerable contents = System.IO.File.ReadLines(path);
                return View(contents);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
            };
            return View();
        }
    }
}