using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	internal class ArticoloNonAlimentare : Articolo
	{
		//• per gli articoli non alimentari, lo sconto aggiuntivo è del 10% se il materiale è riciclabile. 
	
		private string _mat;
		private bool _ric;

		public string Mat
		{
			get { return _mat; }
			set { _mat = value; }
		}

		public bool Ric
		{
			get { return _ric; }
			set { _ric = value; }
		}


		public ArticoloNonAlimentare() : base()
		{
			Mat = null;
			Ric = false;
		}

		public ArticoloNonAlimentare(string mat, bool ric, int codice, string descrizione, double prezzo, bool fedelta) : base(codice, descrizione, prezzo, fedelta)
		{
			Mat = mat;
			Ric = ric;
		}

		public ArticoloNonAlimentare(ArticoloNonAlimentare vecchioartnona, Articolo vccha) : base(vccha)
		{
			Mat = vecchioartnona.Mat;
			Ric = vecchioartnona.Ric;
		}

		public override string ToString()
		{
			string a = Ric ? "Riciclabile" : "Non Riciclabile";
			return $"Materiale:{Mat}; Riciclabilità:{a};";
		}

		public override double Sconta()
		{
			if(Fedelta && Ric)
			{
				return Prezzo - base.Sconta() * (10 / 100);
			}
			if(Ric && Fedelta == false)
			{
				Prezzo = Prezzo - Prezzo * (10 / 100);
			}
			if(Fedelta)
			{
				base.Sconta();
			}
			return Prezzo;
		
			
		}
	}
}
