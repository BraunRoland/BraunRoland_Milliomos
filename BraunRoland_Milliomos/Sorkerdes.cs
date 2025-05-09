using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Milliomos
{
	internal class Sorkerdes
	{
		string kerdes;
		List<string> valaszok;
		string helyes;
		string kategoria;

		public Sorkerdes(string kerdes, List<string> valaszok, string helyes, string kategoria)
		{
			this.kerdes = kerdes;
			this.valaszok = valaszok;
			this.helyes = helyes;
			this.kategoria = kategoria;
		}

		public string Kerdes { get => kerdes; set => kerdes = value; }
		public List<string> Valaszok { get => valaszok; set => valaszok = value; }
		public string Helyes { get => helyes; set => helyes = value; }
		public string Kategoria { get => kategoria; set => kategoria = value; }
	}
}
