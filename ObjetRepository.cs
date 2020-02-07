using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class ObjetRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public ObjetRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public ObjetRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<ObjetDto> GetTexte()
        {
            List<ObjetDto> list = new List<ObjetDto>();
            foreach (Objet e in _dbContext.Objet)
                list.Add(e.toDto());
            return list;
        }

        public ObjetDto AddTexte(ObjetDto objet)
        {
            Objet newObjet = objet.ToEntity();
            Objet objetCreated = _dbContext.Objet.Add(newObjet);
            _dbContext.SaveChanges();
            return objetCreated.toDto();
        }
    }
}
