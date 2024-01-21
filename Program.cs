using static System.Console;
internal class Program
{

    private static void Main(string[] args)
    {
    /*
    //iniciacion de arreglos
        int[] edades;
        edades = new int[6];
        edades[0] = 33;
        edades[1] = 5;
        edades[2] = 66;
        edades[3] = 3;
        edades[4] = 23;

        Console.WriteLine(edades[4]);
        */

        //implicito

        var datos = new[] { "Juan", "Diaz", "Argentina"};

        var valores = new[] { 15, 33, 45.55 };//a pesar de ser diferentes los acepta, en este caso lo pasa a double

        //array objetos
        Empleados[] arrayEmp = new Empleados[2];
        arrayEmp[0] = new Empleados("Julian Rios", 48);
        Empleados Juan = new Empleados("Juan", 33);
        arrayEmp[1] = Juan;


        //array anonimos
        var personas = new[]
        {
        new {nombre="Pedro",edad=19},
        new {nombre="Maria", edad=45},
        new {nombre="Morena", edad=13}

        };
        //WriteLine(personas[2]);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(valores[i]);

        }

    }
    class Empleados
    {
        String nombre;
        int edad;
    public Empleados(String nombre, int edad)
    {
            this.nombre = nombre;
            this.edad = edad;
    }
    }
}