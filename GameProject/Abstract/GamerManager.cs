using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;

        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Sing Up Succeeded");
            }
            else
            {
                Console.WriteLine("Sign Up Failed");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Record Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Update Succeeded");
        }
    }
}
