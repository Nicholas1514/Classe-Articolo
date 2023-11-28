using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	public class Articolo
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
		}

		public Articolo(Articolo articolovecchio)
		{
			Codice = articolovecchio.Codice;
			Descrizione = articolovecchio.Descrizione;
			Prezzo = articolovecchio.Prezzo;
			Fedelta = articolovecchio.Fedelta;

		}

		public override string ToString()
		{
			string a = Fedelta ? "Abbonato" : "Non abbonato";
			return $"Codice:{Codice}; Descrizione:{Descrizione}; Prezzo:{Prezzo}; Fedelta:{a};";
		}

		public override bool Equals(object obj)
		{
			if(obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			Articolo altro = (Articolo)obj;
			if(Codice == altro.Codice && Descrizione == altro.Descrizione && Prezzo == altro.Prezzo && Fedelta == altro.Fedelta)
			{
				return true;
			}
			return false;
		}

		public virtual double Sconta()
		{
			if(Fedelta)
			{
				Prezzo = Prezzo - Prezzo * 5 / 100;
			}
			return Prezzo;
		}

		public virtual int Compare(Articolo other, Articolo altro)
		{
			return 0;
		}
	}
}
