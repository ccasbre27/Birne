using System;

namespace Birne.Core
{
    public class Users
    {
        private int idCard;
        private string name;
        private string lastName;
        private string email;
        private string password;

        public int getIdCard()
        {
            return this.idCard;
        }

        public void setIdCard(int idCard)
        {
            this.idCard = idCard;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPassword()
        {
            return this.password;
        }
//s
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}