using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	public class ArticoloFresco : ArticoloAlimentare
	{
		private int _consumazione;

		public int Consumazione
		{
			set { _consumazione = value; }
			get { return _consumazione; }

		}

		public ArticoloFresco() : base()
		{
			Consumazione = 0;
		}

		public ArticoloFresco(int consumazione, int anno, int codice, string descrizione, double prezzo, bool fedelta) : base(anno, codice, descrizione, prezzo, fedelta)
		{
			Consumazione = consumazione;
		}

		public ArticoloFresco(ArticoloFresco vartf, ArticoloAlimentare varta, Articolo vart) : base(varta, vart)
		{
			Consumazione = vartf.Consumazione;
		}

		public override string ToString()
		{
			return $"{base.ToString()}Da consumare entro: {Consumazione}";
		}

		public override bool Equals(object obj)
		{
			if(obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			ArticoloFresco altro = (ArticoloFresco)obj;
			if(base.Equals(altro) && Consumazione == altro.Consumazione)
			{
				return true;
			}
			return false;
		}

		public override double Sconta()
		{
			double x = base.Sconta();
			double psconto = 10F;
			for(int i = 1; i < 6 && i < Consumazione; i++)
			{
				psconto -= 2F;
			}
			return x - x * psconto / 100;

		}

		public override int Compare(Articolo other, Articolo altro)
		{
			return base.Compare(other, altro);
		}


	}
}
