using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Recaptcha.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepo _contactRepo;
        public ContactController(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }
        [Route(template: "/BizeUlasin")]
        public async Task<IActionResult> GetContact()
        {
            var contactdata = await _contactRepo.Get(StaticDetails.getContact);
            TempData["Page"] = "Bize Ulaşın";
            TempData["BreadCrumb"] = new List<string> { "Bize Ulaşın" };
            return View(contactdata);
        }


        [HttpPost()]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMail(Mail mail)
        {
            try
            {
                var recaptchaHelper = this.GetRecaptchaVerificationHelper();
                var referer = this.HttpContext.Request.GetTypedHeaders().Referer.AbsolutePath;
                if (String.IsNullOrEmpty(recaptchaHelper.Response))
                {
                    //ModelState.AddModelError("", "Captcha answer cannot be empty.");
                    TempData["ErrorMail"] = "E-Posta gönderilirken bir hata oluştu. Kutucuğu işaretlediğinzden emin olun!";
                    return Redirect(referer);
                    //return RedirectToAction("GetContact");
                }

                var recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();

                if (!recaptchaResult.Success)
                {
                    foreach (var err in recaptchaResult.ErrorCodes)
                    {
                        ModelState.AddModelError("", err);
                    }
                }
                else
                {
                    //cookie den gelen ürün listesi burada mail body sine yazılıcak
                    //cookie temizlenicek

                    MimeMessage m = new();
                    m.Priority = MessagePriority.Urgent;
                    BodyBuilder bodyBuilder = new();
                    SmtpClient smtp = new();
                    bodyBuilder.HtmlBody = "Talebinizi aldık.En kısa sürede dönüş yapılacaktır.";
                    MailboxAddress from = new("Camaşırhane Ekipmanları", "info@camasirhaneekipmanlari.com");
                    MailboxAddress to = new(Encoding.UTF8, mail.EMail, mail.EMail);
                    m.From.Add(from);
                    m.Body = bodyBuilder.ToMessageBody();
                    m.Subject = "Bilgilendirme";
                    m.To.Add(to);
                    smtp.Connect("win5.wlsrv.com", 465, true);
                    smtp.Authenticate("ugur.yalcin@camasirhaneekipmanlari.com", "$q1q9T3u");
                    smtp.Send(m);
                    smtp.Disconnect(true);
                    smtp.Dispose();


                    MimeMessage mG = new();
                    mG.Priority = MessagePriority.Urgent;
                    BodyBuilder bodyBuilderG = new();
                    SmtpClient smtpG = new();
                    //bodyBuilder.HtmlBody += $"<p><b>Konu:&nbsp; </b>{mail.Subject} </p>";
                    //bodyBuilderG.HtmlBody += $"<p><b>E-Posta:&nbsp; </b>{mail.EMail} </p>";
                    //bodyBuilderG.HtmlBody += $"<p><b>Kimden:&nbsp; </b>{mail.Name} </p>";
                    bodyBuilderG.HtmlBody += mail.Message;
                   
                    if (mail.Product!=null && mail.Product.Count > 0)
                    {
                        int i = 1;
                        bodyBuilderG.HtmlBody += $"<p><b>Ürünler:&nbsp; </b></p>";
                        bodyBuilderG.HtmlBody += "</br>";
                        bodyBuilder.HtmlBody += "<table style='border-collapse:collapse;width:100%; 'border='1'>";
                        bodyBuilder.HtmlBody += "<thead>";
                        bodyBuilder.HtmlBody += "<tr>";
                        bodyBuilder.HtmlBody += "<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>No</strong></span></td>";
                        bodyBuilder.HtmlBody += "<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>Kategorisi</strong></span></td>";
                        bodyBuilder.HtmlBody += "<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>Alt Kategorisi</strong></span></td>";
                        bodyBuilder.HtmlBody += "<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>Adedi Bilgileri</strong></span></td>";
                        bodyBuilder.HtmlBody += "<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>Ürün Adı</strong></span></td>";
                        bodyBuilder.HtmlBody += "</tr>";
                        bodyBuilder.HtmlBody += "</thead>";
                        bodyBuilder.HtmlBody += "<tbody>";
                        foreach (var item in mail.Product)
                        {
                            var getfeatureDescs = item.FeatureDescriptions.Select(a => a.FeatureDesc).ToList();
                            string featureDescs = string.Join(",", getfeatureDescs);
                            bodyBuilder.HtmlBody += $"<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>{i}</strong></span></td>";
                            bodyBuilder.HtmlBody += $"<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>{item.Category.Name}</strong></span></td>";
                            bodyBuilder.HtmlBody += $"<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>{item.SubCategory.Name}</strong></span></td>";
                            bodyBuilder.HtmlBody += $"<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>{featureDescs}</strong></span></td>";
                            bodyBuilder.HtmlBody += $"<td style='width:20%; text-align: center; '><span style='color:#3366ff;'><strong>{item.Name}</strong></span></td>";

                            i++;
                        }
                        bodyBuilder.HtmlBody += "</tbody>";
                        bodyBuilder.HtmlBody += "</table>";

                    }

                    MailboxAddress fromG = new("Web Ui Test Muzaffer", "info@camasirhaneekipmanlari.com");
                    MailboxAddress toG = new(mail.EMail, "ugur.yalcin@camasirhaneekipmanlari.com");
                    mG.From.Add(fromG);
                    mG.Body = bodyBuilderG.ToMessageBody();
                    mG.Subject = mail.Subject;
                    mG.To.Add(toG);
                    smtpG.Connect("win5.wlsrv.com", 465, true);
                    smtpG.Authenticate("info@camasirhaneekipmanlari.com", "Yamahar123+-*/");
                    smtpG.Send(mG);
                    smtpG.Disconnect(true);
                    smtpG.Dispose();

                    TempData["SuccessMail"] = "E-Postanız başırılı bir şeilde gönderildi";
                    return RedirectToAction("GetContact");
                }
            }
            catch (Exception)
            {
                TempData["ErrorMail"] = "E-Posta gönderilirken bir hata oluştu.";
                return RedirectToAction("GetContact");
            }

            return RedirectToAction("GetContact");

        }
    }
}
