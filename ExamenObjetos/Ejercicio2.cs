using System;

public class Ejercicio2
{
    public enum Color
    {
        Rojo,
        Verde,
        Azul
    }
    public class Figura
    {
        public string Name { get; set; }
        public Color Color { get; set; }
    }
    public class Rectangulo : Figura
    {

    }
    public class Circulo : Figura
    {

    }
    public class Flecha : Figura
    {

    }
}
