<h1 align="center"> E.T. Nº12 D.E. 1º "Libertador Gral. José de San Martín" </h1>
<p align="center">
  <img src="https://et12.edu.ar/imgs/et12.gif">
</p>

# Computación : 2025

**Asignatura**: Desarrollo de Sistemas

**Nombre TP**: Titanes del Pacifico

**Apellido y Nombre Alumno**: Josu Duran

**Curso**: 5 ° 7

# Diagrama de Clases del Proyecto

```mermaid

classDiagram
    class Kaiju {
        - string Nombre
        - int Categoria
        - float Energia
        - float Vida
        - float Tamano
        - float Peso
        - List~Habilidad~ Habilidades
        + float CalcularPoderPelea()
        + float SumarDanoTotal()
    }

    class Habilidad {
        - string Nombre
        - float Dano
    }

    class Jaeger {
        - string Nombre
        - string Modelo
        - bool UsaReactorNuclear
        - List~Habilidad~ Habilidades
        - List~Piloto~ Pilotos
        + float CalcularPoderPelea()
    }

    class Piloto {
        - string Nombre
        - bool EsPilotoSolista
    }

    class Batalla {
        + string ObtenerGanador(Kaiju, Jaeger)
    }

    Kaiju --> Habilidad
    Jaeger --> Habilidad
    Jaeger --> Piloto
```