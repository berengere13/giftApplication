using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Org.Json;

namespace GiftApp.Models
{
    public class Envie
    {
        public Envie(string nom, string description, User destinatedUser)
        {
            Id = Guid.NewGuid().ToString();
            Description = description;
            DestinatedUser = destinatedUser;
            Nom = nom;
        }

        public Envie()
        {
        }
        
        public string Id { get; }
        public string Nom { get; }
        public string Description { get; }
        public User CreatedUser { get; }
        public User DestinatedUser { get; }
        public User TakeInUser { get; }
        public List<Commentaire> Commentaires { get; private set; }

        public Envie SetCommentaire(Commentaire comment)
        {
            if (Commentaires == null)
            {
                Commentaires = new List<Commentaire>();
            }

            Commentaires.Add(comment);

            return this;
        }
    }
}
