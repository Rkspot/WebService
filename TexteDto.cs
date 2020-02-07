using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    public class TexteDto
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string contenu { get; set; }



        public Texte ToEntity()
        {
            return new Mapping().ToEntity(this);
        }


    }
}

