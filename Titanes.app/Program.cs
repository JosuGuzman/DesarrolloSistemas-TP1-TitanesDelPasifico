static void Main()
    {
        // Crear habilidades Kaiju
        var rayoPlasma = new Habilidad("Rayo de Plasma", 300);
        var pulsoEMP = new Habilidad("Pulso Electromagnético", 150);
        var garrasTitanicas = new Habilidad("Garras Titánicas", 200);

        // Crear Kaiju
        var knifehead = new Kaiju("Knifehead", categoria: 4, energia: 100, vida: 800, tamaño: 130, peso: 3000);
        knifehead.Habilidades.AddRange(new[] { rayoPlasma, garrasTitanicas });

        // Crear habilidades Jaeger
        var codoCohete = new Habilidad("Codo de Cohete", 180);
        var espada = new Habilidad("Espada", 220);
        var cañonPlasma = new Habilidad("Cañón de Plasma", 250);

        // Crear Jaeger
        var gipsy = new Jaeger("Gipsy Danger", modelo: "Analógico", usaReactor: true);
        gipsy.Habilidades.AddRange(new[] { codoCohete, espada, cañonPlasma });

        // Agregar pilotos
        gipsy.Pilotos.Add(new Piloto("Raleigh Becket", esPilotoSolista: true));
        gipsy.Pilotos.Add(new Piloto("Mako Mori", esPilotoSolista: false));

        // Mostrar información
        Console.WriteLine($"Jaeger: {gipsy.Nombre}");
        Console.WriteLine("Piloteado por:");
        foreach (var piloto in gipsy.Pilotos)
        {
            Console.WriteLine($"- {piloto.Nombre} {(piloto.EsPilotoSolista ? "(Piloto solista)" : "")}");
        }

        Console.WriteLine($"\nKaiju: {knifehead.Nombre}");
        Console.WriteLine("Habilidades:");
        foreach (var hab in knifehead.Habilidades)
        {
            Console.WriteLine($"- {hab.Nombre} (Daño: {hab.Dano})");
        }

        Console.WriteLine($"\nPoder de pelea del Kaiju: {knifehead.CalcularPoderPelea()}");
        Console.WriteLine($"Poder de pelea del Jaeger: {gipsy.CalcularPoderPelea()}");

        Console.WriteLine($"\nResultado de la batalla: {Batalla.ObtenerGanador(knifehead, gipsy)}");
    }
