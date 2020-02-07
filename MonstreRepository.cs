using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class MonstreRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public MonstreRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public MonstreRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<MonstreDto> GetPartie()
        {
            List<MonstreDto> list = new List<MonstreDto>();
            foreach (Monstre e in _dbContext.Monstre)
                list.Add(e.toDto());
            return list;
        }

        public MonstreDto AddPartie(MonstreDto monstre)
        {
            Monstre newMonstre = monstre.ToEntity();
            Monstre monstreCreated = _dbContext.Monstre.Add(newMonstre);
            _dbContext.SaveChanges();
            return monstreCreated.toDto();
        }
    }
}
