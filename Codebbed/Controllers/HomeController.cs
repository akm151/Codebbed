using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Newtonsoft.Json;
using Codebbed.Models;
using System.Text;

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
        [HttpPost]
        public ActionResult SendMail(ContactUs input)
        {
            Result result = new Result();
            if (ModelState.IsValid)
            {

                StringBuilder body = new StringBuilder();
                body.Append(input.Name);
                body.Append("\n");
                body.Append(input.Email);
                body.Append("\n");
                body.Append(input.PhoneNo);
                body.Append("\n");
                body.Append(input.Message);

                MailMessage mailMessage = new MailMessage("codebbed@gmail.com", "akm151@gmail.com");
                MailAddress cc1 = new MailAddress("saumya093@gmail.com");
                MailAddress cc2 = new MailAddress("pallavibhandari1993@gmail.com");
                mailMessage.CC.Add(cc1);
                mailMessage.CC.Add(cc2);
                //mailMessage.Subject = input.Subject;
                mailMessage.Body = body.ToString();

                SmtpClient smtpClient = new SmtpClient();
                try
                {
                    smtpClient.Send(mailMessage);
                    result.IsSuccess = true;
                    result.Message = "Thanks for Contacting Us.We will get back to you shortly.";
                }
                catch (Exception ex)
                {
                    result.Message="There was some error sending mail. Please drop a text to +91 9886 902 262";
                }
            }
            else
            {
                result.Message = "Please enter proper values";
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }


}

