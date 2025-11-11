using System.Net.Mail;
using System.Net;

namespace RegIN.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("vladipyankov@yandex.ru", "rztynwwhutrqwlgr"),
                EnableSsl = true,
            };
            smtpClient.Send("vladipyankov@yandex.ru", To, "Проект RegIn", Message);
        }
    }
}
