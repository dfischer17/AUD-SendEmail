using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendRegistrationConfirmationEmail("password", "fromEmail", "toEmail");            
            //SendRegistrationConfirmationEmail("TaMaPe333", "pefr2002@hotmail.com", "dfischer17htl@gmail.com");
            //SendAppointmentConfirmationEmail("TaMaPe333", "pefr2002@hotmail.com", "dfischer17htl@gmail.com");
            SendCancellationConfirmationEmail("TaMaPe333", "pefr2002@hotmail.com", "dfischer17htl@gmail.com");
            Console.WriteLine("Email gesendet");
        }
        
        public static void SendRegistrationConfirmationEmail(string password, string from, string to)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Österreich testet - Bestätigung";
            mail.IsBodyHtml = true;            
            string htmlBody;
            htmlBody = "<h1>Registrierungsbestätigung</h1><p>Sie haben sich erfolgreich registriert und können unter folgendem Link einen Termin für Ihren kostenlosen COVID-19 Test buchen.</p><a href=\"http://www.stackoverflow.com/\" target=\"_blank\" style=\"padding: 0.6rem 1rem; background-color: #e32614; color: ffffff\">Termin buchen</a><p>-------------------------------------</p><p>Bundesministerium</p></p><p>Soziales, Gesundheit, Pflege</p><p>und Konsumentenschutz</p>";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        public static void SendAppointmentConfirmationEmail(string password, string from, string to)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Österreich testet - Bestätigung";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "<h1>Terminbestätigung</h1><p>Ihr Termin für den kostenlosen COVID-19 Test wurde gebucht.</p><p>Zum Test bitte mitbringen:</p><li>Gedruckten Laufzettel aus Ihrer Anmeldung oder die Laufzettel-Nummer</li><li>Ausweis</li><p style=\"font-weight: bold;\">Laufzettel-Nummer</p><p style=\"font-weight: bold;\">Datum</p><p style=\"font-weight: bold;\">Zeit</p><p style=\"font-weight: bold;\">Ort</p><a href=\"http://www.stackoverflow.com/\" target=\"_blank\" style=\"padding: 0.6rem 1rem; background-color: #e32614; color: ffffff\">Termin anzeigen</a><p>-------------------------------------</p><p>Bundesministerium</p></p><p>Soziales, Gesundheit, Pflege</p><p>und Konsumentenschutz</p>";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }

        public static void SendCancellationConfirmationEmail(string password, string from, string to)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Österreich testet - Storno-Bestätigung";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "<h1>Storno-Bestätigung</h1><p>Ihr Termin am TODO um TODO Uhr für den kostenlosen COVID-19 Test wurde storniert.</p><p>-------------------------------------</p><p>Bundesministerium</p></p><p>Soziales, Gesundheit, Pflege</p><p>und Konsumentenschutz</p>";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
