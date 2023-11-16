using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	internal class Articolo
	{
		protected int _codice;
		protected string _descrizione;
		protected double _prezzo;
		protected bool _fedelta;

		public int Codice
		{
			get { return _codice; }
			set { _codice = value; }
		}
		public string Descrizione
		{
			get { return _descrizione; }
			set { _descrizione = value; }
		}
		public double Prezzo
		{
			get { return _prezzo; }
			set { _prezzo = value; }
		}
		public bool Fedelta
		{
			get { return _fedelta; }
			set { _fedelta = value; }
		}

		public Articolo()
		{
			Codice = 0;
			Descrizione = null;
			Prezzo = 0;
			Fedelta = false;
		}
		public Articolo(int codice, string descrizione, double prezzo, bool fedelta)
		{
			Codice = codice;
			Descrizione = descrizione;
			Prezzo = prezzo;
			Fedelta = fedelta;
			Codice = codice;
			Descrizione = descrizione;
			Prezzo = prezzo;
			Fedelta = fedelta;
		}

		public virtual double Sconta()
		{
			if(Fedelta == true)
			{
				Prezzo = (Prezzo / 100) * 5;
			}
			return Prezzo;
		}
	}
}
