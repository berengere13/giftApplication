using System;
using Newtonsoft.Json;

namespace GiftApp.Models
{
    public class Commentaire
    {
        public Commentaire(string text)
        {
            Id = Guid.NewGuid().ToString();
            Text = text;
        }

        public string Id { get; }
        public string Text { get; }
    }
}