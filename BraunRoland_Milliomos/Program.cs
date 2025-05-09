namespace BraunRoland_Milliomos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StreamReader sr = new("kerdes.txt");
			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine();
				string[] adatok = sor.Split(';');
				Console.WriteLine($"Kérdés: {adatok[0]}");
				Console.WriteLine($"A: {adatok[1]}");
				Console.WriteLine($"B: {adatok[2]}");
				Console.WriteLine($"C: {adatok[3]}");
				Console.WriteLine($"D: {adatok[4]}");
				Console.WriteLine($"Helyes válasz: {adatok[5]}");
				Console.WriteLine("------------------------------");
		}
	}
}
