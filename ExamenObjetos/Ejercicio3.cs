using System;

public class Ejercicio3
{
    class class1
    {
        static void Main(string[] args)
        {
            var figuras = new List<IShape>()
            {
                new Rectangulo(Color.Rojo),
                new Circulo(Color.Azul),
                new Rectangulo(Color.Verde),
                new Flecha(Color.Azul)
            };

            foreach (var figura in figuras)
            {
                figura.Draw(Console.WriteLine);
            }
            Console.ReadLine();
        }
    }
    public enum Color
    {
        Rojo,
        Verde,
        Azul
    }
    public interface IShape
    {
        Color Color { get; set; }
        void Draw(Action<string> action);
    }
    public class Figura : IShape
    {
        public virtual void Draw(Action<string> action) { }
        public Color Color { get; set; }
    }
    public class Rectangulo : Figura
    {
        public Rectangulo(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(String.Format("Rectangulo de color {0}", this.Color));
        }
    }
    public class Circulo : Figura
    {
        public Circulo(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(String.Format("Circulo de color {0}", this.Color));
        }
    }
    public class Flecha : Figura
    {
        public Flecha(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<string> action)
        {
            action.Invoke(String.Format("Flecha de color {0}", this.Color));
        }
    }
}
