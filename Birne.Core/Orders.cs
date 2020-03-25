using System;

namespace Birne.Core{
    public class Orders{
        private int id;
        private int user_id;
        private string status;
        private string createdAt;


        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getUser_id()
        {
            return this.user_id;
        }

        public void setUser_id(int user_id)
        {
            this.user_id = user_id;
        }

        public string getStatus()
        {
            return this.status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getCreatedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
        }
    }
}