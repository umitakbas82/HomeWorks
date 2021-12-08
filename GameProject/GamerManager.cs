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
                Console.WriteLine("Kayit Basarili");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz, Kayit Basarisiz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Guncelleme Basarili");
        }
    }
}
