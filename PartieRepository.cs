using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class PartieRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public PartieRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public PartieRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<PartieDto> GetPartie()
        {
            List<PartieDto> list = new List<PartieDto>();
            foreach (Partie e in _dbContext.Partie)
                list.Add(e.toDto());
            return list;
        }

        public PartieDto AddPartie(PartieDto partie)
        {
            Partie newPartie = partie.ToEntity();
            Partie partieCreated = _dbContext.Partie.Add(newPartie);
            _dbContext.SaveChanges();
            return partieCreated.toDto();
        }
    }
}
