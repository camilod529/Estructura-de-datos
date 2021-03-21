using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;


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

        //Crear usuarios
        public void signUp (Dictionary<string, User> dictionary, string keyd, User data)
        {
            if(!dictionary.ContainsKey(keyd))
            {
                dictionary.Add(keyd, data);
                Console.WriteLine("Usuario creado");
                string json = JsonConvert.SerializeObject(dictionary);
                string path = @"./jsons/users.json";
                File.WriteAllText(path, json);
                showUser(dictionary);

            }
            else
            {
                Console.WriteLine("Ya hay un usuario con ese nickname");
            }
        }
        //cargar datos
        public Dictionary<string, User> loadData()
        {
            Dictionary<string, User> dictionary = new Dictionary<string, User>();
            string path = @"./jsons/users.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, User>>(jsond);
            }
            return dictionary;
        }
        //entrada al programa
        public bool signIn(string keyd, string password, Dictionary<string, User> dictionary)
        {
            foreach (var item in dictionary)
            {
                if(item.Key == keyd)
                {
                    if (item.Value.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("datos incorrectos, Intente denuevo");
                        return false;
                    }
                }
            }
            Console.WriteLine("Usuario no encontrado");
            return false;
        }
        //mostrar todos los usuarios
        public void showUser(Dictionary<string, User> dictionary)
        {
            foreach(var item in dictionary)
            {
                Console.WriteLine("Key: {0}", item.Key);
                Console.WriteLine("IdType: " + item.Value.IdType + " Id: " + item.Value.Id + " nombre: " + item.Value.Name + " nickname: " + item.Value.Nickname + " direccion: " + item.Value.Address + " Telefono: " + item.Value.Phone + " correo: " + item.Value.Email);
            }
        }

    }
}
