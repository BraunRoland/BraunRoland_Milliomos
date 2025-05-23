namespace BraunRoland_Milliomos
{
	internal class Jatek
	{
		string nev;

		public Jatek(string nev)
		{
			this.nev = nev;
		}

		public string Nev { get => nev; set => nev = value; }
		

		public void Sorkerdes()
		{
			Random rnd = new Random();
			List<Kerdes> kerdesek = new List<Kerdes>();
			List<Sorkerdes> sorkerdesek = new List<Sorkerdes>();
			StreamReader sr = new("kerdes.txt");
			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] adatok = sor.Split(';');
				Kerdes kerdes = new Kerdes(int.Parse(adatok[0]), adatok[1], new List<string> { adatok[2], adatok[3], adatok[4], adatok[5] }, adatok[6], adatok[7]);
				kerdesek.Add(kerdes);
			}
			sr.Close();

			sr = new StreamReader("sorkerdes.txt");
			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] adatok = sor.Split(';');
				Sorkerdes sorkerdes = new Sorkerdes(adatok[0], new List<string> { adatok[1], adatok[2], adatok[3], adatok[4] }, adatok[5], adatok[6]);
				sorkerdesek.Add(sorkerdes);
			}
			sr.Close();

			//foreach(var item in kerdesek)
			//{
			//	foreach( var kerdes in item.Valaszok)
			//	{
			//		Console.Write(kerdes);
			//		Console.Write(", ");
			//	}
			//	Console.WriteLine();
			//}

			Console.WriteLine("Üdvözöllek a Legyen Ön Is Milliómos játékban, " + nev + "!");
			Console.WriteLine("Sorkérdés:");
			Sorkerdes ez = sorkerdesek[rnd.Next(0, sorkerdesek.Count)];
			Console.WriteLine($"Kategória: {ez.Kategoria}");
			Console.WriteLine(ez.Kerdes);
			Console.WriteLine($"A: {ez.Valaszok[0]}");
			Console.WriteLine($"B: {ez.Valaszok[1]}");
			Console.WriteLine($"C: {ez.Valaszok[2]}");
			Console.WriteLine($"D: {ez.Valaszok[3]}");
			Console.Write("Csak a Betűket add meg!: ");
			string valasz = Console.ReadLine();
			if (valasz.ToUpper() == ez.Helyes)
			{
				Console.WriteLine("Gratulálok! Tovább haladsz az igazi kérdésekhez!");
			}
			else
			{
				Console.WriteLine($"Sajnos nem Talált. A helyes válasz: {ez.Helyes}\nSzeretnéd újrapróbálni?(igen/nem): ");
				string ujrakezd = Console.ReadLine();
				if (ujrakezd.ToLower() == "igen" || ujrakezd.ToLower() == "i")
				{
					Sorkerdes();
				}
			}
		}

		static void Kerdesek(List <Kerdes> kerdesek)
		{
			Random rnd = new Random();
			List <Kerdes>jelenlegiKor = new List <Kerdes>();
			int[] nyeremenyek = [1, 2, 5, 10, 25, 50, 75, 100, 150, 200, 500, 1000, 1500, 2500, 5000];
			for (int i = 0; i < nyeremenyek.Length; i++) //jatekkörök
			{
				jelenlegiKor.Clear();
				for (int j = 0; j < kerdesek.Count; j++)
				{
					if (kerdesek[j].Nehezseg == i+1)
					{
						jelenlegiKor.Add(jelenlegiKor[j]);
					}
				}
				Console.WriteLine($"{i + 1}. kör. Nyeremény: {nyeremenyek[i] * 1000} Ft");
				Kerdes ez = jelenlegiKor[rnd.Next(0, jelenlegiKor.Count)];

			}
		}
	}
}

