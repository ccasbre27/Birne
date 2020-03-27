using System;

namespace Birne.Core.Models
{
    public class Merchant : BaseModel
    {
        private string id;
        private string name;
        private string last_name;
        private string email;
        private string password;
        private string company_name;
        private string relation_id; //which user is related to this merchant

        public string merchant_id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public string merchant_name
        {
            get => name;
            set => RaiseAndSetIfChanged(ref name, value);
        }

        public string merchant_last_name
        {
            get => last_name;
            set => RaiseAndSetIfChanged(ref last_name, value);
        }

        public string merchant_email
        {
            get => email;
            set => RaiseAndSetIfChanged(ref email, value);
        }

        public string merchant_password
        {
            get => password;
            set => RaiseAndSetIfChanged(ref password, value);
        }

        public string merchant_company_name
        {
            get => company_name;
            set => RaiseAndSetIfChanged(ref company_name, value);
        }

        public string related_user
        {
            get => relation_id;
            set => RaiseAndSetIfChanged(ref relation_id, value);
        }
    }
}