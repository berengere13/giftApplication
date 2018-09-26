using System;
using System.Collections.Generic;

namespace GiftsProject.Models
{
    public class Envie
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public User CreatedUser { get; set; }
        public User DestinatedUSer { get; set; }
        public User SelectedUser { get; set; }
        public List<Commentaire> Commentaires { get; set; }
    }
}