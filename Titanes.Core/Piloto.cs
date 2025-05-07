namespace Titanes.Core;

public class Piloto
{
    public string Nombre{ get; set; }
    public bool EsPilotoSolista { get; set; }

    public Piloto(string nombre, bool esPilotoSolista)
    {
        Nombre = nombre;
        EsPilotoSolista = esPilotoSolista;
    }
}