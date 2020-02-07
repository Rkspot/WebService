using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class SalleRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public SalleRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public SalleRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<SalleDto> GetSalle()
        {
            List<SalleDto> list = new List<SalleDto>();
            foreach (Salle e in _dbContext.Salle)
                list.Add(e.toDto());
            return list;
        }

        public SalleDto AddSalle(SalleDto salle)
        {
            Salle newSalle = salle.ToEntity();
            Salle salleCreated = _dbContext.Salle.Add(newSalle);
            _dbContext.SaveChanges();
            return salleCreated.toDto();
        }
    }
}
