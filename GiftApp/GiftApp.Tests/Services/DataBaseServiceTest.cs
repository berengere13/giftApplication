using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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
        public void TestReadDataBaseUser()
        {
            var databaseService = new DataBaseService();

            var FireBaseClient = databaseService.GetFirebaseClient();

            var listUsers = new List<User>();

            var temp = FireBaseClient.Child("users").OnceAsync<User>().Result;

           //foreach (var firebaseUser in users)
            //{
            //    listUsers.Add(new User(firebaseUser.Object));
            //}

            Check.That(listUsers.Count).Equals(2);
        }
    }
}