using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    class PersonneRepository
    {
        private readonly ServiceWebEntities _dbContext = null;

        public PersonneRepository()
        {
            _dbContext = new ServiceWebEntities();
        }


        public PersonneRepository(ServiceWebEntities context)
        {
            _dbContext = context;
        }

        public List<PersonneDto> GetPersonne()
        {
            List<PersonneDto> list = new List<PersonneDto>();
            foreach (Personne e in _dbContext.Personne)
                list.Add(e.toDto());
            return list;
        }

        public PersonneDto AddStudent(PersonneDto personne)
        {
            Personne newPersonne = personne.ToEntity();
            Personne personneCreated = _dbContext.Personne.Add(newPersonne);
            _dbContext.SaveChanges();
            return personneCreated.toDto();
        }
    }
}
