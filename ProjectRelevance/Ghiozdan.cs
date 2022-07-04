using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRelevance
{
    internal class Ghiozdan
    {

        private List<ArticolInventar> articole;
        private float greutatea;
        private float volumul;

        private float greutateActualizata;
        private float volumulActualizat;


        public Ghiozdan(int capacitate, float greutatea, float volumul)
        {
            articole = new List<ArticolInventar>(capacitate);
            this.greutatea = greutatea;
            this.volumul = volumul;
        }

        public bool Adauga(ArticolInventar articol)
        {
           if (articol is null || this.articole.Count == this.articole.Capacity) return false;

           float greutateaActuala = articole.Sum(item => item.Greutate) + articol.Greutate;
           float volumulActual = articole.Sum(item => item.Volum) + articol.Volum;


           if(greutateaActuala <= this.greutatea && volumulActual <= this.volumul)
           {
                articole.Add(articol);
                this.greutateActualizata = greutateaActuala;
                this.volumulActualizat = volumulActual;
           }
           else
           {
                return false;
           }

            return true;
        }

        public string Raportare()
        {
            return String.Format("SPECIFICATII GHIOZDAN: \n" +
                "Capacitate: {0} articole; \n" +
                "Greutate admisibila: {1} kg; \n" +
                "Volum admisibil: {2} m3; \n" +
                "Numar articole continute: {3} articole; \n" +
                "Greutate actuala: {4} kg; \n" +
                "Volum actual: {5} m3; ", articole.Capacity, this.greutatea, this.volumul, this.articole.Count, this.greutateActualizata, this.volumulActualizat);
        }
    }
}
