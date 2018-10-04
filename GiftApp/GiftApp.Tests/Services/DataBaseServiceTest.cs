using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Firebase.Database.Query;
using GiftApp.Models;
using GiftApp.Services;
using Newtonsoft.Json;
using NFluent;
using NUnit.Framework;

namespace GiftApp.Tests.Services
{
    [TestFixture]
    public class DataBaseServiceTest
    {
        [Test]
        public async Task TestReadDataBaseUser()
        {
            var databaseService = new DataBaseService();

            var FireBaseClient = databaseService.GetFirebaseClient();

            var user = new User(Guid.NewGuid().ToString(), "Bérengère");

            var temp = await FireBaseClient.Child("users").PostAsync(user);

            var userGet = await FireBaseClient.Child("users").OnceAsync<User>();

            User userTemp = new User();
            foreach (var firebaseObject in userGet)
            {
                userTemp = new User(firebaseObject.Object.Id, firebaseObject.Object.Prenom);
            }

            Check.That(user).HasFieldsWithSameValues(userTemp);
        }

        [Test]
        public async Task TestReadDataBaseEnvies()
        {
            var databaseService = new DataBaseService();

            var FireBaseClient = databaseService.GetFirebaseClient();

            var userGet = await FireBaseClient.Child("users").Child("Bérengère").OnceAsync<User>();

            var user = userGet.FirstOrDefault()?.Object;

            var envie = new Envie("sapin de noel", "celui que je veux c'est Cdiscount a 35€ avec plein de fleurs", user );

            var temp = await FireBaseClient.Child("envies").PostAsync(envie);

            var key = temp.Key;

            var comment = new Commentaire("commentaire1");

            envie = envie.SetCommentaire(comment);

            var tempEnvie = await FireBaseClient.Child("envies").Child(key).PostAsync(comment);

            var envieDB = await FireBaseClient.Child("envies").Child(key).OnceSingleAsync<Envie>();

            Check.That(envie).HasFieldsWithSameValues(envieDB);
        }
    }
}