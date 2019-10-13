using E_Hotelv4.Models;
using E_Hotelv4.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Hotelv4.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Send_Email()
        {
            return View(new SendEmailViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Send_Email(SendEmailViewModel model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String toEmail = model.ToEmail;
                    String subject = model.Subject;
                    String contents = model.Contents;

                    ////Check attachment is empty or not
                    if (Request.Files.Count > 0)
                    {
                        //var file = Request.Files["file"];
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Attachment/"), fileName);
                        file.SaveAs(path);
                        EmailSender es = new EmailSender();
                        es.Send(toEmail, subject, contents, path, fileName);
                    }
                    else
                    {
                        EmailSender es = new EmailSender();
                        es.Send(toEmail, subject, contents,null,null);
                    }

                    ViewBag.Result = "Email sended.";

                    ModelState.Clear();

                    return View(new SendEmailViewModel());
                }
                catch
                {
                    ViewBag.Result = "Error.";
                    return View();
                }
            }

            return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Name")] File file, HttpPostedFileBase postedFile)
        //{
        //    ModelState.Clear();
        //    var myUniqueFileName = string.Format(@"{0}", Guid.NewGuid());
        //    file.Path = myUniqueFileName; TryValidateModel(file);
        //    if (ModelState.IsValid)
        //    {
        //        string serverPath = Server.MapPath("~/Content/Attachment/");
        //        string fileExtension = Path.GetExtension(postedFile.FileName);
        //        string filePath = postedFile.Path + fileExtension;
        //        postedFile.Path = filePath; postedFile.SaveAs(serverPath + image.Path);
        //        db.Files.Add(postedFile);
        //        db.SaveChanges(); return RedirectToAction("Index");
        //    }
        //    return View(image);
        //}
    }
}