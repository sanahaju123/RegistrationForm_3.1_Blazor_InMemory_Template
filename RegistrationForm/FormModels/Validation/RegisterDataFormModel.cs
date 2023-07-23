using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.FormModels.Validation
{
    public class RegisterDataFormModel
    {        
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
       
        public string MobileNumber { get; set; }

        public string Address { get; set; }

    }
}