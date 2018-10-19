using System;

public class Ejercicio4
{
    public enum Color
    {
        Rojo,
        Verde,
        Azul
    }
    public interface IShape
    {
        Color color { get; set; }
        void Draw(Action<string> action);
    }
    public class Figura : IShape, IDisposable
    {
        public Color color { get; set; }
        public virtual void Draw(Action<string> action); 
        public void Dispose()
        {

        }
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
