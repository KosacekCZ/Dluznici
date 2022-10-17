public class Zalobnicek {
  public string JmenoZalobce {get; private set;} = "";
  public int Rok {get; private set;}
  public double Castka { get; private set; }

  public Zalobnicek(String jmenoZalobce, int Rok, double Castka)
  {
    this.JmenoZalobce = JmenoZalobce;
    this.Rok = Rok;
    this.Castka = Castka;
  }
}