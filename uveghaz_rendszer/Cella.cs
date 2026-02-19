using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghaz_rendszer
{
	internal class Cella
	{
		Pozicio poz;
		Novenyfaj noveny;
		int egyedszam;
		List<Riasztas> riasztasok;
		List<Szenzor> szenzorok;
		public Cella(Pozicio poz)
		{
			Novenyfaj noveny = null;
			this.Poz = poz;
			egyedszam = 0;
			Riasztasok = new List<Riasztas>();
			Szenzorok = new List<Szenzor>();
		}

		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Pozicio Poz { get => poz; set => poz = value; }
		internal Novenyfaj Noveny { get => noveny; set => noveny = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		public bool Urescella
		{
			get
			{
				return this.noveny==null;
			}
		}
		public bool Beultet(Novenyfaj noveny,int egyedszam)
		{
			if (this.Urescella)
			{
				this.noveny = noveny;
				this.egyedszam = egyedszam;
				if (this.egyedszam > noveny.Optimalissuruseg)
				{
					this.noveny.EgeszsegAllapot -= 2;
				}
				return true;
			}
			else if (noveny==this.noveny) 
			{
				this.egyedszam += egyedszam;
				if (this.egyedszam > noveny.Optimalissuruseg)
				{
					this.noveny.EgeszsegAllapot-=2;
				}
				return true;

			}
			else
			{
				return false;
			}
		}
		
		public void Noveles(int egyedSzam)
		{
			this.Beultet(this.noveny,egyedSzam);

		}
		public void Csokkentes(int egyedSzam)
		{
			this.egyedszam -= egyedSzam;
			if(this.egyedszam <= 0)
			{
				this.egyedszam = 0;
				this.noveny = null;
			}
		}

	}
}
