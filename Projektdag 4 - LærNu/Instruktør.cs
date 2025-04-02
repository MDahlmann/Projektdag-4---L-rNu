namespace Projektdag_4___LærNu

{
    internal class Instruktør
    {
        public int Løn { get; set; }
        public char Køn { get; set; }
        public int Alder { get; set; }
        public string Kompetence { get; set; }
        public int InstruktørID { get; set; }
        public string Sprog { get; set; }
        public List<string> Kurser { get; set; }

        public Instruktør() { }

        public Instruktør(int løn, char køn, int alder, string kompetence, int instruktørID, string sprog)
        {
            Løn = løn;
            Køn = køn;
            Alder = alder;
            Kompetence = kompetence;
            InstruktørID = instruktørID;
            Sprog = sprog;

            Kurser = new List<string>();
        }

        public void TilføjKursus(string kursus)
        {
            Kurser.Add(kursus);
        }

    }
}
