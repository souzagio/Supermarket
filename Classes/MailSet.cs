using System;
using System.Net;
using System.Net.Mail;

namespace Supermarket.Classes
{
    internal class MailSet
    {

        public static string SendMail(string email)
        {
            // Configurações do servidor SMTP 
            string smtpServer = "smtp.office365.com";
            int smtpPort = 587; 
            string smtpUsername = "conectmark@outlook.com.br"; 
            string smtpPassword = "*****"; 

            // Remetente e destinatário
            string remetente = "conectmark@outlook.com.br";
            string destinatario = email;

            // Criar a mensagem de e-mail
            MailMessage mensagem = new MailMessage(remetente, destinatario);
            mensagem.Subject = "Confirmação de registro";
            mensagem.Body = "Sua nova senha é: 556078";

            // Configurar o cliente SMTP
            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            smtpClient.EnableSsl = true;

            try
            {
                // Enviar o e-mail
                smtpClient.Send(mensagem);
                string msg = "Email enviado!";
                return msg;
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro.";
                return msg;
            }
        }
    }
}



