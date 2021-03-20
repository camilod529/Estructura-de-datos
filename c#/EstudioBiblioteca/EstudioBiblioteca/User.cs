using System;
using System.Collections.Generic;
using System.Text;

namespace EstudioBiblioteca
{
    class User
    {
        public string Id { get; set; }
        public string IdType { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(string Id, string IdType, string Name, string Nickname, string Password, string Address, string Phone, string Email)
        {
            this.Id = Id;
            this.IdType = IdType;
            this.Name = Name;
            this.Nickname = Nickname;
            this.Password = Password;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
        }
    }
}
