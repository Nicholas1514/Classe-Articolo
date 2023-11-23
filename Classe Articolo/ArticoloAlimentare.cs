using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Articolo
{
	public class ArticoloAlimentare : Articolo
	{
		private int _anno;
		public int Anno
		{
			set { _anno = value; }
			get { return _anno; }
		}

		public ArticoloAlimentare() :base()
		{
			Anno = 0;
		}

		public ArticoloAlimentare(int anno, int codice, string descrizione, double prezzo, bool fedelta):base(codice, descrizione, prezzo, fedelta)
		{
			Anno = anno;
		}

		public ArticoloAlimentare(ArticoloAlimentare alv, Articolo vart):base(vart)
		{
			Anno = alv.Anno;
		}

		public override double Sconta()
		{
			if(Anno == DateTime.Now.Year && Fedelta)
			{
				return Prezzo - base.Sconta() * (20 / 100);
			}

			if(Anno == DateTime.Now.Year && Fedelta == false)
			{
				return Prezzo - Prezzo * (20 / 100);
			}
			if (Fedelta)
			{
				base.Sconta();
			}
			return Prezzo;
		
		}
	}
}
