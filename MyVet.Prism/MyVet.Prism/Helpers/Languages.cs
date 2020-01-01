using MyVet.Prism.Interfaces;
using MyVet.Prism.Resources;
using Xamarin.Forms;

namespace MyVet.Prism.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept => Resource.Accept;

        public static string Address => Resource.Address;

        public static string AddressError => Resource.AddressError;

        public static string AddressPlaceHolder => Resource.AddressPlaceHolder;

        public static string Document => Resource.Document;

        public static string DocumentError => Resource.DocumentError;

        public static string DocumentPlaceHolder => Resource.DocumentPlaceHolder;

        public static string Email => Resource.Email;

        public static string EmailError => Resource.EmailError;

        public static string EmailPlaceHolder => Resource.EmailPlaceHolder;

        public static string Error => Resource.Error;

        public static string FirstName => Resource.FirstName;

        public static string FirstNameError => Resource.FirstNameError;

        public static string FirstNamePlaceHolder => Resource.FirstNamePlaceHolder;

        public static string Forgot => Resource.Forgot;

        public static string LastName => Resource.LastName;

        public static string LastNameError => Resource.LastNameError;

        public static string LastNamePlaceHolder => Resource.LastNamePlaceHolder;

        public static string Login => Resource.Login;

        public static string LoginError => Resource.LoginError;

        public static string Password => Resource.Password;

        public static string PasswordError => Resource.PasswordError;

        public static string PasswordPlaceHolder => Resource.PasswordPlaceHolder;

        public static string Phone => Resource.Phone;

        public static string PhoneError => Resource.PhoneError;

        public static string PhonePlaceHolder => Resource.PhonePlaceHolder;

        public static string Register => Resource.Register;

        public static string Rememberme => Resource.Rememberme;

        public static string Delete => Resource.Delete;

        public static string Working => Resource.Working;

        public static string Save => Resource.Save;

        public static string Saving => Resource.Saving;

        public static string CreateEditPetConfirm => Resource.CreateEditPetConfirm;

        public static string Created => Resource.Created;

        public static string Edited => Resource.Edited;

        public static string NameError => Resource.NameError;

        public static string RaceError => Resource.RaceError;

        public static string PetTypeError => Resource.PetTypeError;

        public static string Ok => Resource.Ok;
    }
}
