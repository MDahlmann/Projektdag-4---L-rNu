namespace Projektdag_4___LærNu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instruktør ins1 = new Instruktør(60000, 'K', 45, "C# poweruser", 32, "Dansk");
            Instruktør ins2 = new Instruktør(35000, 'M', 42, "Samfundsfagslærer", 15, "Arabisk");

            Studerende stud1 = new Studerende("Mikkel", "Dahlmann", "Skarnbassen 11", 34, "Mand", 011190);
            Studerende stud2 = new Studerende("Alaa", "Daaami", "Vestervej 14", 27, "Mand", 030595);

            ins1.TilføjKursus("Programmering 101");
            ins1.TilføjKursus("Samfundsfag for begyndere");

            ins2.TilføjKursus("Italiensk for begyndere");
            ins2.TilføjKursus("SQL Advanced");

            stud1.PrintStudInfo();

            Console.ReadLine();
        }
    }
}