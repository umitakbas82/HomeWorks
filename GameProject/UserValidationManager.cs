using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Umit" && gamer.LastName == "Akbas" && gamer.IdentityNumber == 1234556)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
