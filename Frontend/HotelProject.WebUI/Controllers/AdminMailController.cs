using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Mail kimden gönderilecek
            MailboxAddress mailboxAddress = new MailboxAddress("Hotelier Admini", "traversal.project@gmail.com"); //Mail gönderilen kişide görünecek kullanıcı adımız, mail adresimiz
            mimeMessage.From.Add(mailboxAddress);

            //Mailin kime gönderileceği
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail); //Mailde gönderilenler kısmında gözükecek olan kullanıcının ismi, alıcının maili
            mimeMessage.To.Add(mailboxAddressTo);
            
            //Mesajın içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            //Mesajın konusu
            mimeMessage.Subject = model.Subject;

            //MailKit'in smtp kütüphanesi kullanıldı.
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("traversal.project@gmail.com", "lsltqgwevecueovc");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
