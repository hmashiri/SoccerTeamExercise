using System;

namespace SoccerTeams
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("List of Soccer Teams");
			Console.WriteLine("___________________________________");

			Team barcelona = new Barcelona();

			Console.WriteLine("Team Name: " + barcelona.TeamName);
			Console.WriteLine("League: " + barcelona.TeamLeague);
			Console.WriteLine("Country: " + barcelona.TeamCountry);
			Console.WriteLine("Coach: " + barcelona.TeamCoach);
			Console.WriteLine("Key Player: " + barcelona.TeamBestPlayer);

			Console.WriteLine("\n");

			Team bayern = new Bayern();

			Console.WriteLine("Team Name: " + bayern.TeamName);
			Console.WriteLine("League: " + bayern.TeamLeague);
			Console.WriteLine("Country: " + bayern.TeamCountry);
			Console.WriteLine("Coach: " + bayern.TeamCoach);
			Console.WriteLine("Key Player: " + bayern.TeamBestPlayer);
		}
	}
}
