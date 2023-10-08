using DataLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ZaposlenBusiness 
    {
        private readonly ZaposlenRepository zaposlenRepository;
        public ZaposlenBusiness()
        {
            this.zaposlenRepository = new ZaposlenRepository();
        }

        public List<Zaposlen> GetAllEmployees()
        {
            return this.zaposlenRepository.GetAllEmployees();
        }
    }
}
