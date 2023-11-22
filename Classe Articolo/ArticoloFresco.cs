using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	internal class ArticoloFresco : ArticoloAlimentare
	{
		private int _consumazione;

		public int Consumazione
		{
			set { _consumazione = value; }
			get { return _consumazione; }

		}

		public ArticoloFresco(): base()
		{
			Consumazione = 0;
		}

		public ArticoloFresco(int consumazione, int anno, int codice, string descrizione, double prezzo, bool fedelta) : base(anno, codice, descrizione, prezzo, fedelta)
		{
			Consumazione = Consumazione;
		}

		public ArticoloFresco(ArticoloFresco vartf, ArticoloAlimentare varta, Articolo vart): base(varta, vart)
		{
			Consumazione = vartf.Consumazione;
		}

        public override string ToString()
        {
			return $"{base.ToString()}Da consumare entro: {Consumazione}";
        }



    }
}
