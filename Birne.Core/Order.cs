using System;

namespace Birne.Core.Models
{
    public class Order : BaseModel
    {
        private int id;
        private string user_id;
        private string status; // ready or not
        private string created_at;

        public int order_id
        {
            get => id;
            set => RaiseAndSetIfChanged(ref id, value);
        }

        public string user_id_
        {
            get => user_id;
            set => RaiseAndSetIfChanged(ref user_id, value);
        }

        public string order_status
        {
            get => status;
            set => RaiseAndSetIfChanged(ref status, value);
        }

        public string order_created_at
        {
            get => created_at;
            set => RaiseAndSetIfChanged(ref created_at, value);
        }


    }
}