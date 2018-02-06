using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Newtonsoft.Json;

namespace Codebbed.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendMail()
        {

            MailMessage mailMessage = new MailMessage("codebbed@gmail.com", "akm151@gmail.com");
            MailAddress cc1 = new MailAddress("saumya093@gmail.com");
            MailAddress cc2 = new MailAddress("pallavibhandari1993@gmail.com");
            mailMessage.CC.Add(cc1);
            mailMessage.CC.Add(cc2);
            mailMessage.Subject = "test email";
            mailMessage.Body = "this is the body of test mail";

            SmtpClient smtpClient = new SmtpClient();
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", new { message = ex.Message });
            }
            return Json(new { isSuccess = true, message = "Thanks for Contacting Us.We will get back to you shortly." }, JsonRequestBehavior.AllowGet);

        }
    }


}

