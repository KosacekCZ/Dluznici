namespace Dluznici;

public class ParseCSV
{
    public List<Zalobnicek> CsvToList(string path)
    {
        List<Zalobnicek> _temp = new List<Zalobnicek>();
        foreach (string line in System.IO.File.ReadLines(path))
        {
            string[] lines = line.Split(",");
            _temp.Add(new Zalobnicek(
                (lines[1]),
                (int.Parse(lines[0])), 
                (double.Parse(lines[2]))));
        }
        return _temp;
    }
}