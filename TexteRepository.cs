using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class TexteRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public TexteRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public TexteRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<TexteDto> GetTexte()
        {
            List<TexteDto> list = new List<TexteDto>();
            foreach (Texte e in _dbContext.Texte)
                list.Add(e.toDto());
            return list;
        }

        public TexteDto AddTexte(TexteDto texte)
        {
            Texte newTexte = texte.ToEntity();
            Texte texteCreated = _dbContext.Texte.Add(newTexte);
            _dbContext.SaveChanges();
            return texteCreated.toDto();
        }
    }
}
