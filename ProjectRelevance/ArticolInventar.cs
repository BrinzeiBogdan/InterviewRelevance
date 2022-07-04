using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRelevance
{
    public class ArticolInventar
    {
        public float Greutate { get; set; }
        public float Volum { get; set; }

        public ArticolInventar(float greutate, float volum)
        {
            this.Greutate = greutate;
            this.Volum = volum;
        }
    }
}
