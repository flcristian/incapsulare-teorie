using teorie;

internal class Program
{
    private static void Main(string[] args)
    {
        //Masina m1= new Masina(); // m este o referinta de tip masina ce retine adresa unui obiect

        //m1.Marca = "Mercedes-Benz";
        //m1.Model = "GT";
        //m1.NumarInmatriculare = "SB03MAO";
        //m1.NumeDetinator = "Alexandru Ioan";
        //m1.Culoare = "Negru";
        //m1.An = 2012;
        //m1.Greutate = 1477;

        

        //Masina m2 = new Masina("Saab", "9000", "43804", "Adoree Aspey", "Puce", 1993, 1457);
        //Masina m3 = new Masina("Lamborghini", "Murciélago", "121101", "Rosemary Leyden", "Mauv", 2010, 1441);
        //Masina m4 = new Masina("GMC", "1500 Club Coupe", "6094", "Seumas Spurret", "Crimson", 1994, 1634);
        //Masina m5 = new Masina("BMW", "745", "48672", "Penn Benkhe", "Mauv", 2003, 1742);
        //Masina m6 = new Masina("Toyota", "Tacoma", "34440", "Thurstan Buterton", "Indigo", 2003, 1644);



        ////Colectie de masini

        //List<Masina> masini = new List<Masina> { m1, m2, m3 };

        //masini.Add(m4);
        //masini.Add(m5);
        //masini.Add(m6);


        //for(int i = 0; i < masini.Count; i++)
        //{

        //    Console.WriteLine(masini[i].Describe());
        //}



        //Console.WriteLine("============================================");
        
        //foreach(Masina m in masini)
        //{


        //    Console.WriteLine( m.Describe());
        //}

        MasinaService s = new MasinaService();

        s.afisare();




    }
}