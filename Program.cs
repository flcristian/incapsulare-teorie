using teorie.masina.service;

internal class Program
{
    private static void Main(string[] args)
    {
        MasinaService s = new MasinaService();

        s.Afisare();

        Console.WriteLine(s.FindMasinaById(3).Describe());
    }
}