namespace Dluznici;

public class ParseCSV
{
    public List<Zalobnicek> CsvToList(string path)
    {
        Dictionary<string, Zalobnicek> _temp = new Dictionary<string, Zalobnicek>();
        foreach (string line in System.IO.File.ReadLines(path))
        {
            string[] lines = line.Split(",");
            if (_temp.ContainsKey(lines[1]))
            {
                _temp[(lines[1])].Castka += (double.Parse(lines[2])));
            }
            else
            {
                _temp[]
            }
            _temp.Add(new Zalobnicek(
                (lines[1]),
                (int.Parse(lines[0])), 
                (double.Parse(lines[2]))));
        }
        return _temp;
    }
}