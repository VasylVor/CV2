using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.BLL
{
    public class Email
    {
        public string AddressTo { get; }

        public Email()
        {
            AddressTo = "vasilvoronin0@gmail.com";
        }

        public async Task SendEmailAsync(string from, string subject, string text)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from));
            message.To.Add(new MailboxAddress(AddressTo));
            message.Subject = subject;
            message.Body = new TextPart() { Text = text };

            try
            {
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync("vasilvoronin0@gmail.com", "Vasil980114@");
                    await client.SendAsync(message);

                    await client.DisconnectAsync(true);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
