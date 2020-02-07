using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    public class ObjetDto
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public string propriete_cible { get; set; }
        public Nullable<int> montant { get; set; }



        public Objet ToEntity()
        {
            return new Mapping().ToEntity(this);
        }


    }
}

