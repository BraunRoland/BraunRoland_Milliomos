using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Milliomos
{
	internal class Kerdesek
	{
		string kerdes;
		private List<string> valaszok;
		char helyes;
		string kategoria;

		public Kerdesek(string kerdes, List<string> valaszok, char helyes, string kategoria)
		{
			this.kerdes = kerdes;
			this.valaszok = valaszok;
			this.helyes = helyes;
			this.kategoria = kategoria;
		}

		public string Kerdes { get => kerdes; set => kerdes = value; }
		public List<string> Valaszok { get => valaszok; set => valaszok = value; }
		public char Helyes { get => helyes; set => helyes = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }
	}
}
