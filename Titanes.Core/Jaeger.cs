namespace Titanes.Core;

public class Jaeger
{
    public string Nombre { get; set;}
    public string Modelo { get; set; }
    public bool UsaReactorNuclear { get; set;}
    public List<Habilidad> Habilidades;
    public List<Piloto> Pilotos;

    public Jaeger (string nombre, string modelo, bool usaReactorNuclear)
    {
        Nombre = nombre;
        Modelo = modelo;
        UsaReactorNuclear = usaReactorNuclear;
        Habilidades = new List<Habilidad>();
        Pilotos = new List<Piloto>();
    }

    public float CalcularPoderPelea()
    {
        return Habilidades.Sum(h => h.Dano) * 100;
    }
}