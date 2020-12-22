using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.EmailSender
{
    public interface IEmailSender
    {
        void SendConfirmationEmail(Data.Models.Account account, string confirmationLink);
    }
}
