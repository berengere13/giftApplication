using System;
using System.Collections.Generic;
using System.Text;

namespace GiftsProject.Models
{
    public class User
    {
        public string Prenom { get; set; }

        public List<Envie> MesEnvies { get; set; }

    }
}
