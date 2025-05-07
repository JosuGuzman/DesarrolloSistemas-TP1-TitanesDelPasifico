namespace Titanes.Core;

public class Habilidad
{
    public string Nombre { get; set; }
    public float Dano { get; set; }

    public Habilidad (string nombre, float dano)
    {
        Nombre = nombre;
        Dano = dano;
    }
}
