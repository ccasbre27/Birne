using System;

namespace Birne.Core
{
    public class Merchants{
        private int idCard;
        private string name;
        private string lastName;
        private string email;
        private string password;
        private string companyName;
        private int relationId;

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

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getCompanyName()
        {
            return this.companyName;
        }

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        public int getRelationId()
        {
            return this.relationId;
        }

        public void setRelationId(int relationId)
        {
            this.relationId = relationId;
        }


    }
}