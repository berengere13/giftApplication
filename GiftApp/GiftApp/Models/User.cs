using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Org.Json;

namespace GiftApp.Models
{
    public class User
    {
        
        public User(User user)
        {
            Id = user.Id;
            Prenom = user.Prenom;
        }

        public User(string id, string prenom)
        {
            Id = id;
            Prenom = prenom;
        }

        public User()
        {
        }

        public string Id { get; }

        public string Prenom { get; }

    }
}
