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

		public void Inditas()
		{
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
		
		}
	}
}

