namespace Projektdag_4___LærNu
{
    internal class Studerende
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public int Alder { get; set; }
        public string Køn { get; set; }
        public int CPRNummer { get; set; }


        public Studerende(string fornavn, string efternavn, string adresse, int alder, string køn, int cprNummer)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Adresse = adresse;
            Alder = alder;
            Køn = køn;
            CPRNummer = cprNummer;
        }

        public string ReturnFullName()
        {

            return Fornavn + " " + Efternavn;
        }

        public void PrintStudInfo()
        {
            Console.WriteLine($"""
                Navn: {this.ReturnFullName()}
                Adresse: {Adresse}
                Alder: {Alder}
                Køn: {Køn}
                CPR-nr.: {CPRNummer}
                """);
        }
    }
}
