using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Milliomos
{
	internal class Kerdes
	{
		int nehezseg;
		string kerdesek;
		private List<string> valaszok;
		string helyes;
		string kategoria;

		public Kerdes(int nehezseg, string kerdesek, List<string> valaszok, string helyes, string kategoria)
		{
			this.kerdesek = kerdesek;
			this.valaszok = valaszok;
			this.helyes = helyes;
			this.kategoria = kategoria;
			this.nehezseg = nehezseg;
		}

		public int Nehezseg { get => nehezseg; set => nehezseg = value; }
		public string Kerdesek { get => kerdesek; set => kerdesek = value; }
		public List<string> Valaszok { get => valaszok; set => valaszok = value; }
		public string Helyes { get => helyes; set => helyes = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }
	}
}
