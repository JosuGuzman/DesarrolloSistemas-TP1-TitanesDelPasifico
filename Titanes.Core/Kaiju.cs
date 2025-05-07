namespace Titanes.Core;

public class Kaiju
{
    public string Nombre { get; set; }
    public int Categoria { get; set; }
    public float Energia { get; set; }
    public float Vida { get; set; }
    public float Tamaño { get; set; }
    public float Peso { get; set; }
    public List<Habilidad> Habilidades { get; set; }

    public Kaiju (string nombre,
    int categoria,
    float energia,
    float vida,
    float tamaño,
    float peso)
    {
        Nombre = nombre;
        Categoria = categoria;
        Energia = energia;
        Vida = vida;
        Tamaño = tamaño;
        Peso = peso;
        Habilidades = new List<Habilidad>();
    }

    public float SumarDanoTotal()
    {
        return Habilidades.Sum(h => h.Dano);
    }

    public float CalcularPoderPelea()
    {
        return Energia * SumarDanoTotal() * Categoria;
    }
}