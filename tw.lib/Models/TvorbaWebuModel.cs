using dufeksoft.lib.Mail;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using tw.lib.Util;

namespace tw.lib.Models
{
    public class TvorbaWebuModel
    {
        [Required(ErrorMessage = "E-mail musí byť zadaný")]
        [EmailAddress(ErrorMessage = "Neplatná e-mailová adresa")]
        [Display(Name = "E-mail")]

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public bool SendContactRequest()
        {
            List<TextTemplateParam> paramList = new List<TextTemplateParam>();
            paramList.Add(new TextTemplateParam("EMAIL", this.Email));

            // Odoslanie uzivatelovi
            TvorbaWebuMailer.SendMailTemplate(
                "Vaša správa",
                TextTemplate.GetTemplateText("ContactSendSuccess_Sk", paramList),
                this.Email, null);

            return true;
        }
    }
}
