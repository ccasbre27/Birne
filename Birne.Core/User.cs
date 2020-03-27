using System;

namespace Birne.Core.Models
{
    public class User : BaseModel
    {
        private string id;
        private string name;
        private string last_name;
        private string email;
        private string password;

        public string user_id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public string user_name
        {
            get => name;
            set => RaiseAndSetIfChanged(ref name, value);
        }

        public string user_last_name
        {
            get => last_name;
            set => RaiseAndSetIfChanged(ref last_name, value);
        }

        public string user_mail
        {
            get => email;
            set => RaiseAndSetIfChanged(ref email, value);
        }

        public string user_password
        {
            get => password;
            set => RaiseAndSetIfChanged(ref password, value);
        }

    }
}