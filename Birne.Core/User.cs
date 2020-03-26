using System;

namespace Birne.Core
{
    public class User : BaseModel
    {
        private string id;
        private string name;
        private string lastName;
        private string email;
        private string password;

        public string Id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public string Name
        {
            get => name;
            set => RaiseAndSetIfChanged(ref name, value);
        }

        public string LastName
        {
            get => lastName;
            set => RaiseAndSetIfChanged(ref lastName, value);
        }

        public string Email
        {
            get => email;
            set => RaiseAndSetIfChanged(ref email, value);
        }

        public string Password
        {
            get => password;
            set => RaiseAndSetIfChanged(ref password, value);
        }

    }
}