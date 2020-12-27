namespace HolocronProject.Services.EmailSender
{
    public interface IEmailSender
    {
        void SendConfirmationEmail(Data.Models.Account account, string confirmationLink);
    }
}
