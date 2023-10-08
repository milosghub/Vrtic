using DataLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DecaBusiness  
    {
        private readonly DecaRepository decaRepository;
        public DecaBusiness()
        {
            this.decaRepository = new DecaRepository();
        }

        public List<Deca> GetAllChildren()
        {
            return this.decaRepository.GetAllChildren();
        }

        public bool InsertChildren(Deca d)
        {
            if (this.decaRepository.InsertChildren(d) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateChildren(Deca d)
        {
            if (this.decaRepository.UpdateChildren(d) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteChildren(Deca d)
        {
            if (this.decaRepository.DeleteChildren(d) > 0)
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
