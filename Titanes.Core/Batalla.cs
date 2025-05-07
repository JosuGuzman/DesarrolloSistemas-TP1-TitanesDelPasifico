namespace Titanes.Core;

public class Batalla
{
    public static string ObtenerGanador(Kaiju kaiju, Jaeger jaeger)
    {
        float poderKaiju = kaiju.CalcularPoderPelea();
        float poderJaeger = jaeger.CalcularPoderPelea();

        if (poderKaiju > poderJaeger)
            return $"Gana el Kaiju {kaiju.Nombre} con poder {poderKaiju}";
        else if (poderJaeger > poderKaiju)
            return $"Gana el Jaeger {jaeger.Nombre} con poder {poderJaeger}";
        else
            return "Empate";
    }
}
