using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghaz_rendszer
{
	internal class Novenyfaj
	{
		string azonosito;
		string nev;
		int vizigeny;
		int egeszsegAllapot;
		int optimalissuruseg;

		public Novenyfaj( string nev, int vizigeny, int egeszsegAllapot, int optimalissuruseg)
		{
		
			this.Nev = nev;
			this.Vizigeny = vizigeny;
			this.EgeszsegAllapot = egeszsegAllapot;
			this.Optimalissuruseg = optimalissuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0, 3); }
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegAllapot { get => egeszsegAllapot; set => egeszsegAllapot = value; }
		public int Optimalissuruseg { get => optimalissuruseg; set => optimalissuruseg = value; }

		public override string ToString()
		{
			return $"{this.azonosito}{this.nev}{this.vizigeny}{this.egeszsegAllapot}{this.optimalissuruseg}";
		}

	}
}
