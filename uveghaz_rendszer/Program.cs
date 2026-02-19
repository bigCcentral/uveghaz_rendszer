namespace uveghaz_rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kezelo k = new Kezelo("Kovacs Peter", "kpeter", Szerepkor.ADMIN);
            Kezelo k1 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

            Novenyfaj n1 = new Novenyfaj("Paradicsom", 100, 10, 10);
            Cella cella = new Cella(new Pozicio(0, 0));
            Console.WriteLine(cella.Urescella);
            cella.Beultet(n1, 5);
            Console.WriteLine(cella.Urescella);





        }
    }
}
