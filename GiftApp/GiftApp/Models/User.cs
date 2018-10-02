using System;
using System.Collections.Generic;
using System.Text;

namespace GiftApp.Models
{
    public class User
    {
        
        public User(User user)
        {
            Id = user.Id;
            Prenom = user.Prenom;
        }

        public string Id { get; }

        public string Prenom { get; }

    }
}
