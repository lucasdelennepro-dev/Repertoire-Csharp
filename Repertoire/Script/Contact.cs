
using System;

namespace Repertoire
{
    [Serializable]
    public class Contact
    {

        // Variables

        private string name;
        private string email;
        private string tel;
        private string city;

        // Proprietés
        public string Name { get => name; private set => name = value; }
        public string Email { get => email; private set => email = value; }
        public string Tel { get => tel; private set => tel = value; }
        public string City { get => city; private set => city = value; }

        
        // Constructeurs
        public Contact()
        {

        }
        public Contact(string name, string email, string tel, string city)
        {
            this.Name = name;
            this.Email = email;
            this.Tel = tel;
            this.City = city;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
