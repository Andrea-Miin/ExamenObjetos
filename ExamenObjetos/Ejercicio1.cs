using System;

public class Ejercicio1
{
    static void Main(string[] args)
    {
        var foo = new RecogeFoo();
        do
        {
            Console.WriteLine("Antiguo nombre: " + foo.oldName);
            Console.Write("Introduzca nuevo nombre: ");
            foo.Name = Console.ReadLine();
            foo.oldName = foo.Name;
        } while (foo.Name != "exit");
    }

    public class RecogeFoo : Foo
    {
        public string oldName { get; set; }
    }

    public abstract class Foo
    {
        public string Name { get; set; }
    }
}
