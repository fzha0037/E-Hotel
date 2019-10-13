using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Hotelv4.Utils;
using E_Hotelv4.Models;
using System.IO;

namespace E_Hotelv4.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents, string path, string fileName)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@E-hotel.com", "E-Hotel Support Team");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var bytes = File.ReadAllBytes(path);
            var bytesContent = Convert.ToBase64String(bytes);
            msg.AddAttachment(path, bytesContent);
            var response = client.SendEmailAsync(msg);
        }
        public void SendWelcomeMessage(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@E-hotel.com", "E-Hotel Support Team");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p style = 'font-weight:bold;'>Dear Customer, </p><p>" + contents + "</p><hr/><p>Best Regards,</p><p>E-Hotel Support Team</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        } 

    }
}
