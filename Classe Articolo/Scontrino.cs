using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Articolo
{
	
	public class Scontrino : Articolo
	{
		public Articolo [] scontrino; 
		protected int dim = 0;
		public Articolo Mag
		{
			get { return scontrino[dim]; } 
			set { scontrino[dim] = value; }
		}

		//costruttore senza parametri
		public Scontrino()
		{
			scontrino = new Articolo[100];
			dim = 0;
		}
		//costruttore con parametri
		public Scontrino(int dim, int codice, string descrizione, double prezzo, bool fedelta):base(codice, descrizione, prezzo, fedelta)
		{
			scontrino = new Articolo[dim];
			
		}
		//costruttore di copia
		public Scontrino(Scontrino s, Articolo vart) : base(vart)
		{
			scontrino = s.scontrino;
		
		}

		//metodo aggiunta
		public void Aggiungi(Articolo art)
		{
			scontrino[dim] = art;
			dim++;
		}
		//metodo totale
		public double Totale()
		{
			double totale = 0;
			for(int i = 0; i < dim; i++)
			{
				totale += scontrino[i].Prezzo;
			}
			return totale;

		}

		//override tostring
		public override string ToString()
		{
			double a = Totale();
			return base.ToString() + $" Totale: {a} ";
		}
	}
}
