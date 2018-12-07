using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace App_Project.Controllers
{
    public class TalkShalkController : Controller
    {
        public ActionResult Chat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Chat(string receiverEmail, string subject , string message )
        {
            try
            {
                if (ModelState.IsValid)
                {
                  var    senderemail = new MailAddress("malicsattar@gmail.com", "Sattar Malic");
                  var   receiveremail = new MailAddress(receiverEmail , "Receiver mail");

                    var password = "cheverlet_babn2";
                    var msgsubject = "Sattar Malic";
                    var msgbody = message;


                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,

                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential (senderemail.Address ,password)

                    };


                    // Method to send email 

                    using (var msg = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = msgsubject,
                        Body = msgbody,
                    })
                    {
                        smtp.Send(msg);
                    }

                    return View();
                }

            }
            catch (Exception)
            {
                ViewBag.Error = " There are some errors while connecting with receiver";
                
            }
             

            return View();

        }
    }
}