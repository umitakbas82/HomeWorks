using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { GamerId = 1, FirstName = "Umit", LastName = "Akbas", BirthYear = 1982, IdentityNumber = 12345 });




        }
    }
}
