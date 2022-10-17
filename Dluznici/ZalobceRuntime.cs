namespace Dluznici;

public class ZalobceRuntime
{
    public static void Main(string[] args)
    {
        ParseCSV pcsv = new ParseCSV();
        List<Zalobnicek> sortedListZ = pcsv.CsvToList("csv/naklady_zastoupeni.csv").OrderBy(z => z.Castka).ToList();
        Console.WriteLine(sortedListZ[sortedListZ.Count - 1].Castka);
    }
}